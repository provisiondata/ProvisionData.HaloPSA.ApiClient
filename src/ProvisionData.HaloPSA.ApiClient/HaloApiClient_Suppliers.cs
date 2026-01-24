using Flurl;
using Microsoft.Extensions.Logging;
using ProvisionData.HaloPSA.ApiClient.Models;
using System.Text.Json;

namespace ProvisionData.HaloPSA.ApiClient;
public partial class HaloApiClient
{
    public async Task<IReadOnlyList<Supplier>> ListSuppliersAsync()
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Supplier")
            .AppendQueryParam("count", 5000)
            .ToUri();
        var json = await HttpGetAsync(uri);

        try
        {
            var list = JsonSerializer.Deserialize<SuppliersList>(json, Options.JsonSerializerOptions)
                ?? throw new InvalidOperationException("Failed to deserialize SuppliersList.");

            return list.Suppliers;
        }
        catch (Exception ex)
        {
            throw new HaloApiException("Failed to deserialize AssetRoot.", json, ex);
        }
    }

    public async Task<String> CreateSupplierAsync(Supplier supplier)
    {
        ArgumentNullException.ThrowIfNull(supplier);

        var payload = JsonSerializer.Serialize(supplier, Options.JsonSerializerOptions);

        var json = await HttpPostAsync("Supplier", $"[{payload}]");

        Logger.LogDebug("Create Supplier Response: {json}", json);

        return json;
    }

    public Task UpdateSupplierAsync(Object value) => throw new NotImplementedException();
}
