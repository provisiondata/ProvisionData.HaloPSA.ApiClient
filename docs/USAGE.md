# HaloPsaApiClient Usage Examples

## Table of Contents
- [Setup and Configuration](#setup-and-configuration)
- [Dependency Injection](#dependency-injection)
- [Working with Assets](#working-with-assets)
- [Working with Clients](#working-with-clients)
- [Error Handling](#error-handling)
- [Advanced Scenarios](#advanced-scenarios)

## Setup and Configuration

### Option 1: Using appsettings.json

**appsettings.json:**
```json
{
  "HaloPsaApiClient": {
    "AuthUrl": "https://your-instance.halopsa.com/auth/",
    "ApiUrl": "https://your-instance.halopsa.com/api/",
    "ClientId": "your-client-id",
    "ClientSecret": "your-client-secret",
    "ConnectionString": "Server=localhost;Database=Halo;Trusted_Connection=True;",
    "PageSize": 50
  }
}
```

**Program.cs:**
```csharp
var builder = WebApplication.CreateBuilder(args);

// Register HaloPsaApiClient with configuration
builder.Services.AddHaloPsaApiClient(builder.Configuration);

var app = builder.Build();
```

### Option 2: Manual Configuration

```csharp
builder.Services.AddHaloPsaApiClient(options =>
{
    options.AuthUrl = "https://your-instance.halopsa.com/auth/";
    options.ApiUrl = "https://your-instance.halopsa.com/api/";
    options.ClientId = Environment.GetEnvironmentVariable("HALO_CLIENT_ID")!;
    options.ClientSecret = Environment.GetEnvironmentVariable("HALO_CLIENT_SECRET")!;
    options.PageSize = 100;
});
```

### Option 3: Custom Configuration Section

```csharp
builder.Services.AddHaloPsaApiClient(builder.Configuration, "MyCustomHaloSection");
```

## Dependency Injection

### In Controllers

```csharp
[ApiController]
[Route("api/[controller]")]
public class AssetsController : ControllerBase
{
    private readonly HaloPsaApiClient _haloClient;
    private readonly ILogger<AssetsController> _logger;

    public AssetsController(
        HaloPsaApiClient haloClient,
        ILogger<AssetsController> logger)
    {
        _haloClient = haloClient;
        _logger = logger;
    }

    // ... controller actions
}
```

### In Services

```csharp
public class AssetSyncService : BackgroundService
{
    private readonly HaloPsaApiClient _haloClient;
    private readonly ILogger<AssetSyncService> _logger;

    public AssetSyncService(
        HaloPsaApiClient haloClient,
        ILogger<AssetSyncService> logger)
    {
        _haloClient = haloClient;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await SyncAssets(stoppingToken);
            await Task.Delay(TimeSpan.FromHours(1), stoppingToken);
        }
    }

    private async Task SyncAssets(CancellationToken cancellationToken)
    {
        var assets = await _haloClient.ListAssetsAsync(cancellationToken);
        _logger.LogInformation("Synced {Count} assets", assets.Count);
    }
}
```

## Working with Assets

### List All Assets

```csharp
public async Task<IActionResult> ListAssets(CancellationToken cancellationToken)
{
    try
    {
        var assets = await _haloClient.ListAssetsAsync(cancellationToken);
        return Ok(assets);
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Failed to list assets");
        return StatusCode(500, "An error occurred while retrieving assets");
    }
}
```

### Get Single Asset

```csharp
public async Task<IActionResult> GetAsset(int id, CancellationToken cancellationToken)
{
    try
    {
        var asset = await _haloClient.GetAssetAsync(id, cancellationToken);
        return Ok(asset);
    }
    catch (InvalidOperationException)
    {
        return NotFound();
    }
}
```

### Create Asset

```csharp
public async Task<IActionResult> CreateAsset(
    [FromBody] CreateAssetRequest request,
    CancellationToken cancellationToken)
{
    var createAsset = new CreateAsset
    {
        // Map your request to CreateAsset model
        // ... set properties
    };

    var asset = await _haloClient.CreateAssetAsync(createAsset, cancellationToken);
    return CreatedAtAction(nameof(GetAsset), new { id = asset.Id }, asset);
}
```

## Working with Clients

### List All Clients

```csharp
public async Task<IActionResult> ListClients(CancellationToken cancellationToken)
{
    var clients = await _haloClient.ListClientsAsync(cancellationToken);
    return Ok(clients);
}
```

### Get Client by ID

```csharp
public async Task<IActionResult> GetClient(int id, CancellationToken cancellationToken)
{
    var client = await _haloClient.GetClientAsync(id, cancellationToken);
    return Ok(client);
}
```

### Get Client by Name

```csharp
public async Task<IActionResult> GetClientByName(
    string name,
    CancellationToken cancellationToken)
{
    var client = await _haloClient.GetClientAsync(name, cancellationToken);
    return Ok(client);
}
```

## Error Handling

### Basic Error Handling

```csharp
try
{
    var asset = await _haloClient.GetAssetAsync(assetId, cancellationToken);
    return Ok(asset);
}
catch (InvalidOperationException ex)
{
    _logger.LogWarning(ex, "Asset {AssetId} not found", assetId);
    return NotFound();
}
catch (HttpRequestException ex)
{
    _logger.LogError(ex, "HTTP error occurred while fetching asset {AssetId}", assetId);
    return StatusCode(503, "Service temporarily unavailable");
}
catch (HaloPsaApiClientException ex)
{
    _logger.LogError(ex, "HaloAPI error: {Message}, JSON: {JSON}", ex.Message, ex.JSON);
    return StatusCode(500, "An error occurred communicating with HaloPSA");
}
```

### Global Exception Handling

```csharp
public class HaloApiExceptionFilter : IExceptionFilter
{
    private readonly ILogger<HaloApiExceptionFilter> _logger;

    public HaloApiExceptionFilter(ILogger<HaloApiExceptionFilter> logger)
    {
        _logger = logger;
    }

    public void OnException(ExceptionContext context)
    {
        if (context.Exception is HaloPsaApiClientException haloEx)
        {
            _logger.LogError(haloEx, "HaloAPI error: {Message}", haloEx.Message);
            context.Result = new ObjectResult(new
            {
                error = "An error occurred communicating with HaloPSA",
                details = haloEx.Message
            })
            {
                StatusCode = 500
            };
            context.ExceptionHandled = true;
        }
    }
}

// In Program.cs
builder.Services.AddControllers(options =>
{
    options.Filters.Add<HaloApiExceptionFilter>();
});
```

## Advanced Scenarios

### Configure HttpClient with Polly Retry Policy

```csharp
using Polly;
using Polly.Extensions.Http;

builder.Services.AddHaloPsaApiClient(builder.Configuration)
    .AddPolicyHandler(HttpPolicyExtensions
        .HandleTransientHttpError()
        .WaitAndRetryAsync(3, retryAttempt => 
            TimeSpan.FromSeconds(Math.Pow(2, retryAttempt))));
```

### Configure Custom Timeout

```csharp
builder.Services.AddHaloPsaApiClient(builder.Configuration)
    .ConfigureHttpClient(client =>
    {
        client.Timeout = TimeSpan.FromMinutes(10);
    });
```

### Use Multiple HaloPSA Instances

```csharp
// Register primary instance
builder.Services.AddHaloPsaApiClient(
    builder.Configuration,
    "HaloPsaApiClient:Primary");

// For multiple instances, you'll need to create named clients or separate service registrations
// This would require extending the HaloPsaApiClientExtensions class
```

### Background Service with Periodic Sync

```csharp
public class HaloSyncService : BackgroundService
{
    private readonly HaloPsaApiClient _haloClient;
    private readonly ILogger<HaloSyncService> _logger;
    private readonly TimeSpan _syncInterval = TimeSpan.FromMinutes(15);

    public HaloSyncService(
        HaloPsaApiClient haloClient,
        ILogger<HaloSyncService> logger)
    {
        _haloClient = haloClient;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("HaloSyncService started");

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                await PerformSync(stoppingToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during sync operation");
            }

            await Task.Delay(_syncInterval, stoppingToken);
        }
    }

    private async Task PerformSync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Starting sync operation");

        var assets = await _haloClient.ListAssetsAsync(cancellationToken);
        _logger.LogInformation("Retrieved {Count} assets", assets.Count);

        var clients = await _haloClient.ListClientsAsync(cancellationToken);
        _logger.LogInformation("Retrieved {Count} clients", clients.Count);

        // Process data...
    }
}

// Register in Program.cs
builder.Services.AddHostedService<HaloSyncService>();
```

### Scoped vs Singleton Considerations

The `HaloPsaApiClient` is registered as a **transient** service via `AddHttpClient<T>()`. Each time you inject it, you get a new instance with a fresh HttpClient from the pool.

If you need to share state or cache data, create a wrapper service:

```csharp
public class HaloDataService
{
    private readonly HaloPsaApiClient _client;
    private readonly IMemoryCache _cache;

    public HaloDataService(HaloPsaApiClient client, IMemoryCache cache)
    {
        _client = client;
        _cache = cache;
    }

    public async Task<IReadOnlyCollection<Asset>> GetCachedAssetsAsync(
        CancellationToken cancellationToken)
    {
        return await _cache.GetOrCreateAsync("assets", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5);
            return await _client.ListAssetsAsync(cancellationToken);
        });
    }
}

// Register as scoped or singleton based on your needs
builder.Services.AddScoped<HaloDataService>();
```
