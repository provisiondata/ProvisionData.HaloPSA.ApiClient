using System.Text.Json;

namespace ProvisionData.HaloPSA.ApiClient;

public class HaloApiClientOptions
{
    public String AuthUrl { get; set; } = "https://halo.pdsint.net/auth/";
    public String ApiUrl { get; set; } = "https://halo.pdsint.net/api/";
    public String ConnectionString { get; set; } = default!;
    public String ClientId { get; set; } = String.Empty;
    public String ClientSecret { get; set; } = String.Empty;

    public Int32 PageSize { get; set; } = 50;

    public JsonSerializerOptions JsonSerializerOptions { get; set; } = new();
}
