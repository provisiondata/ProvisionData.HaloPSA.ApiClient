# Custom Fields - Quick Reference

## 📁 Key Files

| File | Purpose |
|------|---------|
| `custom-fields-config.json` | Defines which DTOs have custom fields and their types |
| `{Model}.CustomFields.g.cs` | Generated custom field implementation (DO NOT EDIT) |
| `{Model}.cs` | Manual partial class for custom logic (Create methods, etc.) |
| `IHasCustomFields.cs` | Interface and extension methods for custom field access |

## 🔧 For Library Developers

### Adding Custom Fields to a DTO

1. **Define in config** (`custom-fields-config.json`):
```json
{
  "CustomFieldMappings": {
    "YourDto": {
      "FieldName": {
        "type": "string",      // or int32, datetime, boolean, decimal
        "required": true,      // or false
        "description": "What this field represents"
      }
    }
  }
}
```

2. **Run generator** - Creates `YourDto.CustomFields.g.cs`

3. **Use in code**:
```csharp
var dto = await client.GetYourDtoAsync(123);
var value = dto.FieldName;  // Property access just works!
```

## 📝 For Library Consumers

### Configuration

Add to your `appsettings.json`:

```json
{
  "HaloPsaApiClient": {
    "FieldMappings": {
      "Asset": {
        "Name": 101,
        "SerialNumber": 117,
        "User": 148,
        "Model": 51,
        "PurchaseDate": 24
      }
    }
  }
}
```

**Note**: Field IDs are specific to your HaloPSA instance. Find them in HaloPSA admin panel under Custom Fields.

### Usage

```csharp
// Field mappings initialize automatically on first API call
var asset = await client.GetAssetAsync(123);

// Access custom fields like normal properties
Console.WriteLine($"Asset: {asset.Name}");
Console.WriteLine($"Serial: {asset.SerialNumber}");
Console.WriteLine($"Purchased: {asset.PurchaseDate:d}");

// Set custom fields
asset.Model = "Dell OptiPlex 7090";
await client.UpdateAssetAsync(asset);
```

## 🧪 For Testers

### Unit Testing DTOs

```csharp
public class AssetTests : IDisposable
{
    private readonly MockFieldMappingProvider _provider;
    
    public AssetTests()
    {
        // Reset static state for test isolation
        #if DEBUG
        Asset.ResetFieldMappingsForTesting();
        #endif
        
        // Setup mock provider
        _provider = new MockFieldMappingProvider();
        _provider.AddMapping("Asset", "Name", 101);
        _provider.AddMapping("Asset", "SerialNumber", 117);
    }
    
    [Fact]
    public void AssetName_WhenSet_StoresInFields()
    {
        // Arrange
        Asset.ApplyFieldMappings(_provider);
        var asset = new Asset { Fields = [] };
        
        // Act
        asset.Name = "Test Asset";
        
        // Assert
        Assert.Equal("Test Asset", asset.Name);
        Assert.Single(asset.Fields);
        Assert.Equal(101, asset.Fields[0].Id);
    }
    
    public void Dispose()
    {
        #if DEBUG
        Asset.ResetFieldMappingsForTesting();
        #endif
    }
}
```

### Mock Provider

```csharp
public class MockFieldMappingProvider : IFieldMappingProvider
{
    private readonly Dictionary<string, int> _mappings = new();
    
    public void AddMapping(string modelType, string fieldName, int fieldId)
    {
        _mappings[$"{modelType}.{fieldName}"] = fieldId;
    }
    
    public int GetFieldId(string modelType, string fieldName)
    {
        return _mappings.TryGetValue($"{modelType}.{fieldName}", out var id) ? id : 0;
    }
}
```

## 🐛 Troubleshooting

### "Asset field mappings not initialized"

**Problem**: Trying to create a DTO before field mappings are loaded.

**Solutions**:
```csharp
// Option 1: Make an API call first (auto-initializes)
var existing = await client.GetAssetAsync(1);
var newAsset = Asset.Create(...);  // Now works

// Option 2: Manually initialize
Asset.ApplyFieldMappings(fieldMappingProvider);
var newAsset = Asset.Create(...);  // Now works
```

### "Required field mappings not configured"

**Problem**: Required fields missing from `appsettings.json`.

**Solution**: Add missing field IDs to configuration:
```json
{
  "HaloPsaApiClient": {
    "FieldMappings": {
      "Asset": {
        "Name": 101,        // ← Required
        "SerialNumber": 117  // ← Required
      }
    }
  }
}
```

### Fields not persisting to HaloPSA

**Problem**: Field IDs in config don't match HaloPSA instance.

**Solution**: 
1. Log into HaloPSA admin panel
2. Navigate to Configuration → Custom Fields
3. Find the correct field IDs for your instance
4. Update `appsettings.json` with correct IDs

## 📊 Supported Types

| Config Type | C# Type | Example | Notes |
|-------------|---------|---------|-------|
| `string` | `String?` | `"Dell OptiPlex"` | Nullable string |
| `int32` | `Int32?` | `42` | Nullable integer |
| `datetime` | `DateTime?` | `2024-01-15` | ISO 8601 format |
| `boolean` | `Boolean?` | `true` | Nullable boolean |
| `decimal` | `Decimal?` | `1234.56` | Nullable decimal for currency/precision |

## 🎯 Best Practices

### ✅ DO

- Define required fields in config to enable validation
- Add descriptions to help other developers
- Use `ResetFieldMappingsForTesting()` in test teardown
- Keep custom logic in manual partial classes

### ❌ DON'T

- Edit `*.CustomFields.g.cs` files (they're regenerated)
- Use `forceReinit` in production code
- Forget to configure required fields in `appsettings.json`
- Put business logic in DTOs (they're just data containers)

## 🔗 Related Documentation

- [Field Mapping Analysis](field-mapping-analysis.md) - Architecture and design decisions
- [Generator Implementation Guide](generator-custom-fields-implementation-guide.md) - How to extend the generator
- [HaloPSA API Documentation](https://halo.haloservicedesk.com/apidoc) - Official API docs

## ❓ FAQ

**Q: Can I have different field IDs for different environments?**  
A: Yes! Use different `appsettings.{Environment}.json` files:
- `appsettings.Development.json`
- `appsettings.Production.json`

**Q: What happens if I don't configure a non-required field?**  
A: It will return `null`/empty and setting it will be silently ignored (fieldId = 0).

**Q: Can I add custom fields to any DTO?**  
A: Only to DTOs that have a `List<IdValue> Fields` property (most HaloPSA entities support this).

**Q: Are field mappings thread-safe?**  
A: Yes! The static initialization uses double-checked locking and is completely thread-safe.

**Q: Can I use this with multiple HaloPSA tenants?**  
A: Not in v1. Each application process supports one tenant. For multi-tenant scenarios, deploy separate instances.
