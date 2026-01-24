namespace ProvisionData.HaloPSA.ApiClient.Models;

public record Supplier(
    [property: JsonPropertyName("name")] String Name,
    [property: JsonPropertyName("contact_name")] String? ContactName,
    [property: JsonPropertyName("email_address")] String? EmailAddress,
    [property: JsonPropertyName("phone_number")] String? PhoneNumber,
    [property: JsonPropertyName("address")] String? Address,
    [property: JsonPropertyName("website")] String? Website
)
{
    [property: JsonPropertyName("id")]
    public Int32? Id { get; set; }

    [property: JsonPropertyName("accounts_id")]
    public String? AccountsId { get; set; }
    [property: JsonPropertyName("contact_title")]
    public String? ContactTitle { get; set; }
    [property: JsonPropertyName("contract_count")]
    public Int32? ContractCount { get; set; }
    [property: JsonPropertyName("fax")]
    public String? Fax { get; set; }
    [property: JsonPropertyName("inactive")]
    public Boolean? Inactive { get; set; }
    [property: JsonPropertyName("logo")]
    public String? Logo { get; set; }
    [property: JsonPropertyName("mobile")]
    public String? Mobile { get; set; }
    [property: JsonPropertyName("notes")]
    public String? Notes { get; set; }
    [property: JsonPropertyName("phone_number_2")]
    public String? PhoneNumber2 { get; set; }
    [property: JsonPropertyName("phone_number_3")]
    public String? PhoneNumber3 { get; set; }
    [property: JsonPropertyName("portal_password")]
    public String? PortalPassword { get; set; }
    [property: JsonPropertyName("portal_ref")]
    public String? PortalRef { get; set; }
    [property: JsonPropertyName("portal_url")]
    public String? PortalUrl { get; set; }
    [property: JsonPropertyName("portal_username")]
    public String? PortalUsername { get; set; }
}

internal record SuppliersList(
    [property: JsonPropertyName("record_count")] Int32? RecordCount,
    [property: JsonPropertyName("suppliers")] IReadOnlyList<Supplier> Suppliers
);