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

public partial class LicenceList

{
    [JsonPropertyName("add_configuration_items")]

    public List<Device_List>? AddConfigurationItems { get; set; }

    [JsonPropertyName("allow_licence_update")]
    public Boolean? AllowLicenceUpdate { get; set; }
    [JsonPropertyName("assigned_at_deletion")]
    public Int32? AssignedAtDeletion { get; set; }
    [JsonPropertyName("autorenew")]
    public Boolean? Autorenew { get; set; }

    //[JsonPropertyName("azure_connection")]
    //public UntypedNode? AzureConnection { get; set; }

    [JsonPropertyName("azure_connection_id")]
    public Int32? AzureConnectionId { get; set; }
    [JsonPropertyName("billing_cycle")]

    public String? BillingCycle { get; set; }

    [JsonPropertyName("client_id")]
    public Int32? ClientId { get; set; }
    [JsonPropertyName("client_name")]

    public String? ClientName { get; set; }

    [JsonPropertyName("configuration_items")]

    public List<Device_List>? ConfigurationItems { get; set; }

    [JsonPropertyName("consumedcount")]
    public Int32? Consumedcount { get; set; }
    [JsonPropertyName("count")]
    public Int32? Count { get; set; }
    [JsonPropertyName("_create_recurring_invoice_line")]
    public Boolean? CreateRecurringInvoiceLine { get; set; }
    [JsonPropertyName("deleted")]
    public Boolean? Deleted { get; set; }
    [JsonPropertyName("_details_id")]
    public Int32? DetailsId { get; set; }
    [JsonPropertyName("device_child_id")]
    public Int32? DeviceChildId { get; set; }
    [JsonPropertyName("device_count")]
    public Int32? DeviceCount { get; set; }
    [JsonPropertyName("distributor")]

    public String? Distributor { get; set; }

    [JsonPropertyName("end_date")]
    public DateTimeOffset? EndDate { get; set; }
    [JsonPropertyName("id")]
    public Int32? Id { get; set; }
    [JsonPropertyName("_importchildren")]
    public Boolean? Importchildren { get; set; }
    [JsonPropertyName("_importtype")]

    public String? Importtype { get; set; }

    [JsonPropertyName("ingram_micro_details_id")]
    public Int32? IngramMicroDetailsId { get; set; }
    [JsonPropertyName("is_active")]
    public Boolean? IsActive { get; set; }
    [JsonPropertyName("_isimport")]
    public Boolean? Isimport { get; set; }
    [JsonPropertyName("item_id")]
    public Int32? ItemId { get; set; }
    [JsonPropertyName("licence_client_name")]

    public String? LicenceClientName { get; set; }

    //[JsonPropertyName("licence_match")]
    //public List<UntypedNode>? LicenceMatch { get; set; }

    //[JsonPropertyName("licence_roles")]
    //public List<UntypedNode>? LicenceRoles { get; set; }

    [JsonPropertyName("licences_available")]
    public Int32? LicencesAvailable { get; set; }
    [JsonPropertyName("licences_in_use")]
    public Int32? LicencesInUse { get; set; }
    [JsonPropertyName("licences_in_use_user")]
    public Int32? LicencesInUseUser { get; set; }
    [JsonPropertyName("licences_in_use_user_for_billing")]
    public Int32? LicencesInUseUserForBilling { get; set; }
    [JsonPropertyName("linked_item")]

    public String? LinkedItem { get; set; }

    [JsonPropertyName("manufacturer")]

    public String? Manufacturer { get; set; }

    [JsonPropertyName("monthly_cost")]
    public Double? MonthlyCost { get; set; }
    [JsonPropertyName("monthly_price")]
    public Double? MonthlyPrice { get; set; }
    [JsonPropertyName("name")]

    public String? Name { get; set; }

    [JsonPropertyName("name_extra")]

    public String? NameExtra { get; set; }

    [JsonPropertyName("new_software")]

    public DeviceApplications? NewSoftware { get; set; }

    [JsonPropertyName("notes")]

    public String? Notes { get; set; }

    [JsonPropertyName("offerid")]

    public String? Offerid { get; set; }

    [JsonPropertyName("parent_id")]
    public Int32? ParentId { get; set; }
    [JsonPropertyName("price")]
    public Double? Price { get; set; }
    [JsonPropertyName("product_sku")]

    public String? ProductSku { get; set; }

    [JsonPropertyName("purchase_price")]
    public Double? PurchasePrice { get; set; }
    [JsonPropertyName("_removed")]
    public Boolean? Removed { get; set; }
    [JsonPropertyName("requested_quantity")]
    public Int32? RequestedQuantity { get; set; }
    [JsonPropertyName("requested_quantity_date")]
    public DateTimeOffset? RequestedQuantityDate { get; set; }
    [JsonPropertyName("site_id")]
    public Int32? SiteId { get; set; }
    [JsonPropertyName("site_name")]

    public String? SiteName { get; set; }

    [JsonPropertyName("snow_client_id")]
    public Int32? SnowClientId { get; set; }
    [JsonPropertyName("snowid")]

    public String? Snowid { get; set; }

    [JsonPropertyName("sqlimport_id")]
    public Int32? SqlimportId { get; set; }
    [JsonPropertyName("start_date")]
    public DateTimeOffset? StartDate { get; set; }
    [JsonPropertyName("status")]

    public String? Status { get; set; }

    [JsonPropertyName("supplier_id")]
    public Int32? SupplierId { get; set; }
    [JsonPropertyName("supplier_name")]

    public String? SupplierName { get; set; }

    [JsonPropertyName("tenant_id")]

    public String? TenantId { get; set; }

    [JsonPropertyName("tenant_name")]

    public String? TenantName { get; set; }

    [JsonPropertyName("term_duration")]

    public String? TermDuration { get; set; }

    [JsonPropertyName("thirdparty_client_id")]

    public String? ThirdpartyClientId { get; set; }

    [JsonPropertyName("third_party_product")]

    public String? ThirdPartyProduct { get; set; }

    [JsonPropertyName("third_party_productid")]

    public String? ThirdPartyProductid { get; set; }

    [JsonPropertyName("third_party_productname")]

    public String? ThirdPartyProductname { get; set; }

    [JsonPropertyName("type")]
    public Int32? Type { get; set; }
    [JsonPropertyName("vendor")]

    public String? Vendor { get; set; }

    [JsonPropertyName("vendor_product_sku")]

    public String? VendorProductSku { get; set; }

    [JsonPropertyName("_warning")]

    public String? Warning { get; set; }
}

