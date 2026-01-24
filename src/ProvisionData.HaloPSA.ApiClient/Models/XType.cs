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



public partial class Xtype

{
	[JsonPropertyName("access_control")]

	public List<AccessControl>? AccessControl { get; set; }

	[JsonPropertyName("access_control_level")]
	public Int32? AccessControlLevel { get; set; }
	[JsonPropertyName("accountscode1")]

	public String? Accountscode1 { get; set; }

	[JsonPropertyName("accountscode2")]

	public String? Accountscode2 { get; set; }

	[JsonPropertyName("allowall_custombuttons")]
	public Boolean? AllowallCustombuttons { get; set; }
	[JsonPropertyName("allowall_status")]
	public Boolean? AllowallStatus { get; set; }
	[JsonPropertyName("allow_all_view")]
	public Boolean? AllowAllView { get; set; }
	[JsonPropertyName("allow_asset_maintenance")]
	public Boolean? AllowAssetMaintenance { get; set; }
	[JsonPropertyName("allowed_custombuttons")]

	public List<XTypeButton>? AllowedCustombuttons { get; set; }

	[JsonPropertyName("allowed_status")]

	public List<XTypeStatus>? AllowedStatus { get; set; }

	[JsonPropertyName("asset_details_tab_display")]
	public Int32? AssetDetailsTabDisplay { get; set; }
	[JsonPropertyName("assetgroup_guid")]
	public Guid? AssetgroupGuid { get; set; }
	[JsonPropertyName("assetgroup_id")]
	public Int32? AssetgroupId { get; set; }
	[JsonPropertyName("assetgroup_name")]

	public String? AssetgroupName { get; set; }

	//[JsonPropertyName("booking_sites")]
	//public List<UntypedNode>? BookingSites { get; set; }

	//[JsonPropertyName("bookingtypes")]
	//public List<UntypedNode>? Bookingtypes { get; set; }

	[JsonPropertyName("businessowner_visibility")]
	public Int32? BusinessownerVisibility { get; set; }
	[JsonPropertyName("column_profile_guid")]
	public Guid? ColumnProfileGuid { get; set; }
	[JsonPropertyName("column_profile_id")]
	public Int32? ColumnProfileId { get; set; }
	[JsonPropertyName("columnprofileoverride_name")]

	public String? ColumnprofileoverrideName { get; set; }

	[JsonPropertyName("cost")]
	public Double? Cost { get; set; }
	[JsonPropertyName("criticality_visibility")]
	public Int32? CriticalityVisibility { get; set; }
	[JsonPropertyName("default_device_template")]
	public Int32? DefaultDeviceTemplate { get; set; }
	[JsonPropertyName("defaultdevicetemplate_guid")]
	public Guid? DefaultdevicetemplateGuid { get; set; }
	[JsonPropertyName("default_device_template_name")]

	public String? DefaultDeviceTemplateName { get; set; }

	[JsonPropertyName("default_item")]
	public Int32? DefaultItem { get; set; }
	[JsonPropertyName("default_item_name")]

	public String? DefaultItemName { get; set; }

	[JsonPropertyName("defaultsequence")]
	public Int32? Defaultsequence { get; set; }
	[JsonPropertyName("default_showinusercatalog")]
	public Int32? DefaultShowinusercatalog { get; set; }
	[JsonPropertyName("dependencies_visibility")]
	public Int32? DependenciesVisibility { get; set; }

	//[JsonPropertyName("downstream_relationship_restrictions")]
	//public List<UntypedNode>? DownstreamRelationshipRestrictions { get; set; }

	[JsonPropertyName("enable_lansweeper_user_matching")]
	public Boolean? EnableLansweeperUserMatching { get; set; }
	[JsonPropertyName("enableresourcebooking")]
	public Boolean? Enableresourcebooking { get; set; }

	//[JsonPropertyName("field_list")]
	//public List<UntypedNode>? FieldList { get; set; }

	//[JsonPropertyName("field_restrictions")]
	//public List<UntypedNode>? FieldRestrictions { get; set; }

	//[JsonPropertyName("fields")]
	//public List<UntypedNode>? Fields { get; set; }

	[JsonPropertyName("fiid")]
	public Int32? Fiid { get; set; }
	[JsonPropertyName("fiid_guid")]
	public Guid? FiidGuid { get; set; }
	[JsonPropertyName("finame")]

	public String? Finame { get; set; }

	[JsonPropertyName("fiveyearlycost")]
	public Double? Fiveyearlycost { get; set; }
	[JsonPropertyName("fouryearlycost")]
	public Double? Fouryearlycost { get; set; }
	[JsonPropertyName("guid")]
	public Guid? Guid { get; set; }
	[JsonPropertyName("icon")]

	public String? Icon { get; set; }

	[JsonPropertyName("id")]
	public Int32? Id { get; set; }
	[JsonPropertyName("intent")]

	public String? Intent { get; set; }

	[JsonPropertyName("is_businessapp")]
	public Boolean? IsBusinessapp { get; set; }
	[JsonPropertyName("is_businessapp_instance")]
	public Boolean? IsBusinessappInstance { get; set; }
	[JsonPropertyName("_isimport")]
	public Boolean? Isimport { get; set; }
	[JsonPropertyName("is_portfolio")]
	public Boolean? IsPortfolio { get; set; }
	[JsonPropertyName("is_service")]
	public Boolean? IsService { get; set; }
	[JsonPropertyName("item_code")]

	public String? ItemCode { get; set; }

	[JsonPropertyName("itemno")]
	public Int32? Itemno { get; set; }
	[JsonPropertyName("kaseyaid")]

	public String? Kaseyaid { get; set; }

	[JsonPropertyName("keyfield2_id")]
	public Int32? Keyfield2Id { get; set; }
	[JsonPropertyName("keyfield2_name")]

	public String? Keyfield2Name { get; set; }

	[JsonPropertyName("keyfield3_id")]
	public Int32? Keyfield3Id { get; set; }
	[JsonPropertyName("keyfield3_name")]

	public String? Keyfield3Name { get; set; }

	[JsonPropertyName("keyfield_id")]
	public Int32? KeyfieldId { get; set; }
	[JsonPropertyName("keyfield_name")]

	public String? KeyfieldName { get; set; }

	[JsonPropertyName("licence_visibility")]
	public Int32? LicenceVisibility { get; set; }

	//[JsonPropertyName("linked_asset_defaults")]
	//public List<UntypedNode>? LinkedAssetDefaults { get; set; }

	[JsonPropertyName("linkedcontracttype")]
	public Int32? Linkedcontracttype { get; set; }
	[JsonPropertyName("maintenance_windows")]

	public List<Holidays>? MaintenanceWindows { get; set; }

	[JsonPropertyName("manufacturer")]
	public Int32? Manufacturer { get; set; }
	[JsonPropertyName("memo")]

	public String? Memo { get; set; }

	[JsonPropertyName("monthlycost")]
	public Double? Monthlycost { get; set; }
	[JsonPropertyName("name")]

	public String? Name { get; set; }

	[JsonPropertyName("new_icon")]

	public String? NewIcon { get; set; }

	[JsonPropertyName("newticket_priority")]
	public Int32? NewticketPriority { get; set; }
	[JsonPropertyName("notes_visibility")]
	public Int32? NotesVisibility { get; set; }
	[JsonPropertyName("owner_cab_id")]
	public Int32? OwnerCabId { get; set; }
	[JsonPropertyName("owner_cab_name")]

	public String? OwnerCabName { get; set; }

	[JsonPropertyName("owner_id")]
	public Int32? OwnerId { get; set; }
	[JsonPropertyName("owner_name")]

	public String? OwnerName { get; set; }

	[JsonPropertyName("owningbusinessapp_visibility")]
	public Int32? OwningbusinessappVisibility { get; set; }
	[JsonPropertyName("owningci_visibility")]
	public Int32? OwningciVisibility { get; set; }
	[JsonPropertyName("owningportfolio_visibility")]
	public Int32? OwningportfolioVisibility { get; set; }
	[JsonPropertyName("owning_service")]
	public Int32? OwningService { get; set; }
	[JsonPropertyName("owning_service_name")]

	public String? OwningServiceName { get; set; }

	[JsonPropertyName("owningservice_visibility")]
	public Int32? OwningserviceVisibility { get; set; }
	[JsonPropertyName("primary_instance_type")]
	public Int32? PrimaryInstanceType { get; set; }
	[JsonPropertyName("primary_instance_typename")]

	public String? PrimaryInstanceTypename { get; set; }

	[JsonPropertyName("priority_visibility")]
	public Int32? PriorityVisibility { get; set; }
	[JsonPropertyName("quarterlycost")]
	public Double? Quarterlycost { get; set; }
	[JsonPropertyName("resourcebooking_allow_asset_selection")]
	public Boolean? ResourcebookingAllowAssetSelection { get; set; }
	[JsonPropertyName("resourcebooking_asset_restriction_type")]
	public Int32? ResourcebookingAssetRestrictionType { get; set; }
	[JsonPropertyName("resourcebooking_max_days_advance")]
	public Double? ResourcebookingMaxDaysAdvance { get; set; }
	[JsonPropertyName("resourcebooking_min_hours_advance")]
	public Double? ResourcebookingMinHoursAdvance { get; set; }
	[JsonPropertyName("resourcebooking_site_selection_type")]
	public Int32? ResourcebookingSiteSelectionType { get; set; }
	[JsonPropertyName("resourcebookingtype")]
	public Int32? Resourcebookingtype { get; set; }
	[JsonPropertyName("resourcebooking_workdays_id")]
	public Int32? ResourcebookingWorkdaysId { get; set; }
	[JsonPropertyName("resourcebooking_workdays_name")]

	public String? ResourcebookingWorkdaysName { get; set; }

	[JsonPropertyName("service_category_id")]
	public Int32? ServiceCategoryId { get; set; }
	[JsonPropertyName("service_category_name")]

	public String? ServiceCategoryName { get; set; }

	[JsonPropertyName("services")]

	public List<ServSiteList>? Services { get; set; }

	[JsonPropertyName("services_visibility")]
	public Int32? ServicesVisibility { get; set; }
	[JsonPropertyName("show_to_users")]
	public Boolean? ShowToUsers { get; set; }
	[JsonPropertyName("sixmonthlycost")]
	public Double? Sixmonthlycost { get; set; }
	[JsonPropertyName("sla_visibility")]
	public Int32? SlaVisibility { get; set; }
	[JsonPropertyName("status_visibility")]
	public Int32? StatusVisibility { get; set; }
	[JsonPropertyName("supplier1")]
	public Int32? Supplier1 { get; set; }
	[JsonPropertyName("tab_config")]

	public List<TabConfig>? TabConfig { get; set; }

	[JsonPropertyName("tagprefix")]

	public String? Tagprefix { get; set; }

	[JsonPropertyName("technicalowner_visibility")]
	public Int32? TechnicalownerVisibility { get; set; }
	[JsonPropertyName("threeyearlycost")]
	public Double? Threeyearlycost { get; set; }
	[JsonPropertyName("timeslot_bookingtype")]
	public Int32? TimeslotBookingtype { get; set; }

	//[JsonPropertyName("timeslots")]
	//public List<UntypedNode>? Timeslots { get; set; }

	[JsonPropertyName("twoyearlycost")]
	public Double? Twoyearlycost { get; set; }

	//[JsonPropertyName("upstream_relationship_restrictions")]
	//public List<UntypedNode>? UpstreamRelationshipRestrictions { get; set; }

	[JsonPropertyName("use")]
	public Int32? Use { get; set; }
	[JsonPropertyName("user_visibility")]
	public Int32? UserVisibility { get; set; }
	[JsonPropertyName("useteamviewer")]
	public Boolean? Useteamviewer { get; set; }
	[JsonPropertyName("visibility_level")]
	public Int32? VisibilityLevel { get; set; }
	[JsonPropertyName("_warning")]

	public String? Warning { get; set; }

	[JsonPropertyName("weeklycost")]
	public Double? Weeklycost { get; set; }

	//[JsonPropertyName("xtype_roles")]
	//public List<UntypedNode>? XtypeRoles { get; set; }

	[JsonPropertyName("yearlycost")]
	public Double? Yearlycost { get; set; }

}

