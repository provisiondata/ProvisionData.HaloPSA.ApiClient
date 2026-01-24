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

public partial class ServSite

{
    [JsonPropertyName("access_control")]

    public List<AccessControl>? AccessControl { get; set; }

    [JsonPropertyName("access_control_level")]
    public Int32? AccessControlLevel { get; set; }
    [JsonPropertyName("allowall_category1")]
    public Boolean? AllowallCategory1 { get; set; }
    [JsonPropertyName("allowall_category2")]
    public Boolean? AllowallCategory2 { get; set; }
    [JsonPropertyName("allowall_category3")]
    public Boolean? AllowallCategory3 { get; set; }
    [JsonPropertyName("allowall_category4")]
    public Boolean? AllowallCategory4 { get; set; }

    //[JsonPropertyName("allowed_category1")]
    //public List<UntypedNode>? AllowedCategory1 { get; set; }

    //[JsonPropertyName("allowed_category2")]
    //public List<UntypedNode>? AllowedCategory2 { get; set; }

    //[JsonPropertyName("allowed_category3")]
    //public List<UntypedNode>? AllowedCategory3 { get; set; }

    //[JsonPropertyName("allowed_category4")]
    //public List<UntypedNode>? AllowedCategory4 { get; set; }

    [JsonPropertyName("allowfollowfault")]
    public Boolean? Allowfollowfault { get; set; }
    [JsonPropertyName("allowincidients")]
    public Boolean? Allowincidients { get; set; }
    [JsonPropertyName("allowoptin")]
    public Boolean? Allowoptin { get; set; }
    [JsonPropertyName("allowservicerequests")]
    public Boolean? Allowservicerequests { get; set; }
    [JsonPropertyName("allowunsubscribe")]
    public Boolean? Allowunsubscribe { get; set; }
    [JsonPropertyName("alsosubscribe")]
    public Int32? Alsosubscribe { get; set; }
    [JsonPropertyName("asset_count")]
    public Int32? AssetCount { get; set; }
    [JsonPropertyName("assets")]

    public List<Device_List>? Assets { get; set; }

    [JsonPropertyName("assettype_id")]
    public Int32? AssettypeId { get; set; }
    [JsonPropertyName("assettype_ids")]

    public String? AssettypeIds { get; set; }

    [JsonPropertyName("assettype_name")]

    public String? AssettypeName { get; set; }

    [JsonPropertyName("autoemail")]
    public Boolean? Autoemail { get; set; }
    [JsonPropertyName("auto_link")]
    public Boolean? AutoLink { get; set; }
    [JsonPropertyName("body")]

    public String? Body { get; set; }

    [JsonPropertyName("business_owner_cab_id")]
    public Int32? BusinessOwnerCabId { get; set; }
    [JsonPropertyName("business_owner_cab_name")]

    public String? BusinessOwnerCabName { get; set; }

    [JsonPropertyName("business_owner_id")]
    public Int32? BusinessOwnerId { get; set; }
    [JsonPropertyName("business_owner_name")]

    public String? BusinessOwnerName { get; set; }

    [JsonPropertyName("cat2")]

    public String? Cat2 { get; set; }

    [JsonPropertyName("cat_phonenumber")]

    public String? CatPhonenumber { get; set; }

    [JsonPropertyName("checkfri")]
    public Boolean? Checkfri { get; set; }
    [JsonPropertyName("checkminutes")]
    public Int32? Checkminutes { get; set; }
    [JsonPropertyName("checkmon")]
    public Boolean? Checkmon { get; set; }
    [JsonPropertyName("checksat")]
    public Boolean? Checksat { get; set; }
    [JsonPropertyName("checksun")]
    public Boolean? Checksun { get; set; }
    [JsonPropertyName("checkthu")]
    public Boolean? Checkthu { get; set; }
    [JsonPropertyName("checktue")]
    public Boolean? Checktue { get; set; }
    [JsonPropertyName("checkwed")]
    public Boolean? Checkwed { get; set; }
    [JsonPropertyName("compliance_owner_cab_id")]
    public Int32? ComplianceOwnerCabId { get; set; }
    [JsonPropertyName("compliance_owner_cab_name")]

    public String? ComplianceOwnerCabName { get; set; }

    [JsonPropertyName("compliance_owner_id")]
    public Int32? ComplianceOwnerId { get; set; }
    [JsonPropertyName("compliance_owner_name")]

    public String? ComplianceOwnerName { get; set; }

    [JsonPropertyName("cost")]
    public Double? Cost { get; set; }
    [JsonPropertyName("create_on_unsubscribe")]
    public Boolean? CreateOnUnsubscribe { get; set; }
    [JsonPropertyName("criticality")]
    public Int32? Criticality { get; set; }
    [JsonPropertyName("current_status")]
    public Int32? CurrentStatus { get; set; }

    //[JsonPropertyName("current_statuses")]
    //public List<UntypedNode>? CurrentStatuses { get; set; }

    [JsonPropertyName("customfields")]

    public List<CustomField>? CustomFields { get; set; }

    [JsonPropertyName("delay_avilability_calc")]
    public Int32? DelayAvilabilityCalc { get; set; }
    [JsonPropertyName("device_child_id")]
    public Int32? DeviceChildId { get; set; }
    [JsonPropertyName("device_count")]
    public Int32? DeviceCount { get; set; }
    [JsonPropertyName("device_guid")]
    public Guid? DeviceGuid { get; set; }
    [JsonPropertyName("device_id")]
    public Int32? DeviceId { get; set; }
    [JsonPropertyName("device_name")]

    public String? DeviceName { get; set; }

    [JsonPropertyName("email_subscriber_count")]
    public Int32? EmailSubscriberCount { get; set; }
    [JsonPropertyName("emailtemplate")]
    public Int32? Emailtemplate { get; set; }
    [JsonPropertyName("enabled")]
    public Boolean? Enabled { get; set; }
    [JsonPropertyName("estimated_delivery")]
    public Int32? EstimatedDelivery { get; set; }
    [JsonPropertyName("estimated_delivery_days")]
    public Int32? EstimatedDeliveryDays { get; set; }
    [JsonPropertyName("failalwaysnewrequest")]
    public Boolean? Failalwaysnewrequest { get; set; }
    [JsonPropertyName("failany")]
    public Boolean? Failany { get; set; }
    [JsonPropertyName("failbody")]

    public String? Failbody { get; set; }

    [JsonPropertyName("failcreaterequest")]
    public Boolean? Failcreaterequest { get; set; }
    [JsonPropertyName("failfromaddr")]

    public String? Failfromaddr { get; set; }

    [JsonPropertyName("failsubject")]

    public String? Failsubject { get; set; }

    [JsonPropertyName("failtoaddr")]

    public String? Failtoaddr { get; set; }

    [JsonPropertyName("fault_service_type")]
    public Int32? FaultServiceType { get; set; }
    [JsonPropertyName("field_id")]
    public Int32? FieldId { get; set; }
    [JsonPropertyName("field_name")]

    public String? FieldName { get; set; }

    [JsonPropertyName("fromaddr")]

    public String? Fromaddr { get; set; }

    //[JsonPropertyName("future_statuses")]
    //public List<UntypedNode>? FutureStatuses { get; set; }

    //[JsonPropertyName("group_subscribers")]
    //public List<UntypedNode>? GroupSubscribers { get; set; }

    //[JsonPropertyName("group_user_access")]
    //public List<UntypedNode>? GroupUserAccess { get; set; }

    [JsonPropertyName("guid")]
    public Guid? Guid { get; set; }

    [JsonPropertyName("icon")]
    public String? Icon { get; set; }

    [JsonPropertyName("id")]
    public Int32? Id { get; set; }
    [JsonPropertyName("incidenthint")]

    public String? Incidenthint { get; set; }

    [JsonPropertyName("incidentlbl")]

    public String? Incidentlbl { get; set; }

    [JsonPropertyName("incidentonly")]
    public Boolean? Incidentonly { get; set; }
    [JsonPropertyName("incident_template_id")]
    public Int32? IncidentTemplateId { get; set; }
    [JsonPropertyName("incident_template_name")]

    public String? IncidentTemplateName { get; set; }

    [JsonPropertyName("incident_tickettype_id")]
    public Int32? IncidentTickettypeId { get; set; }
    [JsonPropertyName("incident_tickettype_name")]

    public String? IncidentTickettypeName { get; set; }

    [JsonPropertyName("incident_url")]

    public String? IncidentUrl { get; set; }

    [JsonPropertyName("intent")]

    public String? Intent { get; set; }

    [JsonPropertyName("_isimport")]
    public Boolean? Isimport { get; set; }
    [JsonPropertyName("is_linked_businessapp")]
    public Boolean? IsLinkedBusinessapp { get; set; }
    [JsonPropertyName("is_linked_service")]
    public Boolean? IsLinkedService { get; set; }
    [JsonPropertyName("isservicedetails")]
    public Boolean? Isservicedetails { get; set; }
    [JsonPropertyName("kbs")]

    public List<KBEntryList>? Kbs { get; set; }

    [JsonPropertyName("link")]

    public String? Link { get; set; }

    //[JsonPropertyName("linked_services")]
    //public List<UntypedNode>? LinkedServices { get; set; }

    [JsonPropertyName("max")]
    public Int32? Max { get; set; }
    [JsonPropertyName("min")]
    public Int32? Min { get; set; }
    [JsonPropertyName("name")]

    public String? Name { get; set; }

    [JsonPropertyName("new_icon")]

    public String? NewIcon { get; set; }

    [JsonPropertyName("newincidenttype")]
    public Int32? Newincidenttype { get; set; }
    [JsonPropertyName("newservicereqtype")]
    public Int32? Newservicereqtype { get; set; }
    [JsonPropertyName("note")]

    public String? Note { get; set; }

    [JsonPropertyName("okany")]
    public Boolean? Okany { get; set; }
    [JsonPropertyName("okbody")]

    public String? Okbody { get; set; }

    [JsonPropertyName("okfromaddr")]

    public String? Okfromaddr { get; set; }

    [JsonPropertyName("oksubject")]

    public String? Oksubject { get; set; }

    [JsonPropertyName("oktoaddr")]

    public String? Oktoaddr { get; set; }

    [JsonPropertyName("open_incident_count")]
    public Int32? OpenIncidentCount { get; set; }
    [JsonPropertyName("open_servicerequest_count")]
    public Int32? OpenServicerequestCount { get; set; }

    //[JsonPropertyName("optional_services")]
    //public List<UntypedNode>? OptionalServices { get; set; }

    [JsonPropertyName("override")]
    public Int32? Override { get; set; }
    [JsonPropertyName("override_site_id")]
    public Int32? OverrideSiteId { get; set; }
    [JsonPropertyName("override_site_name")]

    public String? OverrideSiteName { get; set; }

    [JsonPropertyName("owningservice")]
    public Int32? Owningservice { get; set; }
    [JsonPropertyName("owningservice_guid")]
    public Guid? OwningserviceGuid { get; set; }
    [JsonPropertyName("owning_service_name")]

    public String? OwningServiceName { get; set; }

    [JsonPropertyName("param1")]

    public String? Param1 { get; set; }

    [JsonPropertyName("param2")]

    public String? Param2 { get; set; }

    [JsonPropertyName("param3")]

    public String? Param3 { get; set; }

    [JsonPropertyName("photopath")]

    public String? Photopath { get; set; }

    [JsonPropertyName("pop3serverid")]
    public Int32? Pop3serverid { get; set; }
    [JsonPropertyName("pop3serverid_name")]

    public String? Pop3serveridName { get; set; }

    [JsonPropertyName("preview_service_email")]
    public Boolean? PreviewServiceEmail { get; set; }
    [JsonPropertyName("preview_when_logging")]
    public Int32? PreviewWhenLogging { get; set; }
    [JsonPropertyName("pricingrange")]
    public Double? Pricingrange { get; set; }
    [JsonPropertyName("recent_incident_count")]
    public Int32? RecentIncidentCount { get; set; }
    [JsonPropertyName("recent_servicerequest_count")]
    public Int32? RecentServicerequestCount { get; set; }
    [JsonPropertyName("relatedworkdayid")]
    public Int32? Relatedworkdayid { get; set; }
    [JsonPropertyName("relatedworkdayid_content")]

    public String? RelatedworkdayidContent { get; set; }

    [JsonPropertyName("relatedworkdayid_name")]

    public String? RelatedworkdayidName { get; set; }

    [JsonPropertyName("requestdetails_count")]
    public Int32? RequestdetailsCount { get; set; }
    [JsonPropertyName("requestdetail_shownewreqscreen")]
    public Boolean? RequestdetailShownewreqscreen { get; set; }
    [JsonPropertyName("requestdetails_id")]
    public Int32? RequestdetailsId { get; set; }
    [JsonPropertyName("requestdetail_type")]
    public Int32? RequestdetailType { get; set; }
    [JsonPropertyName("requestdetail_url")]

    public String? RequestdetailUrl { get; set; }

    [JsonPropertyName("screenafterlogging")]
    public Int32? Screenafterlogging { get; set; }
    [JsonPropertyName("search_index_sync_batches")]
    public Int32? SearchIndexSyncBatches { get; set; }
    [JsonPropertyName("search_index_sync_timestamp")]
    public DateTimeOffset? SearchIndexSyncTimestamp { get; set; }
    [JsonPropertyName("search_score")]
    public Double? SearchScore { get; set; }
    [JsonPropertyName("sendemailtype")]
    public Int32? Sendemailtype { get; set; }
    [JsonPropertyName("send_service_email")]
    public Boolean? SendServiceEmail { get; set; }
    [JsonPropertyName("seq")]
    public Int32? Seq { get; set; }
    [JsonPropertyName("sequence")]
    public Int32? Sequence { get; set; }
    [JsonPropertyName("service_category_guid")]
    public Guid? ServiceCategoryGuid { get; set; }
    [JsonPropertyName("service_category_id")]
    public Int32? ServiceCategoryId { get; set; }

    //[JsonPropertyName("service_category_mappings")]
    //public List<UntypedNode>? ServiceCategoryMappings { get; set; }

    [JsonPropertyName("service_category_name")]

    public String? ServiceCategoryName { get; set; }

    [JsonPropertyName("servicedetailshtml")]

    public String? Servicedetailshtml { get; set; }

    [JsonPropertyName("servicedetailshtml_list")]

    public String? ServicedetailshtmlList { get; set; }

    [JsonPropertyName("service_email_from")]
    public Int32? ServiceEmailFrom { get; set; }
    [JsonPropertyName("service_email_html")]

    public String? ServiceEmailHtml { get; set; }

    [JsonPropertyName("service_email_subject")]

    public String? ServiceEmailSubject { get; set; }

    [JsonPropertyName("servicekind")]
    public Int32? Servicekind { get; set; }

    //[JsonPropertyName("service_request_details")]
    //public List<UntypedNode>? ServiceRequestDetails { get; set; }

    [JsonPropertyName("servicerequesthint")]

    public String? Servicerequesthint { get; set; }

    [JsonPropertyName("servicerequestlbl")]

    public String? Servicerequestlbl { get; set; }

    [JsonPropertyName("serviceshownewreqscreen")]
    public Boolean? Serviceshownewreqscreen { get; set; }
    [JsonPropertyName("service_template_id")]
    public Int32? ServiceTemplateId { get; set; }
    [JsonPropertyName("service_template_name")]

    public String? ServiceTemplateName { get; set; }

    [JsonPropertyName("service_tickettype_id")]
    public Int32? ServiceTickettypeId { get; set; }
    [JsonPropertyName("service_tickettype_name")]

    public String? ServiceTickettypeName { get; set; }

    [JsonPropertyName("service_url")]

    public String? ServiceUrl { get; set; }

    [JsonPropertyName("show_in_favourites")]
    public Int32? ShowInFavourites { get; set; }
    [JsonPropertyName("showinrelatedservices")]
    public Boolean? Showinrelatedservices { get; set; }
    [JsonPropertyName("showintechcatalog")]
    public Boolean? Showintechcatalog { get; set; }
    [JsonPropertyName("showinusercatalog")]
    public Boolean? Showinusercatalog { get; set; }
    [JsonPropertyName("showonmyservicespage")]
    public Boolean? Showonmyservicespage { get; set; }
    [JsonPropertyName("smsmessage")]

    public String? Smsmessage { get; set; }

    [JsonPropertyName("status_date")]
    public DateTimeOffset? StatusDate { get; set; }
    [JsonPropertyName("status_end_date")]
    public DateTimeOffset? StatusEndDate { get; set; }

    //[JsonPropertyName("status_history")]
    //public List<UntypedNode>? StatusHistory { get; set; }

    [JsonPropertyName("statushistoryportal")]
    public Boolean? Statushistoryportal { get; set; }
    [JsonPropertyName("status_message_update_internal")]

    public String? StatusMessageUpdateInternal { get; set; }

    [JsonPropertyName("status_message_update_internal_html")]

    public String? StatusMessageUpdateInternalHtml { get; set; }

    [JsonPropertyName("status_message_update_public")]

    public String? StatusMessageUpdatePublic { get; set; }

    [JsonPropertyName("status_message_update_public_html")]

    public String? StatusMessageUpdatePublicHtml { get; set; }

    [JsonPropertyName("status_subscribedtoupdates")]
    public Boolean? StatusSubscribedtoupdates { get; set; }
    [JsonPropertyName("status_ticket_end_date")]
    public DateTimeOffset? StatusTicketEndDate { get; set; }
    [JsonPropertyName("status_ticket_id")]
    public Int32? StatusTicketId { get; set; }
    [JsonPropertyName("status_ticket_start_date")]
    public DateTimeOffset? StatusTicketStartDate { get; set; }
    [JsonPropertyName("subject")]

    public String? Subject { get; set; }

    [JsonPropertyName("subscribable")]
    public Boolean? Subscribable { get; set; }
    [JsonPropertyName("subscriber_count")]
    public Int32? SubscriberCount { get; set; }

    //[JsonPropertyName("subscribers")]
    //public List<UntypedNode>? Subscribers { get; set; }

    [JsonPropertyName("summary")]

    public String? Summary { get; set; }

    //[JsonPropertyName("tags")]
    //public List<UntypedNode>? Tags { get; set; }

    [JsonPropertyName("tag_string")]

    public String? TagString { get; set; }

    [JsonPropertyName("technical_owner_cab_id")]
    public Int32? TechnicalOwnerCabId { get; set; }
    [JsonPropertyName("technical_owner_cab_name")]

    public String? TechnicalOwnerCabName { get; set; }

    [JsonPropertyName("technical_owner_id")]
    public Int32? TechnicalOwnerId { get; set; }
    [JsonPropertyName("technical_owner_name")]

    public String? TechnicalOwnerName { get; set; }

    [JsonPropertyName("template_name")]

    public String? TemplateName { get; set; }

    [JsonPropertyName("tickettype_name")]

    public String? TickettypeName { get; set; }

    [JsonPropertyName("toaddr")]

    public String? Toaddr { get; set; }

    [JsonPropertyName("track_availability")]
    public Boolean? TrackAvailability { get; set; }
    [JsonPropertyName("tracking_period")]
    public Int32? TrackingPeriod { get; set; }
    [JsonPropertyName("tracking_target")]
    public Double? TrackingTarget { get; set; }
    [JsonPropertyName("trackstatus")]
    public Boolean? Trackstatus { get; set; }

    //[JsonPropertyName("translations")]
    //public List<UntypedNode>? Translations { get; set; }

    [JsonPropertyName("unsubcount")]
    public Int32? Unsubcount { get; set; }
    [JsonPropertyName("unsubscribe_all")]
    public Boolean? UnsubscribeAll { get; set; }
    [JsonPropertyName("unsubscribe_template_id")]
    public Int32? UnsubscribeTemplateId { get; set; }
    [JsonPropertyName("unsubscribe_ticketortemplate")]
    public Int32? UnsubscribeTicketortemplate { get; set; }
    [JsonPropertyName("unsubscribe_tickettype_id")]
    public Int32? UnsubscribeTickettypeId { get; set; }
    [JsonPropertyName("update_status")]
    public Boolean? UpdateStatus { get; set; }
    [JsonPropertyName("url")]

    public String? Url { get; set; }

    [JsonPropertyName("use")]

    public String? Use { get; set; }

    //[JsonPropertyName("user")]
    //public UntypedNode? User { get; set; }

    //[JsonPropertyName("user_access")]
    //public List<UntypedNode>? UserAccess { get; set; }

    [JsonPropertyName("user_canunsubscribe")]
    public Boolean? UserCanunsubscribe { get; set; }
    [JsonPropertyName("userlevel")]
    public Int32? Userlevel { get; set; }
    [JsonPropertyName("user_subscribed")]
    public Boolean? UserSubscribed { get; set; }
    [JsonPropertyName("using_default_public_message")]
    public Boolean? UsingDefaultPublicMessage { get; set; }
    [JsonPropertyName("_warning")]

    public String? Warning { get; set; }

    [JsonPropertyName("wdid")]
    public Int32? Wdid { get; set; }
    [JsonPropertyName("workdays")]
    public Int32? Workdays { get; set; }
    [JsonPropertyName("workdays_name")]

    public String? WorkdaysName { get; set; }
}

