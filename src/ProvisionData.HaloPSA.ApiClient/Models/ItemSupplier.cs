namespace ProvisionData.HaloPSA.ApiClient.Models;

public class ItemSupplier
{
    [JsonPropertyName("id")]
    public required Int32 Id { get; set; }

    [JsonPropertyName("guid")]
    public required String Guid { get; set; }

    [JsonPropertyName("item_id")]
    public Int32? ItemId { get; set; }

    [JsonPropertyName("supplier_id")]
    public Int32? SupplierId { get; set; }

    [JsonPropertyName("supplier_name")]
    public required String SupplierName { get; set; }

    [JsonPropertyName("price")]
    public Int32? Price { get; set; }

    [JsonPropertyName("cost")]
    public Int32? Cost { get; set; }

    [JsonPropertyName("client_id")]
    public Int32 ClientId { get; set; } = -1;

    [JsonPropertyName("client_name")]
    public String ClientName { get; set; } = String.Empty;

    [JsonPropertyName("note")]
    public String Note { get; set; } = String.Empty;

    [JsonPropertyName("supplier_sku")]
    public required String SupplierSku { get; set; }
}
