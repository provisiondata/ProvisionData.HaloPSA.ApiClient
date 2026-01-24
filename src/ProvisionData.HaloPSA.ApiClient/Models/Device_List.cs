// Provision Data Systems Inc.
// Copyright (C) 2024 Doug Wilson
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



public partial class Device_List

{
	[JsonPropertyName("activity_statement")]

	public String? ActivityStatement { get; set; }

	[JsonPropertyName("addigy_id")]

	public String? AddigyId { get; set; }

	[JsonPropertyName("allowallcustombuttons")]
	public Boolean? Allowallcustombuttons { get; set; }
	[JsonPropertyName("allowallstatus")]
	public Boolean? Allowallstatus { get; set; }
	[JsonPropertyName("allowed_custombuttons")]

	public List<XTypeButton>? AllowedCustombuttons { get; set; }

	[JsonPropertyName("allowed_status")]

	public List<XTypeStatus>? AllowedStatus { get; set; }

	[JsonPropertyName("armis_id")]

	public String? ArmisId { get; set; }

	[JsonPropertyName("asset_field")]

	public String? AssetField { get; set; }

	[JsonPropertyName("assettype_guid")]
	public Guid? AssettypeGuid { get; set; }
	[JsonPropertyName("assettype_id")]
	public Int32? AssettypeId { get; set; }
	[JsonPropertyName("assettype_name")]

	public String? AssettypeName { get; set; }

	[JsonPropertyName("asset_type_priority")]
	public Int32? AssetTypePriority { get; set; }
	[JsonPropertyName("atera_id")]

	public String? AteraId { get; set; }

	[JsonPropertyName("auto_link")]
	public Boolean? AutoLink { get; set; }
	[JsonPropertyName("automate_id")]
	public Int32? AutomateId { get; set; }
	[JsonPropertyName("automate_url")]

	public String? AutomateUrl { get; set; }

	[JsonPropertyName("auvik_device_id")]

	public String? AuvikDeviceId { get; set; }

	[JsonPropertyName("auvik_id")]

	public String? AuvikId { get; set; }

	[JsonPropertyName("auvik_url")]

	public String? AuvikUrl { get; set; }

	[JsonPropertyName("aws_id")]

	public String? AwsId { get; set; }

	[JsonPropertyName("barracudarmm_id")]

	public String? BarracudarmmId { get; set; }

	[JsonPropertyName("bulkbillingperiod")]
	public Int32? Bulkbillingperiod { get; set; }
	[JsonPropertyName("bulkcreated")]
	public Boolean? Bulkcreated { get; set; }
	[JsonPropertyName("business_owner")]

	public String? BusinessOwner { get; set; }

	[JsonPropertyName("business_owner_cab_id")]
	public Int32? BusinessOwnerCabId { get; set; }
	[JsonPropertyName("business_owner_cab_name")]

	public String? BusinessOwnerCabName { get; set; }

	[JsonPropertyName("business_owner_client")]

	public String? BusinessOwnerClient { get; set; }

	[JsonPropertyName("business_owner_id")]
	public Int32? BusinessOwnerId { get; set; }
	[JsonPropertyName("business_owner_name")]

	public String? BusinessOwnerName { get; set; }

	[JsonPropertyName("business_owner_site")]

	public String? BusinessOwnerSite { get; set; }

	[JsonPropertyName("changebackupexists")]
	public Boolean? Changebackupexists { get; set; }
	[JsonPropertyName("changeguid")]
	public Guid? Changeguid { get; set; }
	[JsonPropertyName("changehistory_created_by")]

	public String? ChangehistoryCreatedBy { get; set; }

	[JsonPropertyName("changehistory_created_date")]
	public DateTimeOffset? ChangehistoryCreatedDate { get; set; }
	[JsonPropertyName("changehistory_last_updated")]
	public DateTimeOffset? ChangehistoryLastUpdated { get; set; }
	[JsonPropertyName("changehistory_updated_by")]

	public String? ChangehistoryUpdatedBy { get; set; }

	[JsonPropertyName("child_guid")]
	public Guid? ChildGuid { get; set; }
	[JsonPropertyName("child_id")]
	public Int32? ChildId { get; set; }
	[JsonPropertyName("client_id")]
	public Int32? ClientId { get; set; }
	[JsonPropertyName("client_name")]

	public String? ClientName { get; set; }

	[JsonPropertyName("colour")]

	public String? Colour { get; set; }

	[JsonPropertyName("commissiondate")]
	public DateTimeOffset? Commissiondate { get; set; }
	[JsonPropertyName("connectwisecontrolid")]

	public String? Connectwisecontrolid { get; set; }

	[JsonPropertyName("connectwise_control_url")]

	public String? ConnectwiseControlUrl { get; set; }

	[JsonPropertyName("connectwisermm_id")]

	public String? ConnectwisermmId { get; set; }

	[JsonPropertyName("contract_end_date")]
	public DateTimeOffset? ContractEndDate { get; set; }
	[JsonPropertyName("contract_id")]
	public Int32? ContractId { get; set; }
	[JsonPropertyName("contract_ref")]

	public String? ContractRef { get; set; }

	[JsonPropertyName("contract_value")]
	public Double? ContractValue { get; set; }
	[JsonPropertyName("criticality")]
	public Int32? Criticality { get; set; }
	[JsonPropertyName("criticality_description")]

	public String? CriticalityDescription { get; set; }

	[JsonPropertyName("custombuttons")]

	public List<CustomButton>? CustomButtons { get; set; }

	[JsonPropertyName("customfields")]

	public List<CustomField>? CustomFields { get; set; }

	[JsonPropertyName("datto_alternate_id")]
	public Int32? DattoAlternateId { get; set; }
	[JsonPropertyName("datto_id")]

	public String? DattoId { get; set; }

	[JsonPropertyName("datto_url")]

	public String? DattoUrl { get; set; }

	[JsonPropertyName("default_contract_value")]
	public Double? DefaultContractValue { get; set; }
	[JsonPropertyName("defaultsequence")]
	public Int32? Defaultsequence { get; set; }
	[JsonPropertyName("device42_id")]
	public Int32? Device42Id { get; set; }
	[JsonPropertyName("device42_url")]

	public String? Device42Url { get; set; }

	[JsonPropertyName("device_number")]
	public Int32? DeviceNumber { get; set; }
	[JsonPropertyName("domotz_id")]

	public String? DomotzId { get; set; }

	[JsonPropertyName("dynatrace_id")]

	public String? DynatraceId { get; set; }

	[JsonPropertyName("eracent_id")]

	public String? EracentId { get; set; }

	[JsonPropertyName("fields")]

	public List<FieldHelper>? Fields { get; set; }

	[JsonPropertyName("first_user_id")]
	public Int32? FirstUserId { get; set; }
	[JsonPropertyName("icinga_id")]

	public String? IcingaId { get; set; }

	[JsonPropertyName("icon")]

	public String? Icon { get; set; }

	[JsonPropertyName("id")]
	public Int32? Id { get; set; }
	[JsonPropertyName("impact_statement")]

	public String? ImpactStatement { get; set; }

	[JsonPropertyName("_importtype")]

	public String? Importtype { get; set; }

	[JsonPropertyName("inactive")]
	public Boolean? Inactive { get; set; }
	[JsonPropertyName("intent")]

	public String? Intent { get; set; }

	[JsonPropertyName("intune_default_site")]
	public Int32? IntuneDefaultSite { get; set; }
	[JsonPropertyName("intune_id")]

	public String? IntuneId { get; set; }

	[JsonPropertyName("inventory_number")]

	public String? InventoryNumber { get; set; }

	[JsonPropertyName("_isbatch")]
	public Boolean? Isbatch { get; set; }
	[JsonPropertyName("_isimport")]
	public Boolean? Isimport { get; set; }
	[JsonPropertyName("iskaseyaagent")]
	public Boolean? Iskaseyaagent { get; set; }
	[JsonPropertyName("is_primary_asset")]
	public Boolean? IsPrimaryAsset { get; set; }
	[JsonPropertyName("issue_consignment_line_id")]
	public Int32? IssueConsignmentLineId { get; set; }
	[JsonPropertyName("is_template")]
	public Boolean? IsTemplate { get; set; }
	[JsonPropertyName("item_id")]
	public Int32? ItemId { get; set; }
	[JsonPropertyName("item_name")]

	public String? ItemName { get; set; }

	[JsonPropertyName("itemstock_id")]
	public Int32? ItemstockId { get; set; }
	[JsonPropertyName("itglue_url")]

	public String? ItglueUrl { get; set; }

	[JsonPropertyName("kandji_id")]

	public String? KandjiId { get; set; }

	[JsonPropertyName("kaseya_id")]

	public String? KaseyaId { get; set; }

	[JsonPropertyName("kaseyavsa_url")]

	public String? KaseyavsaUrl { get; set; }

	[JsonPropertyName("key_field")]

	public String? KeyField { get; set; }

	[JsonPropertyName("key_field2")]

	public String? KeyField2 { get; set; }

	[JsonPropertyName("key_field3")]

	public String? KeyField3 { get; set; }

	[JsonPropertyName("labour_warranty_end")]
	public DateTimeOffset? LabourWarrantyEnd { get; set; }
	[JsonPropertyName("labour_warranty_start")]
	public DateTimeOffset? LabourWarrantyStart { get; set; }
	[JsonPropertyName("lansweeperid")]

	public String? Lansweeperid { get; set; }

	[JsonPropertyName("lansweeper_parent_id")]

	public String? LansweeperParentId { get; set; }

	[JsonPropertyName("lastchangeofvaluedate")]
	public DateTimeOffset? Lastchangeofvaluedate { get; set; }
	[JsonPropertyName("latest_contract_ref")]

	public String? LatestContractRef { get; set; }

	[JsonPropertyName("liongard_environmnet_id")]
	public Int32? LiongardEnvironmnetId { get; set; }
	[JsonPropertyName("liongard_id")]

	public String? LiongardId { get; set; }

	[JsonPropertyName("liongard_url")]

	public String? LiongardUrl { get; set; }

	[JsonPropertyName("logicmonitor_id")]

	public String? LogicmonitorId { get; set; }

	[JsonPropertyName("manageengine_customer_id")]

	public String? ManageengineCustomerId { get; set; }

	[JsonPropertyName("manageengine_id")]

	public String? ManageengineId { get; set; }

	[JsonPropertyName("manufacturer_id")]
	public Int32? ManufacturerId { get; set; }
	[JsonPropertyName("manufacturer_name")]

	public String? ManufacturerName { get; set; }

	[JsonPropertyName("matching_field")]

	public String? MatchingField { get; set; }

	[JsonPropertyName("nable_id")]

	public String? NableId { get; set; }

	[JsonPropertyName("ncentral_details_id")]
	public Int32? NcentralDetailsId { get; set; }
	[JsonPropertyName("ncentral_remote_url")]

	public String? NcentralRemoteUrl { get; set; }

	[JsonPropertyName("ncentral_url")]

	public String? NcentralUrl { get; set; }

	[JsonPropertyName("ninja_remote_url")]

	public String? NinjaRemoteUrl { get; set; }

	[JsonPropertyName("ninjarmm_id")]
	public Int32? NinjarmmId { get; set; }
	[JsonPropertyName("ninja_url")]

	public String? NinjaUrl { get; set; }

	[JsonPropertyName("non_consignable")]
	public Boolean? NonConsignable { get; set; }
	[JsonPropertyName("parent_guid")]
	public Guid? ParentGuid { get; set; }
	[JsonPropertyName("parent_id")]
	public Int32? ParentId { get; set; }
	[JsonPropertyName("passportal_id")]
	public Int64? PassportalId { get; set; }
	[JsonPropertyName("primary_asset_chart_json")]

	public String? PrimaryAssetChartJson { get; set; }

	[JsonPropertyName("priority_id")]
	public Int32? PriorityId { get; set; }
	[JsonPropertyName("priority_name")]

	public String? PriorityName { get; set; }

	[JsonPropertyName("prometheus_id")]

	public String? PrometheusId { get; set; }

	[JsonPropertyName("raynet_id")]

	public String? RaynetId { get; set; }

	[JsonPropertyName("related_service_count")]
	public Int32? RelatedServiceCount { get; set; }
	[JsonPropertyName("related_service_name")]

	public String? RelatedServiceName { get; set; }

	[JsonPropertyName("related_services")]

	public String? RelatedServices { get; set; }

	[JsonPropertyName("relationship_id")]
	public Int32? RelationshipId { get; set; }
	[JsonPropertyName("reserved_salesorder_id")]
	public Int32? ReservedSalesorderId { get; set; }
	[JsonPropertyName("reserved_salesorder_line_id")]
	public Int32? ReservedSalesorderLineId { get; set; }
	[JsonPropertyName("sequence")]
	public Int32? Sequence { get; set; }
	[JsonPropertyName("serialization_user")]
	public Int32? SerializationUser { get; set; }
	[JsonPropertyName("service_guid")]
	public Guid? ServiceGuid { get; set; }
	[JsonPropertyName("service_id")]
	public Int32? ServiceId { get; set; }
	[JsonPropertyName("service_ids")]

	public String? ServiceIds { get; set; }

	[JsonPropertyName("service_name")]

	public String? ServiceName { get; set; }

	[JsonPropertyName("sibling_id")]
	public Boolean? SiblingId { get; set; }
	[JsonPropertyName("site_id")]
	public Int32? SiteId { get; set; }
	[JsonPropertyName("site_name")]

	public String? SiteName { get; set; }

	[JsonPropertyName("sla_id")]
	public Int32? SlaId { get; set; }
	[JsonPropertyName("sla_name")]

	public String? SlaName { get; set; }

	[JsonPropertyName("snipeit_id")]

	public String? SnipeitId { get; set; }

	[JsonPropertyName("snow_id")]
	public Int32? SnowId { get; set; }
	[JsonPropertyName("status_id")]
	public Int32? StatusId { get; set; }
	[JsonPropertyName("status_name")]

	public String? StatusName { get; set; }

	[JsonPropertyName("stockbin_name")]

	public String? StockbinName { get; set; }

	[JsonPropertyName("stock_date")]
	public DateTimeOffset? StockDate { get; set; }
	[JsonPropertyName("supplier_contract_id")]
	public Int32? SupplierContractId { get; set; }
	[JsonPropertyName("supplier_contract_ref")]

	public String? SupplierContractRef { get; set; }

	[JsonPropertyName("supplier_id")]
	public Int32? SupplierId { get; set; }
	[JsonPropertyName("supplier_name")]

	public String? SupplierName { get; set; }

	[JsonPropertyName("supplier_priority_id")]
	public Int32? SupplierPriorityId { get; set; }
	[JsonPropertyName("supplier_purchasedate")]
	public DateTimeOffset? SupplierPurchasedate { get; set; }
	[JsonPropertyName("supplier_sla_id")]
	public Int32? SupplierSlaId { get; set; }
	[JsonPropertyName("syncro_id")]

	public String? Syncro_id { get; set; }

	[JsonPropertyName("syncroid")]
	public Int32? Syncroid { get; set; }
	[JsonPropertyName("syncro_url")]

	public String? SyncroUrl { get; set; }

	[JsonPropertyName("tanium_id")]

	public String? TaniumId { get; set; }

	[JsonPropertyName("teamviewerid")]

	public String? Teamviewerid { get; set; }

	[JsonPropertyName("technical_owner")]

	public String? TechnicalOwner { get; set; }

	[JsonPropertyName("technical_owner_cab_id")]
	public Int32? TechnicalOwnerCabId { get; set; }
	[JsonPropertyName("technical_owner_cab_name")]

	public String? TechnicalOwnerCabName { get; set; }

	[JsonPropertyName("technical_owner_id")]
	public Int32? TechnicalOwnerId { get; set; }
	[JsonPropertyName("technical_owner_name")]

	public String? TechnicalOwnerName { get; set; }

	[JsonPropertyName("tenable_id")]

	public String? TenableId { get; set; }

	[JsonPropertyName("third_party_id")]
	public Int32? ThirdPartyId { get; set; }
	[JsonPropertyName("use")]

	public String? Use { get; set; }

	[JsonPropertyName("username")]

	public String? Username { get; set; }

	[JsonPropertyName("virima_id")]

	public String? VirimaId { get; set; }

	[JsonPropertyName("vmworkspace_id")]

	public String? VmworkspaceId { get; set; }

	[JsonPropertyName("warranty_end")]
	public DateTimeOffset? WarrantyEnd { get; set; }
	[JsonPropertyName("warranty_start")]
	public DateTimeOffset? WarrantyStart { get; set; }
	[JsonPropertyName("workspace_id")]

	public String? WorkspaceId { get; set; }

	[JsonPropertyName("workspace_url")]

	public String? WorkspaceUrl { get; set; }

	[JsonPropertyName("xensam_id")]

	public String? XensamId { get; set; }

	[JsonPropertyName("zabbix_id")]

	public String? ZabbixId { get; set; }

	[JsonPropertyName("zabbix_url")]

	public String? ZabbixUrl { get; set; }
}

