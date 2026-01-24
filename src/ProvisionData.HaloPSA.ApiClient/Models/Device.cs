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

public partial class Device

{
    [JsonPropertyName("access_control")]
    public List<AccessControl>? AccessControl { get; set; }
    [JsonPropertyName("access_control_level")]
    public Int32? AccessControlLevel { get; set; }
    [JsonPropertyName("activity_statement")]
    public String? ActivityStatement { get; set; }
    [JsonPropertyName("add_child_assets")]
    public List<Device_List>? AddChildAssets { get; set; }
    [JsonPropertyName("addigy_applications")]
    public List<AddigyApplication>? AddigyApplications { get; set; }
    [JsonPropertyName("addigy_id")]
    public String? AddigyId { get; set; }
    [JsonPropertyName("addigy_policy_id")]
    public String? AddigyPolicyId { get; set; }
    [JsonPropertyName("addigy_users")]
    public List<String>? AddigyUsers { get; set; }
    [JsonPropertyName("add_licences")]
    public List<LicenceList>? AddLicences { get; set; }
    [JsonPropertyName("add_parent_assets")]
    public List<Device_List>? AddParentAssets { get; set; }
    [JsonPropertyName("_addserialisedassets")]
    public Boolean? Addserialisedassets { get; set; }
    [JsonPropertyName("add_sibling_assets")]
    public List<Device_List>? AddSiblingAssets { get; set; }
    [JsonPropertyName("allowallcustombuttons")]
    public Boolean? Allowallcustombuttons { get; set; }
    [JsonPropertyName("allowallstatus")]
    public Boolean? Allowallstatus { get; set; }
    [JsonPropertyName("allow_asset_maintenance")]
    public Boolean? AllowAssetMaintenance { get; set; }
    [JsonPropertyName("allowed_custombuttons")]
    public List<XTypeButton>? AllowedCustombuttons { get; set; }
    [JsonPropertyName("allowed_status")]
    public List<XTypeStatus>? AllowedStatus { get; set; }
    [JsonPropertyName("area_guid")]
    public String? AreaGuid { get; set; }
    [JsonPropertyName("armis_id")]
    public String? ArmisId { get; set; }
    [JsonPropertyName("ascendant_assets")]
    public List<Device>? AscendantAssets { get; set; }
    [JsonPropertyName("ascendant_count")]
    public Int32? AscendantCount { get; set; }
    [JsonPropertyName("asset_chart_json")]
    public String? AssetChartJson { get; set; }
    [JsonPropertyName("asset_field")]
    public String? AssetField { get; set; }
    [JsonPropertyName("assetgroup_name")]
    public String? AssetgroupName { get; set; }
    [JsonPropertyName("assettype_config")]
    public Xtype? AssettypeConfig { get; set; }
    [JsonPropertyName("assettype_guid")]
    public Guid? AssettypeGuid { get; set; }
    [JsonPropertyName("assettype_id")]
    public Int32? AssettypeId { get; set; }
    [JsonPropertyName("assettype_name")]
    public String? AssettypeName { get; set; }
    [JsonPropertyName("asset_type_priority")]
    public Int32? AssetTypePriority { get; set; }
    [JsonPropertyName("atera_id")]
    public String? Atera_id { get; set; }
    [JsonPropertyName("ateraid")]
    public String? Ateraid { get; set; }
    [JsonPropertyName("auto_link")]
    public Boolean? AutoLink { get; set; }
    [JsonPropertyName("automate_id")]
    public Int32? AutomateId { get; set; }
    [JsonPropertyName("automate_url")]
    public String? AutomateUrl { get; set; }
    [JsonPropertyName("auto_tag")]
    public Boolean? AutoTag { get; set; }
    [JsonPropertyName("auvik_device_id")]
    public String? AuvikDeviceId { get; set; }
    [JsonPropertyName("auvik_id")]
    public String? AuvikId { get; set; }
    [JsonPropertyName("auvik_network_id")]
    public String? AuvikNetworkId { get; set; }
    [JsonPropertyName("auvik_url")]
    public String? AuvikUrl { get; set; }
    [JsonPropertyName("aws_id")]
    public String? AwsId { get; set; }
    [JsonPropertyName("azureTenantId")]
    public String? AzureTenantId { get; set; }
    [JsonPropertyName("azure_userid")]
    public String? AzureUserid { get; set; }
    [JsonPropertyName("azure_userprincipalname")]
    public String? AzureUserprincipalname { get; set; }
    [JsonPropertyName("barracudarmm_id")]
    public String? BarracudarmmId { get; set; }
    [JsonPropertyName("bookmarked")]
    public Boolean? Bookmarked { get; set; }
    [JsonPropertyName("bulkbillingperiod")]
    public Int32? Bulkbillingperiod { get; set; }
    [JsonPropertyName("bulkcreated")]
    public Boolean? Bulkcreated { get; set; }
    [JsonPropertyName("businesscentral_id")]
    public String? BusinesscentralId { get; set; }
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
    [JsonPropertyName("child_asset_names")]
    public String? ChildAssetNames { get; set; }
    [JsonPropertyName("child_assets")]
    public List<Device_List>? ChildAssets { get; set; }
    [JsonPropertyName("child_guid")]
    public Guid? ChildGuid { get; set; }
    [JsonPropertyName("child_id")]
    public Int32? ChildId { get; set; }
    [JsonPropertyName("children")]
    public List<Device>? Children { get; set; }
    [JsonPropertyName("client_id")]
    public Int32? ClientId { get; set; }
    [JsonPropertyName("client_name")]
    public String? ClientName { get; set; }
    [JsonPropertyName("clone_count")]
    public Int32? CloneCount { get; set; }
    [JsonPropertyName("clone_inventory_numbers")]
    public String? CloneInventoryNumbers { get; set; }
    [JsonPropertyName("colour")]
    public String? Colour { get; set; }
    [JsonPropertyName("commissiondate")]
    public DateTimeOffset? Commissiondate { get; set; }
    [JsonPropertyName("commissioned")]
    public Int32? Commissioned { get; set; }
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
    [JsonPropertyName("contracts")]
    public List<Models.ContractHeaderList>? Contracts { get; set; }
    [JsonPropertyName("contract_value")]
    public Double? ContractValue { get; set; }
    [JsonPropertyName("contractvaluecurrent")]
    public Double? Contractvaluecurrent { get; set; }
    [JsonPropertyName("contractvalueprior")]
    public Double? Contractvalueprior { get; set; }
    [JsonPropertyName("copy_unmapped_info_fields")]
    public Boolean? CopyUnmappedInfoFields { get; set; }
    [JsonPropertyName("createdfrompurchaseorder")]
    public SupplierOrderHeader? Createdfrompurchaseorder { get; set; }
    [JsonPropertyName("created_from_template")]
    public Int32? CreatedFromTemplate { get; set; }
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
    [JsonPropertyName("datto_remote_url")]
    public String? DattoRemoteUrl { get; set; }
    [JsonPropertyName("datto_site_uid")]
    public String? DattoSiteUid { get; set; }
    [JsonPropertyName("datto_url")]
    public String? DattoUrl { get; set; }
    [JsonPropertyName("deactivate_child_devices")]
    public Boolean? DeactivateChildDevices { get; set; }
    [JsonPropertyName("default_contract_value")]
    public Double? DefaultContractValue { get; set; }
    [JsonPropertyName("defaultsequence")]
    public Int32? Defaultsequence { get; set; }
    [JsonPropertyName("delete_child_assets")]
    public List<Device_List>? DeleteChildAssets { get; set; }
    [JsonPropertyName("delete_parent_assets")]
    public List<Device_List>? DeleteParentAssets { get; set; }
    [JsonPropertyName("delete_sibling_assets")]
    public List<Device_List>? DeleteSiblingAssets { get; set; }
    [JsonPropertyName("descendant_assets")]
    public List<Device>? DescendantAssets { get; set; }
    [JsonPropertyName("descendant_count")]
    public Int32? DescendantCount { get; set; }
    [JsonPropertyName("device42_id")]
    public Int32? Device42Id { get; set; }
    [JsonPropertyName("device42_url")]
    public String? Device42Url { get; set; }
    [JsonPropertyName("device_number")]
    public Int32? DeviceNumber { get; set; }
    [JsonPropertyName("dlastupdate")]
    public DateTimeOffset? Dlastupdate { get; set; }
    [JsonPropertyName("domotz_agent")]
    public String? DomotzAgent { get; set; }
    [JsonPropertyName("domotz_agentid")]
    public Int32? DomotzAgentid { get; set; }
    [JsonPropertyName("domotz_id")]
    public Int32? DomotzId { get; set; }
    [JsonPropertyName("domotz_type_id")]
    public Int32? DomotzTypeId { get; set; }
    [JsonPropertyName("do_not_apply_template_in_the_api")]
    public Boolean? DoNotApplyTemplateInTheApi { get; set; }
    [JsonPropertyName("_donotvalidate")]
    public Boolean? Donotvalidate { get; set; }
    [JsonPropertyName("_dontaddnewfields")]
    public Boolean? Dontaddnewfields { get; set; }
    [JsonPropertyName("_dont_fire_automations")]
    public Boolean? DontFireAutomations { get; set; }
    [JsonPropertyName("_dontupdatetype")]
    public Boolean? Dontupdatetype { get; set; }
    [JsonPropertyName("dynatrace_from_relations")]
    public List<DynatraceRelationship>? DynatraceFromRelations { get; set; }
    [JsonPropertyName("dynatrace_id")]
    public String? DynatraceId { get; set; }
    [JsonPropertyName("dynatrace_to_relations")]
    public List<DynatraceRelationship>? DynatraceToRelations { get; set; }
    [JsonPropertyName("edit_child_assets")]
    public List<Device_List>? EditChildAssets { get; set; }
    [JsonPropertyName("edit_parent_assets")]
    public List<Device_List>? EditParentAssets { get; set; }
    [JsonPropertyName("edit_sibling_assets")]
    public List<Device_List>? EditSiblingAssets { get; set; }
    [JsonPropertyName("environment")]
    public Int32? Environment { get; set; }
    [JsonPropertyName("environments")]
    public List<Lookup>? Environments { get; set; }
    [JsonPropertyName("eracent_id")]
    public String? EracentId { get; set; }
    [JsonPropertyName("ethernetMacAddress")]
    public String? EthernetMacAddress { get; set; }
    [JsonPropertyName("external_links")]
    public List<ExternalLinkList>? ExternalLinks { get; set; }
    [JsonPropertyName("extratabs")]
    public List<Tabname>? Extratabs { get; set; }
    [JsonPropertyName("fields")]
    public List<FieldHelper>? Fields { get; set; }
    [JsonPropertyName("first_user_id")]
    public Int32? FirstUserId { get; set; }
    [JsonPropertyName("goodsin_po_id")]
    public Int32? GoodsinPoId { get; set; }
    [JsonPropertyName("guid")]
    public String? Guid { get; set; }
    [JsonPropertyName("hierarchy")]
    public List<Device>? Hierarchy { get; set; }
    [JsonPropertyName("icinga_hostname")]
    public String? IcingaHostname { get; set; }
    [JsonPropertyName("icinga_id")]
    public String? IcingaId { get; set; }
    [JsonPropertyName("icon")]
    public String? Icon { get; set; }
    [JsonPropertyName("id")]
    public Int32? Id { get; set; }
    [JsonPropertyName("impact_statement")]
    public String? ImpactStatement { get; set; }
    [JsonPropertyName("import_details_id")]
    public Int32? ImportDetailsId { get; set; }
    [JsonPropertyName("import_guid")]
    public Guid? ImportGuid { get; set; }
    [JsonPropertyName("_importtype")]
    public String? Importtype { get; set; }
    [JsonPropertyName("inactive")]
    public Boolean? Inactive { get; set; }
    [JsonPropertyName("intent")]
    public String? Intent { get; set; }
    [JsonPropertyName("intune_connectionid")]
    public Int32? IntuneConnectionid { get; set; }
    [JsonPropertyName("intune_default_site")]
    public Int32? IntuneDefaultSite { get; set; }
    [JsonPropertyName("intune_id")]
    public String? IntuneId { get; set; }
    [JsonPropertyName("intune_lastsyncdatetime")]
    public DateTimeOffset? IntuneLastsyncdatetime { get; set; }
    [JsonPropertyName("inventory_number")]
    public String? InventoryNumber { get; set; }
    [JsonPropertyName("isassetdetails")]
    public Boolean? Isassetdetails { get; set; }
    [JsonPropertyName("_isbatch")]
    public Boolean? Isbatch { get; set; }
    [JsonPropertyName("is_businessapp_instance")]
    public Boolean? IsBusinessappInstance { get; set; }
    [JsonPropertyName("_isclone")]
    public Boolean? Isclone { get; set; }
    [JsonPropertyName("_isimport")]
    public Boolean? Isimport { get; set; }
    [JsonPropertyName("iskaseyaagent")]
    public Boolean? Iskaseyaagent { get; set; }
    [JsonPropertyName("is_linked_businessapp")]
    public Boolean? IsLinkedBusinessapp { get; set; }
    [JsonPropertyName("is_linked_service")]
    public Boolean? IsLinkedService { get; set; }
    [JsonPropertyName("is_portfolio")]
    public Boolean? IsPortfolio { get; set; }
    [JsonPropertyName("is_primary_asset")]
    public Boolean? IsPrimaryAsset { get; set; }
    [JsonPropertyName("is_return")]
    public Boolean? IsReturn { get; set; }
    [JsonPropertyName("is_stock_change")]
    public Boolean? IsStockChange { get; set; }
    [JsonPropertyName("is_stock_site")]
    public Boolean? IsStockSite { get; set; }
    [JsonPropertyName("issue_consignment_id")]
    public Int32? IssueConsignmentId { get; set; }
    [JsonPropertyName("issue_consignment_line_id")]
    public Int32? IssueConsignmentLineId { get; set; }
    [JsonPropertyName("is_template")]
    public Boolean? IsTemplate { get; set; }
    [JsonPropertyName("item_cost")]
    public Double? ItemCost { get; set; }
    [JsonPropertyName("item_id")]
    public Int32? ItemId { get; set; }
    [JsonPropertyName("item_name")]
    public String? ItemName { get; set; }
    [JsonPropertyName("items_issued")]
    public List<FaultItem>? ItemsIssued { get; set; }
    [JsonPropertyName("itemstock_id")]
    public Int32? ItemstockId { get; set; }
    [JsonPropertyName("itglue_id")]
    public String? ItglueId { get; set; }
    [JsonPropertyName("itglue_url")]
    public String? ItglueUrl { get; set; }
    [JsonPropertyName("jamf_details_id")]
    public Int32? JamfDetailsId { get; set; }
    [JsonPropertyName("jamf_id")]
    public Int32? JamfId { get; set; }
    [JsonPropertyName("jamf_type")]
    public String? JamfType { get; set; }
    [JsonPropertyName("kandji_id")]
    public String? KandjiId { get; set; }
    [JsonPropertyName("kaseya_id")]
    public String? Kaseya_id { get; set; }
    [JsonPropertyName("kaseyaid")]
    public String? Kaseyaid { get; set; }
    [JsonPropertyName("kaseyavsa_url")]
    public String? KaseyavsaUrl { get; set; }
    [JsonPropertyName("kbs")]

    public List<KBEntryList>? Kbs { get; set; }

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
    [JsonPropertyName("lansweeper_id")]

    public String? Lansweeper_id { get; set; }

    [JsonPropertyName("lansweeperid")]

    public String? Lansweeperid { get; set; }

    [JsonPropertyName("lansweeper_parent_id")]

    public String? LansweeperParentId { get; set; }

    [JsonPropertyName("lansweeper_relations")]

    public List<LansweeperRelation>? LansweeperRelations { get; set; }

    [JsonPropertyName("lansweeper_site_id")]

    public String? LansweeperSiteId { get; set; }

    [JsonPropertyName("lansweeper_software")]

    public List<LansweeperSoftware>? LansweeperSoftware { get; set; }

    [JsonPropertyName("lansweeper_url")]

    public String? LansweeperUrl { get; set; }

    [JsonPropertyName("lastchangeofvaluedate")]
    public DateTimeOffset? Lastchangeofvaluedate { get; set; }
    [JsonPropertyName("last_modified")]
    public DateTimeOffset? LastModified { get; set; }
    [JsonPropertyName("latest_contract_ref")]

    public String? LatestContractRef { get; set; }

    [JsonPropertyName("licence_count")]
    public Int32? LicenceCount { get; set; }
    [JsonPropertyName("licences")]

    public List<LicenceList>? Licences { get; set; }

    [JsonPropertyName("licences_hierarchy")]

    public List<LicenceList>? LicencesHierarchy { get; set; }

    [JsonPropertyName("linked_service")]

    public ServSite? LinkedService { get; set; }

    [JsonPropertyName("liongard_id")]

    public String? Liongard_id { get; set; }

    [JsonPropertyName("liongard_environmnet_id")]
    public Int32? LiongardEnvironmnetId { get; set; }
    [JsonPropertyName("liongardid")]
    public Int32? Liongardid { get; set; }
    [JsonPropertyName("liongard_url")]

    public String? LiongardUrl { get; set; }

    [JsonPropertyName("logicmonitor_id")]

    public String? LogicmonitorId { get; set; }

    [JsonPropertyName("maintenance_windows")]

    public List<Holidays>? MaintenanceWindows { get; set; }

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

    [JsonPropertyName("matching_value")]

    public String? MatchingValue { get; set; }

    [JsonPropertyName("_match_integration_id")]
    public Int32? MatchIntegrationId { get; set; }
    [JsonPropertyName("_match_integration_name")]

    public String? MatchIntegrationName { get; set; }

    [JsonPropertyName("_match_thirdparty_id")]

    public String? MatchThirdpartyId { get; set; }

    [JsonPropertyName("nable_id")]

    public String? NableId { get; set; }

    [JsonPropertyName("ncentral_details_id")]
    public Int32? NcentralDetailsId { get; set; }
    [JsonPropertyName("ncentral_remote_url")]

    public String? NcentralRemoteUrl { get; set; }

    [JsonPropertyName("ncentral_url")]

    public String? NcentralUrl { get; set; }

    [JsonPropertyName("new_access_control")]

    public List<AccessControl>? NewAccessControl { get; set; }

    [JsonPropertyName("new_external_link")]

    public ExternalLinkList? NewExternalLink { get; set; }

    [JsonPropertyName("new_software_version")]

    public String? NewSoftwareVersion { get; set; }

    [JsonPropertyName("ninja_remote_url")]

    public String? NinjaRemoteUrl { get; set; }

    [JsonPropertyName("ninjarmm_id")]
    public Int32? NinjarmmId { get; set; }
    [JsonPropertyName("ninja_url")]

    public String? NinjaUrl { get; set; }

    [JsonPropertyName("non_consignable")]
    public Boolean? NonConsignable { get; set; }
    [JsonPropertyName("notes")]

    public String? Notes { get; set; }

    [JsonPropertyName("old_software_version")]

    public String? OldSoftwareVersion { get; set; }

    [JsonPropertyName("onhold_ticket_count")]
    public Int32? OnholdTicketCount { get; set; }
    [JsonPropertyName("open_change_count")]
    public Int32? OpenChangeCount { get; set; }
    [JsonPropertyName("opened_thismonth_count")]
    public Int32? OpenedThismonthCount { get; set; }
    [JsonPropertyName("open_incident_count")]
    public Int32? OpenIncidentCount { get; set; }
    [JsonPropertyName("open_ticket_count")]
    public Int32? OpenTicketCount { get; set; }
    [JsonPropertyName("os_override")]

    public String? OsOverride { get; set; }

    [JsonPropertyName("owning_businessapp")]
    public Int32? OwningBusinessapp { get; set; }
    [JsonPropertyName("owning_businessapp_name")]

    public String? OwningBusinessappName { get; set; }

    [JsonPropertyName("owning_ci")]
    public Int32? OwningCi { get; set; }
    [JsonPropertyName("owning_ci_name")]

    public String? OwningCiName { get; set; }

    [JsonPropertyName("owning_portfolio")]
    public Int32? OwningPortfolio { get; set; }
    [JsonPropertyName("owning_portfolio_name")]

    public String? OwningPortfolioName { get; set; }

    [JsonPropertyName("owning_service")]
    public Int32? OwningService { get; set; }
    [JsonPropertyName("owning_service_name")]

    public String? OwningServiceName { get; set; }

    [JsonPropertyName("parent_asset_names")]

    public String? ParentAssetNames { get; set; }

    [JsonPropertyName("parent_assets")]

    public List<Device_List>? ParentAssets { get; set; }

    [JsonPropertyName("parent_guid")]
    public Guid? ParentGuid { get; set; }
    [JsonPropertyName("parent_id")]
    public Int32? ParentId { get; set; }
    [JsonPropertyName("parent_third_party_id")]
    public Int32? ParentThirdPartyId { get; set; }
    [JsonPropertyName("parent_third_party_ids")]

    public List<String>? ParentThirdPartyIds { get; set; }

    [JsonPropertyName("passportal_client_id")]
    public Int64? PassportalClientId { get; set; }
    [JsonPropertyName("passportal_id")]
    public Int64? PassportalId { get; set; }
    [JsonPropertyName("pdf_attachment_id")]
    public Int32? PdfAttachmentId { get; set; }
    [JsonPropertyName("pdftemplate_id")]
    public Int32? PdftemplateId { get; set; }
    [JsonPropertyName("phone_number")]

    public String? PhoneNumber { get; set; }

    [JsonPropertyName("physicalMemoryInBytes")]

    public String? PhysicalMemoryInBytes { get; set; }

    [JsonPropertyName("pingservice")]
    public Int32? Pingservice { get; set; }
    [JsonPropertyName("primary_asset_chart_json")]

    public String? PrimaryAssetChartJson { get; set; }

    [JsonPropertyName("primary_instance_text")]

    public String? PrimaryInstanceText { get; set; }

    [JsonPropertyName("_print_generate")]
    public Boolean? PrintGenerate { get; set; }
    [JsonPropertyName("printhtml")]

    public String? Printhtml { get; set; }

    [JsonPropertyName("priority_id")]
    public Int32? PriorityId { get; set; }
    [JsonPropertyName("priority_name")]

    public String? PriorityName { get; set; }

    [JsonPropertyName("prometheus_id")]

    public String? PrometheusId { get; set; }

    [JsonPropertyName("prtg_details_id")]
    public Int32? PrtgDetailsId { get; set; }
    [JsonPropertyName("prtg_id")]
    public Int32? PrtgId { get; set; }
    [JsonPropertyName("purchaseorder_id")]
    public Int32? PurchaseorderId { get; set; }
    [JsonPropertyName("purchaseorder_line_id")]
    public Int32? PurchaseorderLineId { get; set; }
    [JsonPropertyName("qualys_id")]

    public String? QualysId { get; set; }

    [JsonPropertyName("qualys_software")]

    public List<QualysHostAssetSoftwareHostAssetSoftware>? QualysSoftware { get; set; }

    [JsonPropertyName("raynet_id")]

    public String? RaynetId { get; set; }

    [JsonPropertyName("related_kb_names")]

    public String? RelatedKbNames { get; set; }

    [JsonPropertyName("related_service_count")]
    public Int32? RelatedServiceCount { get; set; }
    [JsonPropertyName("related_service_name")]

    public String? RelatedServiceName { get; set; }

    [JsonPropertyName("related_service_names")]

    public String? RelatedServiceNames { get; set; }

    [JsonPropertyName("related_services")]

    public String? RelatedServices { get; set; }

    [JsonPropertyName("related_ticket_id")]
    public Int32? RelatedTicketId { get; set; }
    [JsonPropertyName("relationship_id")]
    public Int32? RelationshipId { get; set; }
    [JsonPropertyName("reserved_salesorder_id")]
    public Int32? ReservedSalesorderId { get; set; }
    [JsonPropertyName("reserved_salesorder_line_id")]
    public Int32? ReservedSalesorderLineId { get; set; }
    [JsonPropertyName("runbook_button_id")]
    public Int32? RunbookButtonId { get; set; }
    [JsonPropertyName("scheduled_tickets")]

    public List<StdRequestList>? ScheduledTickets { get; set; }

    [JsonPropertyName("sequence")]
    public Int32? Sequence { get; set; }
    [JsonPropertyName("serialization_user")]
    public Int32? SerializationUser { get; set; }
    [JsonPropertyName("service_count")]
    public Int32? ServiceCount { get; set; }
    [JsonPropertyName("service_guid")]
    public Guid? ServiceGuid { get; set; }
    [JsonPropertyName("service_id")]
    public Int32? ServiceId { get; set; }
    [JsonPropertyName("service_ids")]

    public String? ServiceIds { get; set; }

    [JsonPropertyName("service_name")]

    public String? ServiceName { get; set; }

    [JsonPropertyName("services")]

    public List<ServSiteList>? Services { get; set; }

    [JsonPropertyName("services_hierarchy")]

    public List<ServSite>? ServicesHierarchy { get; set; }

    [JsonPropertyName("sibling_asset_names")]

    public String? SiblingAssetNames { get; set; }

    [JsonPropertyName("sibling_assets")]

    public List<Device_List>? SiblingAssets { get; set; }

    [JsonPropertyName("sibling_id")]
    public Boolean? SiblingId { get; set; }
    [JsonPropertyName("site_external_link_id")]

    public String? SiteExternalLinkId { get; set; }

    [JsonPropertyName("site_guid")]

    public String? SiteGuid { get; set; }

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

    [JsonPropertyName("snow_client_id")]
    public Int32? SnowClientId { get; set; }
    [JsonPropertyName("snow_id")]
    public Int32? SnowId { get; set; }
    [JsonPropertyName("snowUsers")]

    public List<SnowComputerUserAbstract>? SnowUsers { get; set; }

    [JsonPropertyName("software")]

    public List<DeviceApplications>? Software { get; set; }

    [JsonPropertyName("sqlimport_accountsid")]

    public String? SqlimportAccountsid { get; set; }

    [JsonPropertyName("sqlimport_did")]
    public Int32? SqlimportDid { get; set; }
    [JsonPropertyName("sqlimport_id")]
    public Int32? SqlimportId { get; set; }
    [JsonPropertyName("sqlimport_user")]

    public String? SqlimportUser { get; set; }

    [JsonPropertyName("status_id")]
    public Int32? StatusId { get; set; }
    [JsonPropertyName("status_name")]

    public String? StatusName { get; set; }

    [JsonPropertyName("stock_date")]
    public DateTimeOffset? Stock_date { get; set; }
    [JsonPropertyName("stockbin_id")]
    public Int32? StockbinId { get; set; }
    [JsonPropertyName("stockbin_name")]

    public String? StockbinName { get; set; }

    [JsonPropertyName("stockdate")]
    public DateTimeOffset? Stockdate { get; set; }
    [JsonPropertyName("stockdetails")]

    public ItemStock? Stockdetails { get; set; }

    [JsonPropertyName("supplier_contract_id")]
    public Int32? SupplierContractId { get; set; }
    [JsonPropertyName("supplier_contract_ref")]

    public String? SupplierContractRef { get; set; }

    [JsonPropertyName("supplier_expirydate")]
    public DateTimeOffset? SupplierExpirydate { get; set; }
    [JsonPropertyName("supplierheaderid")]
    public Int32? Supplierheaderid { get; set; }
    [JsonPropertyName("supplier_id")]
    public Int32? SupplierId { get; set; }
    [JsonPropertyName("supplier_name")]

    public String? SupplierName { get; set; }

    [JsonPropertyName("supplier_priority_id")]
    public Int32? SupplierPriorityId { get; set; }
    [JsonPropertyName("supplier_priority_name")]

    public String? SupplierPriorityName { get; set; }

    [JsonPropertyName("supplier_purchasedate")]
    public DateTimeOffset? SupplierPurchasedate { get; set; }
    [JsonPropertyName("supplier_reference")]

    public String? SupplierReference { get; set; }

    [JsonPropertyName("supplier_sla_id")]
    public Int32? SupplierSlaId { get; set; }
    [JsonPropertyName("supplier_sla_name")]

    public String? SupplierSlaName { get; set; }

    [JsonPropertyName("syncro_id")]

    public String? Syncro_id { get; set; }

    [JsonPropertyName("syncro_asset_type")]

    public String? SyncroAssetType { get; set; }

    [JsonPropertyName("syncroid")]
    public Int32? Syncroid { get; set; }
    [JsonPropertyName("syncro_url")]

    public String? SyncroUrl { get; set; }

    [JsonPropertyName("tab_config")]

    public List<TabConfig>? TabConfig { get; set; }

    [JsonPropertyName("tanium_id")]

    public String? TaniumId { get; set; }

    [JsonPropertyName("teamviewerid")]

    public String? Teamviewerid { get; set; }

    [JsonPropertyName("teamviewerpassword")]

    public String? Teamviewerpassword { get; set; }

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

    [JsonPropertyName("thirdparty_client_id")]
    public Int32? ThirdpartyClientId { get; set; }
    [JsonPropertyName("third_party_id")]
    public Int32? ThirdPartyId { get; set; }
    [JsonPropertyName("third_party_id_string")]

    public String? ThirdPartyIdString { get; set; }

    [JsonPropertyName("thirdparty_type_id")]
    public Int32? ThirdpartyTypeId { get; set; }
    [JsonPropertyName("total_ticket_count")]
    public Int32? TotalTicketCount { get; set; }
    [JsonPropertyName("use")]

    public String? Use { get; set; }

    [JsonPropertyName("user_count")]
    public Int32? UserCount { get; set; }
    [JsonPropertyName("user_email")]

    public String? UserEmail { get; set; }

    [JsonPropertyName("username")]

    public String? Username { get; set; }

    [JsonPropertyName("user_role_breakdown")]

    public List<DeviceUserCount>? UserRoleBreakdown { get; set; }

    [JsonPropertyName("users")]

    public List<UsersList>? Users { get; set; }

    [JsonPropertyName("_validateonly")]
    public Boolean? Validateonly { get; set; }
    [JsonPropertyName("virima_id")]

    public String? VirimaId { get; set; }

    [JsonPropertyName("vmworkspace_id")]

    public String? VmworkspaceId { get; set; }

    [JsonPropertyName("_warning")]

    public String? Warning { get; set; }

    [JsonPropertyName("warranty_end")]
    public DateTimeOffset? WarrantyEnd { get; set; }
    [JsonPropertyName("warranty_note")]

    public String? WarrantyNote { get; set; }

    [JsonPropertyName("warranty_start")]
    public DateTimeOffset? WarrantyStart { get; set; }
    [JsonPropertyName("workspace_id")]

    public String? WorkspaceId { get; set; }

    [JsonPropertyName("workspace_orgunitpath")]

    public String? WorkspaceOrgunitpath { get; set; }

    [JsonPropertyName("workspace_url")]

    public String? WorkspaceUrl { get; set; }

    [JsonPropertyName("xensam_id")]

    public String? XensamId { get; set; }

    [JsonPropertyName("xtypeunamecanedit")]

    public List<RTPermission>? Xtypeunamecanedit { get; set; }

    [JsonPropertyName("zabbix_id")]

    public String? ZabbixId { get; set; }

    [JsonPropertyName("zabbix_url")]

    public String? ZabbixUrl { get; set; }
}

