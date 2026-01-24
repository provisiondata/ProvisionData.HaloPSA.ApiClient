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

using System.Diagnostics;
namespace ProvisionData.HaloPSA.ApiClient.Models;

[DebuggerDisplay("{Domain} - {ClientName}")]
public partial class DomainName
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public Int64? Id { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inventory_number")]
    public String Domain { get; set; } = String.Empty;

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("key_field")]
    //public String KeyField { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("key_field2")]
    //public String KeyField2 { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("key_field3")]
    //public String KeyField3 { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public Int64? ClientId { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_name")]
    public String ClientName { get; set; } = String.Empty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("site_id")]
    public Int64? SiteId { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("site_name")]
    public String? SiteName { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("business_owner_id")]
    //public Int64? BusinessOwnerId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("business_owner_name")]
    //public String BusinessOwnerName { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("business_owner_cab_id")]
    //public Int64? BusinessOwnerCabId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("username")]
    //public String Username { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("technical_owner_id")]
    //public Int64? TechnicalOwnerId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("technical_owner_name")]
    //public String TechnicalOwnerName { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("technical_owner_cab_id")]
    //public Int64? TechnicalOwnerCabId { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assettype_id")]
    public Int64? AssettypeId { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assettype_name")]
    public String? AssettypeName { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("colour")]
    public String? Colour { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Boolean? Inactive { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("supplier_id")]
    //public Int64? SupplierId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("supplier_contract_id")]
    //public Int64? SupplierContractId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("supplier_sla_id")]
    //public Int64? SupplierSlaId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("supplier_priority_id")]
    //public Int64? SupplierPriorityId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("itemstock_id")]
    //public Int64? ItemstockId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("item_id")]
    //public Int64? ItemId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("non_consignable")]
    //public Boolean? NonConsignable { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("reserved_salesorder_id")]
    //public Int64? ReservedSalesorderId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("reserved_salesorder_line_id")]
    //public Int64? ReservedSalesorderLineId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("device42_id")]
    //public Int64? Device42Id { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("criticality")]
    //public Int64? Criticality { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("use")]
    //public Use? Use { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("device_number")]
    //public Int64? DeviceNumber { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("status_id")]
    //public Int64? StatusId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("third_party_id")]
    //public Int64? ThirdPartyId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("automate_id")]
    //public Int64? AutomateId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("ninjarmm_id")]
    //public Int64? NinjarmmId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("syncroid")]
    //public Int64? Syncroid { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("itglue_url")]
    //public String ItglueUrl { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("defaultsequence")]
    //public Int64? Defaultsequence { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("datto_alternate_id")]
    //public Int64? DattoAlternateId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("passportal_id")]
    //public Int64? PassportalId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("auvik_device_id")]
    //public String AuvikDeviceId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("datto_id")]
    //public String DattoId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("addigy_id")]
    //public String AddigyId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("issue_consignment_line_id")]
    //public Int64? IssueConsignmentLineId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("item_name")]
    //public String ItemName { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("datto_url")]
    //public String DattoUrl { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("ncentral_details_id")]
    //public Int64? NcentralDetailsId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("sla_id")]
    //public Int64? SlaId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("priority_id")]
    //public Int64? PriorityId { get; set; }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //[JsonPropertyName("asset_type_priority")]
    //public Int64? AssetTypePriority { get; set; }
}
