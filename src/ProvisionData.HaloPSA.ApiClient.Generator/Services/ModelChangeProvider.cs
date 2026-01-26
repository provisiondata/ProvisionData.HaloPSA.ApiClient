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
using ProvisionData.HaloPSA.ApiClient.Generator;
using ProvisionData.HaloPSA.ApiClient.ModelGenerator.Models;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace ProvisionData.HaloPSA.ApiClient.ModelGenerator.Services;

public partial class ModelChangeProvider : IModelChangeProvider
{
    private readonly ModelChanges _options;
    private readonly Dictionary<String, ModelChange> _changes;
    private readonly HashSet<String> _skips;
    private readonly ILogger<ModelChangeProvider> _logger;
    private readonly IModelChangeValidator _validator;

    public ModelChangeProvider(ILogger<ModelChangeProvider> logger, IModelChangeValidator validator, IOptions<ModelChanges> optionsAccessor)
    {
        _logger = logger;
        _validator = validator;
        _options = optionsAccessor.Value;
        _changes = ValidateChanges();

        _skips = new HashSet<String>(_options.Skip, StringComparer.InvariantCultureIgnoreCase);
    }

    private Dictionary<String, ModelChange> ValidateChanges()
    {
        var changes = new Dictionary<String, ModelChange>(StringComparer.InvariantCultureIgnoreCase);
        var isInvalid = false;

        foreach (var change in _options.Changes)
        {
            if (_validator.IsValid(change) is false)
            {
                isInvalid = true;
                _logger.LogWarning("Invalid Change: {@Change}", change);
                continue;
            }

            var key = GetKey(change);
            if (changes.ContainsKey(key))
            {
                isInvalid = true;
                _logger.LogWarning("Duplicate model found configuration for key '{Key}': {@Change}", key, change);
            }
            else
            {
                changes[key] = change;
            }
        }

        if (isInvalid)
        {
            throw new InvalidOperationException("One or more model found configurations are invalid. See log for details.");
        }

        return changes;
    }

    public String GetClassName(String jsonModelName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(jsonModelName);

        var key = GetKey(jsonModelName);

        if (_changes.TryGetValue(key, out var change) && !String.IsNullOrEmpty(change.ClientClasslName))
        {
            return change.ClientClasslName;
        }

        return jsonModelName.ToPascalCase();
    }

    public ModelChange GetChange([DisallowNull] String jsonModelName, JsonProperty jsonProperty)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(jsonModelName);

        var key = GetKey(jsonModelName, jsonProperty.Name);
        if (!_changes.TryGetValue(key, out var change))
        {
            change = new ModelChange()
            {
                JsonModelName = jsonModelName,
                JsonPropertyName = jsonProperty.Name
            };

            _changes.Add(key, change);
        }

        Update(change, jsonProperty.Value);

        return change;
    }

    public Boolean ShouldSkip(String jsonModelName)
        => _skips.Contains(jsonModelName);

    private String GetPropertyName(String jsonModelName, String jsonPropertyName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(jsonModelName);
        ArgumentException.ThrowIfNullOrWhiteSpace(jsonPropertyName);

        var key = GetKey(jsonModelName, jsonPropertyName);

        if (_changes.TryGetValue(key, out var change) && !String.IsNullOrEmpty(change.ClientPropertyName))
        {
            return change.ClientPropertyName;
        }

        return jsonPropertyName.ToPascalCase();
    }

    private static String GetKey(ModelChange c)
        => GetKey(c.JsonModelName, c.JsonPropertyName);

    private static String GetKey(String jsonModelName, String? jsonPropertyName = null)
        => jsonPropertyName is null
            ? jsonModelName
            : $"{jsonModelName}:{jsonPropertyName}";

    private void Update(ModelChange change, JsonElement jsonschema)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(change.JsonModelName);
        ArgumentException.ThrowIfNullOrWhiteSpace(change.JsonPropertyName);

        change.ClientClasslName = GetClassName(change.JsonModelName);
        change.ClientPropertyName = GetPropertyName(change.JsonModelName, change.JsonPropertyName);

        if (jsonschema.TryGetProperty("type", out var typeProp))
        {
            change.JsonTypeName = typeProp.GetString();
        }

        if (jsonschema.TryGetProperty("format", out var formatProp))
        {
            change.JsonFormat = formatProp.GetString();
        }

        if (jsonschema.TryGetProperty("nullable", out var nullableElement))
        {
            change.Nullable = nullableElement.ValueKind == JsonValueKind.True;
        }

        if (jsonschema.TryGetProperty("required", out var requiredElement))
        {
            change.Required = requiredElement.ValueKind == JsonValueKind.True;
        }

        if (String.Equals(change.JsonTypeName, "array", StringComparison.OrdinalIgnoreCase))
        {
            if (jsonschema.TryGetProperty("items", out var itemsElement))
            {
                MapRefOrType(change, itemsElement);

                change.ClientTypeName = $"List<{GetClassName(change.ClientTypeName!)}>";
            }
        }
        else
        {
            MapRefOrType(change, jsonschema);

            change.ClientTypeName = change.ClientTypeName switch
            {
                "String" when String.Equals(change.JsonFormat, "date-time", StringComparison.OrdinalIgnoreCase) => "DateTimeOffset",
                _ => GetClassName(change.ClientTypeName!).ToPascalCase()
            };
        }

        SetDefaultValue(change);
    }

    private void MapRefOrType(ModelChange change, JsonElement schema)
    {
        ArgumentNullException.ThrowIfNull(change);

        // Handle $ref first
        if (schema.TryGetProperty("$ref", out var refProp))
        {
            var refValue = refProp.GetString() ?? String.Empty;
            var name = refValue.Split('/').Last();
            change.ClientTypeName = name.ToPascalCase();
            return;
        }

        if (schema.TryGetProperty("type", out var typeProp))
        {
            switch (typeProp.GetString())
            {
                case "string":
                    change.ClientTypeName = "String";
                    return;

                case "integer":
                    if (schema.TryGetProperty("format", out var fmt) && fmt.GetString() == "int64")
                    {
                        change.ClientTypeName = "Int64";
                        return;
                    }

                    change.ClientTypeName = "Int32";
                    return;

                case "number":
                    if (schema.TryGetProperty("format", out var nfmt))
                    {
                        change.ClientTypeName = nfmt.GetString() switch
                        {
                            "float" => "Single",
                            "double" => "Double",
                            _ => "Decimal"
                        };
                        return;
                    }

                    change.ClientTypeName = "Decimal";
                    return;

                case "boolean":
                    change.ClientTypeName = "Boolean";
                    return;

                case "object":
                    change.ClientTypeName = "Object";
                    return;
            }
        }

        change.ClientTypeName = _options.UnknownTypeName;
    }

    private static void SetDefaultValue(ModelChange change)
    {
        if (String.IsNullOrWhiteSpace(change.ClientTypeName)
            || change.ClientTypeName.IsValueType())
        {
            change.DefaultValue = String.Empty;
            return;
        }

        if (change.JsonTypeName == "array")
            change.DefaultValue = " = [];";

        change.DefaultValue = change.ClientTypeName switch
        {
            "String" => " = String.Empty;",
            "Object" => " = new Object();",
            _ => " = new();"
        };
    }
}
