namespace ProvisionData.HaloPSA.ApiClient.Models;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

public class GetRecurringInvoicesResult
{
	[JsonPropertyName("page_size")]
	public Int32 PageSize { get; set; }

	[JsonPropertyName("record_count")]
	public Int32 RecordCount { get; set; }

	[JsonPropertyName("invoices")]
	public List<RecurringInvoice> Invoices { get; set; } = [];
}
