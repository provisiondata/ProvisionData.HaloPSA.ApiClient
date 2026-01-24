// Provision Data HaloPSA API Client
// Copyright (C) 2026 Provision Data Systems Inc.
//
// This program is free software: you can redistribute it and/or modify it under the terms of
// the GNU Affero General Public License as published by the Free Software Foundation, either
// version 3 of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY
// without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License along with this
// program. If not, see <https://www.gnu.org/licenses/>.

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
