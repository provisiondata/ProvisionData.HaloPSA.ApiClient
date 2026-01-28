// Provision Data HaloPSA API Client
// Copyright (C) 2026 Provision Data Systems Inc.
//
// This program is free software: you can redistribute it and/or modify it under the terms of
// the GNU Affero General Public License as published by the Free Software Foundation, either
// version 3 of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY
// without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License along with this
// program. If not, see <https://www.gnu.org/licenses/>.

using Microsoft.Extensions.Options;
using ProvisionData.HaloPSA.ApiClient.ModelGenerator.Models;
using System.Text;
using System.Text.Json;

namespace ProvisionData.HaloPSA.ApiClient.ModelGenerator.Services;

/// <summary>
/// Generates C# model classes and JsonSerializerContext files from an OpenAPI specification.
/// </summary>
public partial class Generator(ILogger<Generator> logger, IOptions<GeneratorOptions> options, IModelChangeProvider changeProvider) : IGenerator
{
    private readonly ILogger<Generator> _logger = logger;
    private readonly IModelChangeProvider _changeProvider = changeProvider;
    private readonly GeneratorOptions _options = options.Value;

    /// <summary>
    /// Category definitions for grouping types into focused JsonSerializerContexts.
    /// Each category is defined by a name and a set of type name prefixes.
    /// </summary>
    private static readonly Dictionary<String, String[]> TypeCategories = new()
    {
        ["Device"] = ["Device", "Asset"],
        ["Client"] = ["Area", "Client", "Site", "Company", "Organisation"],
        ["Ticket"] = ["Ticket", "Fault", "Action"],
        ["Invoice"] = ["Invoice", "Quotation", "Payment"],
        ["Contract"] = ["Contract"],
        ["Item"] = ["Item", "Stock", "Supplier", "Consignment"],
        ["User"] = ["User", "Uname", "Agent"],
        ["Configuration"] = ["Config", "Setting", "Setup", "Module", "Field", "Custom"],
        ["Integration"] = ["Integration", "Webhook", "Azure", "Microsoft", "Slack", "Teams"],
    };

    /// <summary>
    /// Generates all code from the OpenAPI specification.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    public async Task GenerateAsync(CancellationToken cancellationToken = default)
    {
        if (_options.IsValid() == false)
        {
            _logger.LogError("Generator options are not valid. Please check the configuration.");
            return;
        }

        if (!File.Exists(_options.SpecificationPath))
        {
            _logger.LogError("OpenAPI Specification not found at path: {Path}", _options.SpecificationPath);
            return;
        }

        if (!Directory.Exists(_options.OutputPath))
        {
            _logger.LogInformation("Output directory does not exist. Creating directory at path: {OutputPath}", _options.OutputPath);
            Directory.CreateDirectory(_options.OutputPath);
        }
        else if (_options.DeletePreviousOutputs)
        {
            var files = Directory.GetFiles(_options.OutputPath, "*.g.cs", SearchOption.TopDirectoryOnly);
            foreach (var file in files)
            {
                File.Delete(file);
            }

            _logger.LogInformation("Deleted {Count} previous output files in directory: {OutputPath}",
                files.Length, _options.OutputPath);
        }

        _logger.LogInformation("Starting code generation from OpenAPI specification at path: {SpecificationPath}", _options.SpecificationPath);

        try
        {
            var json = await File.ReadAllTextAsync(_options.SpecificationPath, cancellationToken);

            await GenerateAsync(json, cancellationToken);

            _logger.LogInformation("POCO generation completed successfully. Output written to: {OutputPath}", _options.OutputPath);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during POCO generation: {ErrorMessage}", ex.Message);
        }
    }

    private async Task GenerateAsync(String json, CancellationToken cancellationToken = default)
    {
        using var doc = JsonDocument.Parse(json);
        var root = doc.RootElement;

        if (root.TryGetProperty("components", out var components) && components.ValueKind == JsonValueKind.Object
            && components.TryGetProperty("schemas", out var schemas) && schemas.ValueKind == JsonValueKind.Object)
        {
            var generatedClasses = new List<String>();
            var counter = 0;

            foreach (var typeElement in schemas.EnumerateObject())
            {
                if (_changeProvider.ShouldSkip(typeElement.Name))
                {
                    _logger.LogInformation("Skipping generation of {SchemaName} as per configuration.", typeElement.Name);
                    continue;
                }

                var schema = typeElement.Value;
                GeneratedCode? code = null;

                // Only generate for known types
                if (schema.TryGetProperty("type", out var typeProp) && typeProp.GetString() == "object")
                {
                    code = GenerateClassCode(typeElement.Name, schema);
                    generatedClasses.Add(code.ClassName);
                    counter++;
                }
                else if (schema.TryGetProperty("enum", out var enumProp) && enumProp.ValueKind == JsonValueKind.Array)
                {
                    code = GenerateEnumCode(typeElement.Name, enumProp);
                    counter++;
                }
                else
                {
                    _logger.LogWarning("Skipping {SchemaName} as it is not an object or enum type.", typeElement.Name);
                    continue;
                }

                var filePath = Path.Combine(_options.OutputPath, $"{code.ClassName}.g.cs");
                await File.WriteAllTextAsync(filePath, code.Code, cancellationToken);
                _logger.LogInformation("Wrote {File}", filePath);
            }

            _logger.LogInformation("Generated {Count} classes/enums from OpenAPI specification.", counter);

            // Generate JsonSerializerContext files
            await GenerateJsonSerializerContextsAsync(generatedClasses, cancellationToken);
        }
        else
        {
            _logger.LogError("{OpenApiSchema} does not contain components.schemas with object definitions.",
                Path.GetFileName(_options.SpecificationPath));
        }
    }

    /// <summary>
    /// Generates multiple focused JsonSerializerContext files for better trimming support.
    /// </summary>
    /// <param name="generatedClasses">List of all generated class names.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    private async Task GenerateJsonSerializerContextsAsync(List<String> generatedClasses, CancellationToken cancellationToken)
    {
        // Group types by category
        var categorizedTypes = new Dictionary<String, List<String>>();
        var uncategorizedTypes = new List<String>();

        foreach (var className in generatedClasses)
        {
            var category = GetTypeCategory(className);
            if (category is not null)
            {
                if (!categorizedTypes.TryGetValue(category, out List<String>? value))
                {
                    value = [];
                    categorizedTypes[category] = value;
                }

                value.Add(className);
            }
            else
            {
                uncategorizedTypes.Add(className);
            }
        }

        // Add uncategorized types to a "Common" category
        if (uncategorizedTypes.Count > 0)
        {
            categorizedTypes["Common"] = uncategorizedTypes;
        }

        // Generate focused context for each category
        foreach (var (category, types) in categorizedTypes)
        {
            await GenerateFocusedContextAsync(category, types, cancellationToken);
        }

        // Generate the combined context that includes all types
        await GenerateCombinedContextAsync(generatedClasses, cancellationToken);

        _logger.LogInformation("Generated {Count} focused JsonSerializerContext files plus combined context.",
            categorizedTypes.Count);
    }

    /// <summary>
    /// Determines which category a type belongs to based on its name.
    /// </summary>
    /// <param name="typeName">The type name to categorize.</param>
    /// <returns>The category name, or null if uncategorized.</returns>
    private static String? GetTypeCategory(String typeName)
    {
        foreach (var (category, prefixes) in TypeCategories)
        {
            foreach (var prefix in prefixes)
            {
                if (typeName.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    return category;
                }
            }
        }

        return null;
    }

    /// <summary>
    /// Generates a focused JsonSerializerContext for a specific category of types.
    /// </summary>
    /// <param name="category">The category name.</param>
    /// <param name="types">The types in this category.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    private async Task GenerateFocusedContextAsync(String category, List<String> types, CancellationToken cancellationToken)
    {
        var contextName = $"HaloPsa{category}JsonContext";
        var sb = new StringBuilder();

        sb.AppendLine("// <auto-generated>");
        sb.AppendLine("// Generated by ProvisionData.HaloPSA.ApiClient.Generator");
        sb.AppendLine("// This focused context enables better trimming by only including related types.");
        sb.AppendLine("// </auto-generated>");
        sb.AppendLine();
        sb.AppendLine("using System.Text.Json.Serialization;");
        sb.AppendLine();
        sb.AppendLine(GetContextNamespace());
        sb.AppendLine();

        // Add JsonSerializable attributes for each type
        foreach (var typeName in types.OrderBy(t => t))
        {
            sb.AppendLine($"[JsonSerializable(typeof({GetModelsNamespace()}.{typeName}))]");
            sb.AppendLine($"[JsonSerializable(typeof(List<{GetModelsNamespace()}.{typeName}>))]");
        }

        sb.AppendLine("[JsonSourceGenerationOptions(");
        sb.AppendLine("    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,");
        sb.AppendLine("    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]");
        sb.AppendLine($"public partial class {contextName} : JsonSerializerContext");
        sb.AppendLine("{");
        sb.AppendLine("}");

        var parentDirectory = Directory.GetParent(_options.OutputPath)?.FullName ?? _options.OutputPath;
        var filePath = Path.Combine(parentDirectory, $"{contextName}.g.cs");
        await File.WriteAllTextAsync(filePath, sb.ToString(), cancellationToken);
        _logger.LogInformation("Generated focused context: {ContextName} with {TypeCount} types", contextName, types.Count);
    }

    /// <summary>
    /// Generates a combined JsonSerializerContext that includes all types.
    /// This is useful for users who don't need optimal trimming.
    /// </summary>
    /// <param name="allTypes">All generated class names.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    private async Task GenerateCombinedContextAsync(List<String> allTypes, CancellationToken cancellationToken)
    {
        var sb = new StringBuilder();

        sb.AppendLine("// <auto-generated>");
        sb.AppendLine("// Generated by ProvisionData.HaloPSA.ApiClient.Generator");
        sb.AppendLine("// This combined context includes all generated types.");
        sb.AppendLine("// For better trimming, use the focused contexts (e.g., HaloPsaDeviceJsonContext).");
        sb.AppendLine("// </auto-generated>");
        sb.AppendLine();
        sb.AppendLine("using System.Text.Json.Serialization;");
        sb.AppendLine();
        sb.AppendLine(GetContextNamespace());
        sb.AppendLine();

        // Add JsonSerializable attributes for each type
        foreach (var typeName in allTypes.OrderBy(t => t))
        {
            sb.AppendLine($"[JsonSerializable(typeof({GetModelsNamespace()}.{typeName}))]");
            sb.AppendLine($"[JsonSerializable(typeof(List<{GetModelsNamespace()}.{typeName}>))]");
        }

        sb.AppendLine("[JsonSourceGenerationOptions(");
        sb.AppendLine("    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,");
        sb.AppendLine("    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]");
        sb.AppendLine("public partial class HaloPsaApiJsonSerializerContext : JsonSerializerContext");
        sb.AppendLine("{");
        sb.AppendLine("}");

        var parentDirectory = Directory.GetParent(_options.OutputPath)?.FullName ?? _options.OutputPath;
        var filePath = Path.Combine(parentDirectory, "HaloPsaApiJsonSerializerContext.g.cs");
        await File.WriteAllTextAsync(filePath, sb.ToString(), cancellationToken);
        _logger.LogInformation("Generated combined context: HaloPsaApiJsonSerializerContext with {TypeCount} types", allTypes.Count);
    }

    /// <summary>
    /// Gets the namespace for the JsonSerializerContext files (parent of Models namespace).
    /// </summary>
    /// <returns>The namespace declaration.</returns>
    private String GetContextNamespace()
    {
        // Models namespace is typically "X.Y.Z.Models", context should be in "X.Y.Z"
        var modelsNamespace = _options.Namespace;
        var contextNamespace = modelsNamespace.EndsWith(".Models", StringComparison.OrdinalIgnoreCase)
            ? modelsNamespace[..^7] // Remove ".Models"
            : modelsNamespace;
        return $"namespace {contextNamespace};";
    }

    /// <summary>
    /// Gets the Models namespace for type references.
    /// </summary>
    /// <returns>The Models namespace.</returns>
    private String GetModelsNamespace() => _options.Namespace;

    private GeneratedCode GenerateEnumCode(String className, JsonElement enumProp)
    {
        var sb = GetHeader();

        sb.AppendLine($"public enum {className}");
        sb.AppendLine("{");

        var elements = enumProp.EnumerateArray().ToArray();
        for (var i = 0; i < elements.Length; i++)
        {
            var value = elements[i].GetInt32();
            if (value == 0)
            {
                sb.Append($"    None = {value}");
            }
            else if (value > 0)
            {
                sb.Append($"    Value_{value} = {value}");
            }
            else
            {
                sb.Append($"    Undefined_{Math.Abs(value)} = {value}");
            }

            if (i < elements.Length - 1)
            {
                sb.AppendLine(",");
            }
            else
            {
                sb.AppendLine();
            }
        }

        sb.AppendLine("}");
        sb.AppendLine();

        return new GeneratedCode() { ClassName = className, Code = sb.ToString() };
    }

    private GeneratedCode GenerateClassCode(String jsonTypeName, JsonElement schema)
    {
        var className = _changeProvider.GetClassName(jsonTypeName);

        var sb = GetHeader();

        sb.AppendLine("#nullable enable");
        sb.AppendLine();
        sb.AppendLine($"public partial class {className}");
        sb.AppendLine("{");

        if (schema.TryGetProperty("properties", out var properties) && properties.ValueKind == JsonValueKind.Object)
        {
            foreach (var prop in properties.EnumerateObject())
            {
                var change = _changeProvider.GetChange(jsonTypeName, prop);

                var nullableSuffix = String.Empty;

                if (change.Nullable == true)
                {
                    nullableSuffix = "?";
                    sb.AppendLine("    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]");
                }

                sb.AppendLine($"    [JsonPropertyName(\"{prop.Name}\")]");
                sb.AppendLine($"    public {change.ClientTypeName}{nullableSuffix} {change.ClientPropertyName} {{ get; set; }}{change.DefaultValue}");
                sb.AppendLine();
            }
        }
        else
        {
            sb.AppendLine($"        // NOTE: The schema for {jsonTypeName} had no properties defined.");
        }

        sb.AppendLine("}");

        sb.AppendLine();
        sb.AppendLine("#nullable disable");
        sb.AppendLine();

        return new GeneratedCode
        {
            ClassName = jsonTypeName,
            Code = sb.ToString()
        };
    }

    private StringBuilder GetHeader()
    {
        var sb = new StringBuilder();
        sb.AppendLine("// <auto-generated>");
        sb.AppendLine("// Generated by ProvisionData.HaloPSA.ApiClient.Generator");
        sb.AppendLine("// </auto-generated>");
        sb.AppendLine();
        sb.AppendLine($"namespace {_options.Namespace};");
        sb.AppendLine();
        return sb;
    }
}
