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

public partial class Generator(ILogger<Generator> logger, IOptions<GeneratorOptions> options, IModelChangeProvider changeProvider) : IGenerator
{
    private readonly ILogger<Generator> _logger = logger;
    private readonly IModelChangeProvider _changeProvider = changeProvider;
    private readonly GeneratorOptions _options = options.Value;

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
        }
        else
        {
            _logger.LogError("{OpenApiSchema} does not contain components.schemas with object definitions.",
                Path.GetFileName(_options.SpecificationPath));
        }
    }

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
