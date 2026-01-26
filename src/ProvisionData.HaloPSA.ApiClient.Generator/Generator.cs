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

using Humanizer;
using Microsoft.Extensions.Options;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace ProvisionData.HaloPSA.ApiClient.Generator;

public partial class Generator(ILogger<Generator> logger, IOptions<GeneratorOptions> options, IOptions<ModelChanges> modelChangesOptions)
{
    private const String UnknownType = "UnknownType";

    private readonly ILogger<Generator> _logger = logger;
    private readonly GeneratorOptions _options = options.Value;
    private readonly Dictionary<String, String> _overrides
        = new(modelChangesOptions.Value.Overrides.ToDictionary(e => e.Key, e => e.Value), StringComparer.InvariantCultureIgnoreCase);
    private readonly HashSet<String> _skip = new([.. modelChangesOptions.Value.Skip], StringComparer.InvariantCultureIgnoreCase);

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

    public async Task GenerateAsync(String json, CancellationToken cancellationToken = default)
    {
        using var doc = JsonDocument.Parse(json);
        var root = doc.RootElement;

        if (root.TryGetProperty("components", out var components) && components.ValueKind == JsonValueKind.Object
            && components.TryGetProperty("schemas", out var schemas) && schemas.ValueKind == JsonValueKind.Object)
        {
            foreach (var schemaEntry in schemas.EnumerateObject())
            {
                if (_skip.Contains(schemaEntry.Name))
                {
                    _logger.LogInformation("Skipping generation of {SchemaName} as per configuration.", schemaEntry.Name);
                    continue;
                }

                var className = NormalizeName(schemaEntry.Name);
                var schema = schemaEntry.Value;
                var code = String.Empty;

                // Only generate for object types
                if (schema.TryGetProperty("type", out var typeProp) && typeProp.GetString() == "object")
                {
                    code = GenerateClassCode(className, schema);
                }

                if (schema.TryGetProperty("enum", out var enumProp) && enumProp.ValueKind == JsonValueKind.Array)
                {
                    code = GenerateEnumCode(className, enumProp);
                }

                var filePath = Path.Combine(_options.OutputPath, $"{className}.g.cs");
                await File.WriteAllTextAsync(filePath, code, cancellationToken);
                _logger.LogInformation("Wrote {File}", filePath);
            }
        }
        else
        {
            _logger.LogError("{OpenApiSchema} does not contain components.schemas with object definitions.",
                Path.GetFileName(_options.SpecificationPath));
        }
    }

    private String GenerateEnumCode(String className, JsonElement enumProp)
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

        return sb.ToString();
    }

    private String GenerateClassCode(String className, JsonElement schema)
    {
        var sb = GetHeader();
        sb.AppendLine("#nullable enable");
        sb.AppendLine();
        sb.AppendLine($"public partial class {className}");
        sb.AppendLine("{");

        if (schema.TryGetProperty("properties", out var properties) && properties.ValueKind == JsonValueKind.Object)
        {
            foreach (var prop in properties.EnumerateObject())
            {
                var propName = NormalizeName(prop.Name, className);
                var propSchema = prop.Value;

                var (type, typeName, isNullable) = MapType(propSchema, className);
                var nullableSuffix = isNullable && IsValueType(typeName) ? "?" : String.Empty;
                var defaultValue = GetDefaultValue(type, typeName);

                if (!IsValueType(typeName))
                {
                    typeName = isNullable ? typeName + "?" : typeName;
                }

                if (isNullable)
                {
                    sb.AppendLine("    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]");
                }

                sb.AppendLine($"    [JsonPropertyName(\"{prop.Name}\")]");
                sb.AppendLine($"    public {typeName}{nullableSuffix} {propName} {{ get; set; }}{defaultValue}");
                sb.AppendLine();
            }
        }

        sb.AppendLine("}");

        sb.AppendLine();
        sb.AppendLine("#nullable disable");
        sb.AppendLine();

        return sb.ToString();
    }

    private static String GetDefaultValue(String? type, String typeName)
    {
        if (String.IsNullOrWhiteSpace(typeName))
        {
            return String.Empty;
        }

        if (IsValueType(typeName))
        {
            return String.Empty;
        }

        if (type == "array")
            return " = [];";

        return typeName switch
        {
            "String" => " = String.Empty;",
            "Object" => " = new Object();",
            _ => " = new();"
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

    private (String? type, String typeName, Boolean isNullable) MapType(JsonElement propSchema, String? className = null)
    {
        String? type = null;
        String? format = null;
        Boolean isNullable = false;

        if (propSchema.TryGetProperty("type", out var typeProp))
        {
            type = typeProp.GetString();
        }

        if (propSchema.TryGetProperty("format", out var formatProp))
        {
            format = formatProp.GetString();
        }

        if (propSchema.TryGetProperty("nullable", out var nullableProp))
        {
            isNullable = nullableProp.ValueKind == JsonValueKind.True;
        }

        if (String.Equals(type, "array", StringComparison.OrdinalIgnoreCase))
        {
            if (propSchema.TryGetProperty("items", out var items))
            {
                var (typeName, _) = MapRefOrType(items);
                return (type, $"List<{NormalizeName(typeName)}>", isNullable);
            }

            return (type, "List<Object>", isNullable);
        }

        var (resolvedType, _) = MapRefOrType(propSchema);
        resolvedType = resolvedType switch
        {
            "String" when String.Equals(format, "date-time", StringComparison.OrdinalIgnoreCase) => "DateTimeOffset",
            _ => NormalizeName(resolvedType, className)
        };

        return (type, resolvedType, isNullable);
    }

    private (String typeName, Boolean isNullable) MapRefOrType(JsonElement schema)
    {
        // Handle $ref first
        if (schema.TryGetProperty("$ref", out var refProp))
        {
            var refValue = refProp.GetString() ?? String.Empty;
            var name = refValue.Split('/').Last();
            return (NormalizeName(name), false);
        }

        if (schema.TryGetProperty("type", out var typeProp))
        {
            switch (typeProp.GetString())
            {
                case "string":
                    return ("String", false);
                case "integer":
                    if (schema.TryGetProperty("format", out var fmt) && fmt.GetString() == "int64")
                    {
                        return ("Int64", false);
                    }

                    return ("Int32", false);
                case "number":
                    if (schema.TryGetProperty("format", out var nfmt))
                    {
                        return nfmt.GetString() switch
                        {
                            "float" => ("Single", false),
                            "double" => ("Double", false),
                            _ => ("Double", false)
                        };
                    }

                    return ("Double", false);
                case "boolean":
                    return ("Boolean", false);
                case "object":
                    return ("Object", false);
                default:
                    return (UnknownType, false);
            }
        }

        return (UnknownType, false);
    }

    private static Boolean IsValueType(String typeName)
    {
        return typeName is "Int32" or "Int64" or "Single" or "Double" or "Decimal" or "Boolean" or "DateTime" or "DateTimeOffset";
    }

    private static Boolean IsKnownType(String typeName)
    {
        if (typeName is "String")
            return true;

        return IsValueType(typeName);
    }

    private String NormalizeName(String name, String? className = null)
    {
        if (String.IsNullOrWhiteSpace(name) || IsKnownType(name))
        {
            return name;
        }

        // TODO: Lookup the name in the Overrides and use that if found.
        if (String.IsNullOrEmpty(className))
        {
            if (_overrides.TryGetValue(name, out var value))
            {
                return value;
            }
        }
        else if (_overrides.TryGetValue($"{className}:{name}", out var value))
        {
            return value;
        }

        var parts = name.Split(['_', '-', '.', ' ', '.'], StringSplitOptions.RemoveEmptyEntries);
        var sb = new StringBuilder();
        var first = true;
        foreach (var part in parts)
        {
            if (part.Length == 0)
            {
                continue;
            }

            var p = part;

            var match = StartsWithANumber().Match(p);
            if (first && match.Success && Int32.TryParse(match.Groups[1].Value, out var value))
            {
                p = p.Replace(value.ToString(), value.ToWords());
            }

            sb.Append(Char.ToUpperInvariant(p[0]));
            if (p.Length > 1)
            {
                sb.Append(p.AsSpan(1));
            }

            first = false;
        }

        return sb.ToString();
    }

    [GeneratedRegex("^([0-9]+)[a-zA-Z][a-zA-Z0-9_]+$")]
    private static partial Regex StartsWithANumber();

}
