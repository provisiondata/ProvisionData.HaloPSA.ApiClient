using Flurl;
using Microsoft.Extensions.Logging;
using ProvisionData.HaloPSA.ApiClient.Models;
using System.Text.Json;

namespace ProvisionData.HaloPSA.ApiClient;

public partial class HaloApiClient
{
    public async Task<IReadOnlyCollection<Item>> ListItemsAsync(CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Item")
            .AppendQueryParam("count", 5000)
            .ToUri();
        var json = await HttpGetAsync(uri, cancellationToken);

        try
        {
            var list = JsonSerializer.Deserialize<GetItemsResult>(json, Options.JsonSerializerOptions)
                ?? throw new InvalidOperationException("Failed to deserialize ItemsList.");

            return list.Items;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to list Items.");
            throw;
        }
    }

    public async Task<Item> GetItemAsync(Int32 itemId, CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Item")
            .AppendPathSegment(itemId)
            .ToUri();
        var json = await HttpGetAsync(uri, cancellationToken);

        try
        {
            var item = JsonSerializer.Deserialize<Item>(json, Options.JsonSerializerOptions)
                ?? throw new InvalidOperationException("Failed to deserialize ItemsList.");

            return item;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to get item: {ItemID}", itemId);
            throw;
        }
    }

    public async Task<Item> CreateItemAsync(CreateItem item, CancellationToken cancellationToken = default)
    {
        var payload = JsonSerializer.Serialize(item, Options.JsonSerializerOptions);

        var json = await HttpPostAsync("Item", $"[{payload}]", cancellationToken);

        Logger.LogDebug("Create Item Response: {json}", json);

        return JsonSerializer.Deserialize<Item>(json, Options.JsonSerializerOptions)!;
    }

    public Task UpdateItemAsync(Client value, CancellationToken cancellationToken = default)
        => throw new NotImplementedException();
}
