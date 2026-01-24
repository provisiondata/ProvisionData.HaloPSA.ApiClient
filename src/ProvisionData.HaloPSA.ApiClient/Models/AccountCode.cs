namespace ProvisionData.HaloPSA.ApiClient.Models;

public class AccountCode
{
    [JsonPropertyName("id")]
    public required Int32 Id { get; set; }

    [JsonPropertyName("lookupid")]
    public required Int32 LookupId { get; set; }

    [JsonPropertyName("name")]
    public String Name { get; set; } = String.Empty;

    [JsonPropertyName("value2")]
    public String Code { get; set; } = String.Empty;
}
