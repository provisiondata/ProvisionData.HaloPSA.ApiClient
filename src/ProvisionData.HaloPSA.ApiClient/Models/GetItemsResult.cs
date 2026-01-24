namespace ProvisionData.HaloPSA.ApiClient.Models;

public record GetItemsResult(
	[property: JsonPropertyName("record_count")]
	Int32? RecordCount,
	[property: JsonPropertyName("items")]
	IReadOnlyList<Item> Items
);
