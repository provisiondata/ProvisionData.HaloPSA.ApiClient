# ModelChanges Configuration - Include Feature

## Overview

The ModelChanges configuration in `appsettings.json` controls which types from the HaloPSA OpenAPI specification are generated into C# model classes, and how they are mapped.

## Include Feature (Type Filtering)

The generator uses an **Include** feature for type filtering:

- **Only types with entries in the `ModelChanges.Changes` array are generated**
- Types without any corresponding changes in the configuration are automatically excluded
- A type can be "included" by having either:
  - A model-level change (with `ClientDtoName` only)
  - One or more property-level changes

## Configuration Structure

### ModelChanges Root Object

```json
{
  "ModelChanges": {
    "Changes": [
      // Array of model change configurations
    ]
  }
}
```

## Change Types

### 1. Model-Level Changes (Class Mapping)

Used to rename the class or apply class-wide settings:

```json
{
  "JsonModelName": "Device",
  "ClientDtoName": "Asset"
}
```

**Effect**: Maps the API's `Device` type to the `Asset` C# class

### 2. Property-Level Changes

Used to rename properties or set default values:

```json
{
  "JsonModelName": "Device",
  "JsonPropertyName": "inventory_number",
  "ClientPropertyName": "AssetNumber",
  "Required": true
}
```

**Effect**: Maps the API's `inventory_number` property to `AssetNumber` in the `Asset` class and marks it as required

### Change Properties

| Property | Type | Description |
|----------|------|-------------|
| `JsonModelName` | string | **Required**. The name of the type in the OpenAPI specification. |
| `ClientDtoName` | string | New name for the C# class. Use for model-level changes only. |
| `JsonPropertyName` | string | Name of the property in the API JSON. Used for property-level changes. |
| `ClientPropertyName` | string | New name for the C# property. |
| `ClientPropertyType` | string | Override the inferred C# type (e.g., `List<IdValue>`). |
| `DefaultValue` | string | Default value initializer (e.g., `" = 0;"` or `" = default!;"`). |
| `Nullable` | boolean | Whether the property can be null (affects `?` suffix). |
| `Required` | boolean | Whether the property is required. |
| `Ignore` | boolean | Whether to skip this property during generation. |
| `PrivateConstructor` | boolean | Whether to create a private default constructor for deserialization. |

## Examples

### Including a Type by Renaming

```json
{
  "JsonModelName": "Area",
  "ClientDtoName": "Customer"
}
```

The `Area` type from the API is generated as the `Customer` C# class.

### Including a Type with Property Changes

```json
[
  {
    "JsonModelName": "Device",
    "JsonPropertyName": "site_id",
    "ClientPropertyName": "SiteId",
    "Required": true
  },
  {
    "JsonModelName": "Device",
    "JsonPropertyName": "status_id",
    "ClientPropertyName": "StatusId",
    "DefaultValue": " = 1;"
  }
]
```

The `Device` type is included (because it has property-level changes) and generates with modified property names and default values.

### Types NOT Included

If a type from the OpenAPI specification has no entries in the `ModelChanges.Changes` array, it will be skipped during generation:

```
Skipping generation of UnmappedType: not included in ModelChanges configuration.
```

## Migration from Skip to Include

Previously, the generator used a separate `Skip` array to explicitly exclude types. The refactored design uses the Include approach:

- **Old approach**: Define changes + maintain a separate Skip list
- **New approach**: Only include types by adding them to Changes

This simplifies configuration by maintaining a single source of truth.

## Best Practices

1. **Start with model-level changes**: Add a `ClientDtoName` change for types that need class-level customization
2. **Add property-level changes as needed**: Rename properties or set defaults
3. **Use meaningful names**: Map cryptic API names to UI-friendly C# names
4. **Be explicit**: Only add types to configuration that you want to generate
