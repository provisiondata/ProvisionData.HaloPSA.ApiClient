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

public class StockLocation
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("name")]
    public String Name { get; set; } = String.Empty;
    [JsonPropertyName("client_id")]
    public Int32 ClientId { get; set; }

    [JsonPropertyName("client_name")]
    public String ClientName { get; set; } = String.Empty;
    [JsonPropertyName("clientsite_name")]
    public String ClientsiteName { get; set; } = String.Empty;
    [JsonPropertyName("inactive")]
    public Boolean Inactive { get; set; }

    [JsonPropertyName("sla_id")]
    public Int32 SlaId { get; set; }

    [JsonPropertyName("phonenumber")]
    public String Phonenumber { get; set; } = String.Empty;
    [JsonPropertyName("colour")]
    public String Colour { get; set; } = String.Empty;
    [JsonPropertyName("timezone")]
    public String Timezone { get; set; } = String.Empty;
    [JsonPropertyName("invoice_address_isdelivery")]
    public Boolean InvoiceAddressIsdelivery { get; set; }

    [JsonPropertyName("notes")]
    public String Notes { get; set; } = String.Empty;
    [JsonPropertyName("isstocklocation")]
    public Boolean Isstocklocation { get; set; }

    [JsonPropertyName("messagegroup_id")]
    public Int32 MessagegroupId { get; set; }

    [JsonPropertyName("item_quantity_in_stock")]
    public Int32 ItemQuantityInStock { get; set; }

    [JsonPropertyName("item_serialised_assets_in_stock")]
    public Int32 ItemSerialisedAssetsInStock { get; set; }

    [JsonPropertyName("item_quantity_reserved")]
    public Int32 ItemQuantityReserved { get; set; }

    [JsonPropertyName("item_quantity_reserved_on_order")]
    public Int32 ItemQuantityReservedOnOrder { get; set; }

    [JsonPropertyName("item_quantity_available")]
    public Int32 ItemQuantityAvailable { get; set; }

    [JsonPropertyName("use")]
    public String Use { get; set; } = String.Empty;
    [JsonPropertyName("customfields")]
    public List<CustomField> Customfields { get; set; } = [];

    [JsonPropertyName("site_fields")]
    public List<SiteField> SiteFields { get; set; } = [];

    [JsonPropertyName("gfisiteid")]
    public Int32 Gfisiteid { get; set; }

    [JsonPropertyName("delivery_address_line1")]
    public String DeliveryAddressLine1 { get; set; } = String.Empty;
    [JsonPropertyName("delivery_address_line2")]
    public String DeliveryAddressLine2 { get; set; } = String.Empty;
    [JsonPropertyName("delivery_address_line3")]
    public String DeliveryAddressLine3 { get; set; } = String.Empty;
    [JsonPropertyName("delivery_address_line4")]
    public String DeliveryAddressLine4 { get; set; } = String.Empty;
    [JsonPropertyName("delivery_address_line5")]
    public String DeliveryAddressLine5 { get; set; } = String.Empty;
    [JsonPropertyName("itglue_id")]
    public String ItglueId { get; set; } = String.Empty;
    [JsonPropertyName("client_itglue_id")]
    public String ClientItglueId { get; set; } = String.Empty;
    [JsonPropertyName("custombuttons")]
    public List<CustomButton> Custombuttons { get; set; } = [];

    [JsonPropertyName("stockbin_id")]
    public Int32 StockbinId { get; set; }

    [JsonPropertyName("stockbin_name")]
    public String StockbinName { get; set; } = String.Empty;
    [JsonPropertyName("country_code_name")]
    public String CountryCodeName { get; set; } = String.Empty;
    [JsonPropertyName("region_code_name")]
    public String RegionCodeName { get; set; } = String.Empty;
    [JsonPropertyName("ref")]
    public String Ref { get; set; } = String.Empty;
    [JsonPropertyName("lapsafe_default_installation")]
    public String LapsafeDefaultInstallation { get; set; } = String.Empty;
    [JsonPropertyName("maincontact_id")]
    public Int32 MaincontactId { get; set; }

    [JsonPropertyName("site_item_tax_code")]
    public Int32 SiteItemTaxCode { get; set; }
}
