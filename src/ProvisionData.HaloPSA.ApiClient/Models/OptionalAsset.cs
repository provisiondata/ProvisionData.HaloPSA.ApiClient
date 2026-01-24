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

public class OptionalAsset
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("inventory_number")]
    public String InventoryNumber { get; set; } = String.Empty;
    [JsonPropertyName("key_field")]
    public String KeyField { get; set; } = String.Empty;
    [JsonPropertyName("key_field2")]
    public String KeyField2 { get; set; } = String.Empty;
    [JsonPropertyName("key_field3")]
    public String KeyField3 { get; set; } = String.Empty;
    [JsonPropertyName("client_id")]
    public Int32 ClientId { get; set; }

    [JsonPropertyName("client_name")]
    public String ClientName { get; set; } = String.Empty;
    [JsonPropertyName("site_id")]
    public Int32 SiteId { get; set; }

    [JsonPropertyName("site_name")]
    public String SiteName { get; set; } = String.Empty;
    [JsonPropertyName("business_owner_id")]
    public Int32 BusinessOwnerId { get; set; }

    [JsonPropertyName("business_owner_name")]
    public String BusinessOwnerName { get; set; } = String.Empty;
    [JsonPropertyName("business_owner_site")]
    public String BusinessOwnerSite { get; set; } = String.Empty;
    [JsonPropertyName("business_owner_client")]
    public String BusinessOwnerClient { get; set; } = String.Empty;
    [JsonPropertyName("business_owner_cab_id")]
    public Int32 BusinessOwnerCabId { get; set; }

    [JsonPropertyName("business_owner_cab_name")]
    public String BusinessOwnerCabName { get; set; } = String.Empty;
    [JsonPropertyName("username")]
    public String Username { get; set; } = String.Empty;
    [JsonPropertyName("technical_owner_id")]
    public Int32 TechnicalOwnerId { get; set; }

    [JsonPropertyName("technical_owner_name")]
    public String TechnicalOwnerName { get; set; } = String.Empty;
    [JsonPropertyName("technical_owner_cab_id")]
    public Int32 TechnicalOwnerCabId { get; set; }

    [JsonPropertyName("technical_owner_cab_name")]
    public String TechnicalOwnerCabName { get; set; } = String.Empty;
    [JsonPropertyName("intune_default_site")]
    public Int32 IntuneDefaultSite { get; set; }

    [JsonPropertyName("assettype_id")]
    public Int32 AssettypeId { get; set; }

    [JsonPropertyName("assettype_name")]
    public String AssettypeName { get; set; } = String.Empty;

    [JsonPropertyName("colour")]
    public String Colour { get; set; } = String.Empty;
    [JsonPropertyName("icon")]
    public String Icon { get; set; } = String.Empty;
    [JsonPropertyName("warranty_end")]
    public DateTime WarrantyEnd { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("inactive")]
    public Boolean Inactive { get; set; }

    [JsonPropertyName("is_primary_asset")]
    public Boolean IsPrimaryAsset { get; set; }

    [JsonPropertyName("parent_id")]
    public Int32 ParentId { get; set; }

    [JsonPropertyName("lansweeper_parent_id")]
    public String LansweeperParentId { get; set; } = String.Empty;
    [JsonPropertyName("child_id")]
    public Int32 ChildId { get; set; }

    [JsonPropertyName("sibling_id")]
    public Boolean SiblingId { get; set; }

    [JsonPropertyName("contract_value")]
    public Int32 ContractValue { get; set; }

    [JsonPropertyName("contract_ref")]
    public String ContractRef { get; set; } = String.Empty;

    [JsonPropertyName("contract_id")]
    public Int32 ContractId { get; set; }

    [JsonPropertyName("supplier_id")]
    public Int32 SupplierId { get; set; }

    [JsonPropertyName("supplier_name")]
    public String SupplierName { get; set; } = String.Empty;
    [JsonPropertyName("supplier_contract_id")]
    public Int32 SupplierContractId { get; set; }

    [JsonPropertyName("supplier_contract_ref")]
    public String SupplierContractRef { get; set; } = String.Empty;
    [JsonPropertyName("supplier_sla_id")]
    public Int32 SupplierSlaId { get; set; }

    [JsonPropertyName("supplier_priority_id")]
    public Int32 SupplierPriorityId { get; set; }

    [JsonPropertyName("fields")]
    public List<Field> Fields { get; set; } = [];
    [JsonPropertyName("customfields")]
    public List<CustomField> Customfields { get; set; } = [];
    [JsonPropertyName("relationship_id")]
    public Int32 RelationshipId { get; set; }

    [JsonPropertyName("custombuttons")]
    public List<CustomButton> Custombuttons { get; set; } = [];
    [JsonPropertyName("default_contract_value")]
    public Int32 DefaultContractValue { get; set; }

    [JsonPropertyName("itemstock_id")]
    public Int32 ItemstockId { get; set; }

    [JsonPropertyName("item_id")]
    public Int32 ItemId { get; set; }

    [JsonPropertyName("stock_date")]
    public DateTime StockDate { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("non_consignable")]
    public Boolean NonConsignable { get; set; }

    [JsonPropertyName("reserved_salesorder_id")]
    public Int32 ReservedSalesorderId { get; set; }

    [JsonPropertyName("reserved_salesorder_line_id")]
    public Int32 ReservedSalesorderLineId { get; set; }

    [JsonPropertyName("matching_field")]
    public String MatchingField { get; set; } = String.Empty;
    [JsonPropertyName("device42_id")]
    public Int32 Device42Id { get; set; }

    [JsonPropertyName("device42_url")]
    public String Device42Url { get; set; } = String.Empty;
    [JsonPropertyName("related_services")]
    public String RelatedServices { get; set; } = String.Empty;

    [JsonPropertyName("technical_owner")]
    public String TechnicalOwner { get; set; } = String.Empty;

    [JsonPropertyName("business_owner")]
    public String BusinessOwner { get; set; } = String.Empty;

    [JsonPropertyName("primary_asset_chart_json")]
    public String PrimaryAssetChartJson { get; set; } = String.Empty;
    [JsonPropertyName("criticality")]
    public Int32 Criticality { get; set; }

    [JsonPropertyName("use")]
    public String Use { get; set; } = String.Empty;
    [JsonPropertyName("device_number")]
    public Int32 DeviceNumber { get; set; }

    [JsonPropertyName("warranty_start")]
    public DateTime WarrantyStart { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("labour_warranty_start")]
    public DateTime LabourWarrantyStart { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("labour_warranty_end")]
    public DateTime LabourWarrantyEnd { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("status_id")]
    public Int32 StatusId { get; set; }

    [JsonPropertyName("status_name")]
    public String StatusName { get; set; } = String.Empty;
    [JsonPropertyName("third_party_id")]
    public Int32 ThirdPartyId { get; set; }

    [JsonPropertyName("sla_name")]
    public String SlaName { get; set; } = String.Empty;
    [JsonPropertyName("priority_name")]
    public String PriorityName { get; set; } = String.Empty;
    [JsonPropertyName("latest_contract_ref")]
    public String LatestContractRef { get; set; } = String.Empty;
    [JsonPropertyName("sequence")]
    public Int32 Sequence { get; set; }

    [JsonPropertyName("ncentral_url")]
    public String NcentralUrl { get; set; } = String.Empty;
    [JsonPropertyName("ncentral_remote_url")]
    public String NcentralRemoteUrl { get; set; } = String.Empty;
    [JsonPropertyName("contract_end_date")]
    public DateTime ContractEndDate { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("atera_id")]
    public String AteraId { get; set; } = String.Empty;
    [JsonPropertyName("automate_id")]
    public Int32 AutomateId { get; set; }

    [JsonPropertyName("automate_url")]
    public String AutomateUrl { get; set; } = String.Empty;
    [JsonPropertyName("connectwise_control_url")]
    public String ConnectwiseControlUrl { get; set; } = String.Empty;
    [JsonPropertyName("ninjarmm_id")]
    public Int32 NinjarmmId { get; set; }

    [JsonPropertyName("ninja_url")]
    public String NinjaUrl { get; set; } = String.Empty;
    [JsonPropertyName("syncro_url")]
    public String SyncroUrl { get; set; } = String.Empty;
    [JsonPropertyName("syncroid")]
    public Int32 Syncroid { get; set; }

    [JsonPropertyName("itglue_url")]
    public String ItglueUrl { get; set; } = String.Empty;
    [JsonPropertyName("defaultsequence")]
    public Int32 Defaultsequence { get; set; }

    [JsonPropertyName("service_ids")]
    public String ServiceIds { get; set; } = String.Empty;
    [JsonPropertyName("bulkcreated")]
    public Boolean Bulkcreated { get; set; }

    [JsonPropertyName("bulkbillingperiod")]
    public Int32 Bulkbillingperiod { get; set; }

    [JsonPropertyName("asset_field")]
    public String AssetField { get; set; } = String.Empty;
    [JsonPropertyName("datto_alternate_id")]
    public Int32 DattoAlternateId { get; set; }

    [JsonPropertyName("syncro_id")]
    public String SyncroId { get; set; } = String.Empty;
    [JsonPropertyName("domotz_id")]
    public String DomotzId { get; set; } = String.Empty;
    [JsonPropertyName("snow_id")]
    public Int32 SnowId { get; set; }

    [JsonPropertyName("passportal_id")]
    public Int32 PassportalId { get; set; }

    [JsonPropertyName("auvik_device_id")]
    public String AuvikDeviceId { get; set; } = String.Empty;
    [JsonPropertyName("auvik_url")]
    public String AuvikUrl { get; set; } = String.Empty;
    [JsonPropertyName("allowallstatus")]
    public Boolean Allowallstatus { get; set; }

    [JsonPropertyName("allowed_status")]
    public List<AllowedStatus> AllowedStatus { get; set; } = [];
    [JsonPropertyName("datto_id")]
    public String DattoId { get; set; } = String.Empty;
    [JsonPropertyName("addigy_id")]
    public String AddigyId { get; set; } = String.Empty;
    [JsonPropertyName("liongard_url")]
    public String LiongardUrl { get; set; } = String.Empty;
    [JsonPropertyName("liongard_environmnet_id")]
    public Int32 LiongardEnvironmnetId { get; set; }

    [JsonPropertyName("liongard_id")]
    public String LiongardId { get; set; } = String.Empty;
    [JsonPropertyName("kaseya_id")]
    public String KaseyaId { get; set; } = String.Empty;
    [JsonPropertyName("iskaseyaagent")]
    public Boolean Iskaseyaagent { get; set; }

    [JsonPropertyName("kaseyavsa_url")]
    public String KaseyavsaUrl { get; set; } = String.Empty;
    [JsonPropertyName("teamviewerid")]
    public String Teamviewerid { get; set; } = String.Empty;
    [JsonPropertyName("serialization_user")]
    public Int32 SerializationUser { get; set; }

    [JsonPropertyName("zabbix_id")]
    public String ZabbixId { get; set; } = String.Empty;
    [JsonPropertyName("zabbix_url")]
    public String ZabbixUrl { get; set; } = String.Empty;
    [JsonPropertyName("stockbin_name")]
    public String StockbinName { get; set; } = String.Empty;
    [JsonPropertyName("issue_consignment_line_id")]
    public Int32 IssueConsignmentLineId { get; set; }

    [JsonPropertyName("item_name")]
    public String ItemName { get; set; } = String.Empty;
    [JsonPropertyName("datto_url")]
    public String DattoUrl { get; set; } = String.Empty;
    [JsonPropertyName("ncentral_details_id")]
    public Int32 NcentralDetailsId { get; set; }

    [JsonPropertyName("nable_id")]
    public String NableId { get; set; } = String.Empty;
    [JsonPropertyName("connectwisecontrolid")]
    public String Connectwisecontrolid { get; set; } = String.Empty;
    [JsonPropertyName("_isimport")]
    public Boolean Isimport { get; set; }

    [JsonPropertyName("_importtype")]
    public String Importtype { get; set; } = String.Empty;
    [JsonPropertyName("workspace_id")]
    public String WorkspaceId { get; set; } = String.Empty;
    [JsonPropertyName("workspace_url")]
    public String WorkspaceUrl { get; set; } = String.Empty;
    [JsonPropertyName("intune_id")]
    public String IntuneId { get; set; } = String.Empty;
    [JsonPropertyName("supplier_purchasedate")]
    public DateTime SupplierPurchasedate { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("logicmonitor_id")]
    public String LogicmonitorId { get; set; } = String.Empty;
    [JsonPropertyName("barracudarmm_id")]
    public String BarracudarmmId { get; set; } = String.Empty;
    [JsonPropertyName("sla_id")]
    public Int32 SlaId { get; set; }

    [JsonPropertyName("priority_id")]
    public Int32 PriorityId { get; set; }

    [JsonPropertyName("icinga_id")]
    public String IcingaId { get; set; } = String.Empty;
    [JsonPropertyName("related_service_name")]
    public String RelatedServiceName { get; set; } = String.Empty;
    [JsonPropertyName("related_service_count")]
    public Int32 RelatedServiceCount { get; set; }

    [JsonPropertyName("connectwisermm_id")]
    public String ConnectwisermmId { get; set; } = String.Empty;
    [JsonPropertyName("xensam_id")]
    public String XensamId { get; set; } = String.Empty;
    [JsonPropertyName("asset_type_priority")]
    public Int32 AssetTypePriority { get; set; }

    [JsonPropertyName("snipeit_id")]
    public String SnipeitId { get; set; } = String.Empty;
    [JsonPropertyName("prometheus_id")]
    public String PrometheusId { get; set; } = String.Empty;
    [JsonPropertyName("dynatrace_id")]
    public String DynatraceId { get; set; } = String.Empty;
    [JsonPropertyName("vmworkspace_id")]
    public String VmworkspaceId { get; set; } = String.Empty;
    [JsonPropertyName("tanium_id")]
    public String TaniumId { get; set; } = String.Empty;
}
