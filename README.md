# ProvisionData.HaloPSA.ApiClient

A .NET API client library for **HaloPSA** (a Professional Services Automation platform). It provides typed .NET models and HTTP client wrappers to interact with the HaloPSA REST API.

## Installation

![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/provisiondata/ProvisionData.HaloPSA.ApiClient/ci.yml) ![NuGet Version](https://img.shields.io/nuget/v/!%5BNuGet%20Downloads%5D(https%3A%2F%2Fimg.shields.io%2Fnuget%2Fdt%2FProvisionData.HaloPSA.ApiClient))



```bash
dotnet add package ProvisionData.HaloPSA.ApiClient
```

## Quick Start

### Dependency Injection Setup

Add the client to your service collection using dependency injection:

```csharp
// Using appsettings.json configuration
builder.Services.AddHaloPsaApiClient(builder.Configuration);

// Or configure manually
builder.Services.AddHaloPsaApiClient(options =>
{
    options.AuthUrl = "https://your-instance.halopsa.com/auth/";
    options.ApiUrl = "https://your-instance.halopsa.com/api/";
    options.ClientId = "your-client-id";
    options.ClientSecret = "your-client-secret";
    options.PageSize = 50;
});
```

### Configuration (appsettings.json)

```json
{
  "HaloPsaApiClient": {
    "AuthUrl": "https://your-instance.halopsa.com/auth/",
    "ApiUrl": "https://your-instance.halopsa.com/api/",
    "ClientId": "your-client-id",
    "ClientSecret": "your-client-secret",
    "PageSize": 50
  }
}
```

### Usage in Controllers/Services

```csharp
public class AssetController : ControllerBase
{
    private readonly HaloPsaApiClient _haloClient;

    public AssetController(HaloPsaApiClient haloClient)
    {
        _haloClient = haloClient;
    }

    [HttpGet]
    public async Task<IActionResult> GetAssets()
    {
        var assets = await _haloClient.ListAssetsAsync();
        return Ok(assets);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsset(int id)
    {
        var asset = await _haloClient.GetAssetAsync(id);
        return Ok(asset);
    }
}
```

## Features

- **OAuth 2.0 Authentication** with automatic token management
- **Rate Limiting Handling** - Automatic retry with delay on 429 responses
- **Dependency Injection Ready** - Follows ASP.NET Core conventions
- **Type Safety** - Strongly typed models with JSON serialization
- **Comprehensive Logging** - Structured logging throughout
- **Pagination Support** - Configurable page size

## API Coverage

The client provides methods for:
- **Clients** - Customer/client management
- **Assets** - Asset tracking and management
- **Items** - Product/item management
- **Suppliers** - Supplier management
- **Recurring Invoices** - Invoice automation
- **Domain Names** - Domain name tracking
- **Account Codes** - Financial account codes

## Advanced Configuration

### Custom HttpClient Configuration

```csharp
builder.Services.AddHaloPsaApiClient(builder.Configuration)
    .ConfigureHttpClient(client =>
    {
        client.Timeout = TimeSpan.FromMinutes(10);
    })
    .AddPolicyHandler(GetRetryPolicy());
```

### Custom Configuration Section

```csharp
builder.Services.AddHaloPsaApiClient(builder.Configuration, "CustomHaloConfig");
```

## License

This project is licensed under the GNU Affero General Public License v3.0 (AGPL-3.0) - see the [LICENSE.md](LICENSE.md) file for details.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.
