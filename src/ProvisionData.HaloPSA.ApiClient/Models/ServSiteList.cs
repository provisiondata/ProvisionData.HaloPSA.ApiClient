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

public partial class ServSiteList

{
    [JsonPropertyName("access_control")]

    public List<AccessControl>? AccessControl { get; set; }

    [JsonPropertyName("access_control_level")]
    public Int32? AccessControlLevel { get; set; }
    [JsonPropertyName("asset_count")]
    public Int32? AssetCount { get; set; }
    [JsonPropertyName("assettype_id")]
    public Int32? AssettypeId { get; set; }
    [JsonPropertyName("assettype_ids")]

    public String? AssettypeIds { get; set; }

    [JsonPropertyName("auto_link")]
    public Boolean? AutoLink { get; set; }
    [JsonPropertyName("business_owner_cab_id")]
    public Int32? BusinessOwnerCabId { get; set; }
    [JsonPropertyName("business_owner_cab_name")]

    public String? BusinessOwnerCabName { get; set; }

    [JsonPropertyName("business_owner_id")]
    public Int32? BusinessOwnerId { get; set; }
    [JsonPropertyName("business_owner_name")]

    public String? BusinessOwnerName { get; set; }

    [JsonPropertyName("checkminutes")]
    public Int32? Checkminutes { get; set; }
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
    [JsonPropertyName("criticality")]
    public Int32? Criticality { get; set; }
    [JsonPropertyName("current_status")]
    public Int32? CurrentStatus { get; set; }

    //[JsonPropertyName("current_statuses")]
    //public List<UntypedNode>? CurrentStatuses { get; set; }

    [JsonPropertyName("device_guid")]
    public Guid? DeviceGuid { get; set; }
    [JsonPropertyName("device_id")]
    public Int32? DeviceId { get; set; }
    [JsonPropertyName("device_name")]

    public String? DeviceName { get; set; }

    [JsonPropertyName("estimated_delivery")]
    public Int32? EstimatedDelivery { get; set; }
    [JsonPropertyName("estimated_delivery_days")]
    public Int32? EstimatedDeliveryDays { get; set; }
    [JsonPropertyName("failalwaysnewrequest")]
    public Boolean? Failalwaysnewrequest { get; set; }
    [JsonPropertyName("failcreaterequest")]
    public Boolean? Failcreaterequest { get; set; }
    [JsonPropertyName("fault_service_type")]
    public Int32? FaultServiceType { get; set; }

    //[JsonPropertyName("future_statuses")]
    //public List<UntypedNode>? FutureStatuses { get; set; }

    [JsonPropertyName("guid")]
    public Guid? Guid { get; set; }
    [JsonPropertyName("icon")]

    public String? Icon { get; set; }

    [JsonPropertyName("id")]
    public Int32? Id { get; set; }
    [JsonPropertyName("incident_template_id")]
    public Int32? IncidentTemplateId { get; set; }
    [JsonPropertyName("incident_tickettype_id")]
    public Int32? IncidentTickettypeId { get; set; }
    [JsonPropertyName("incident_url")]

    public String? IncidentUrl { get; set; }

    [JsonPropertyName("intent")]

    public String? Intent { get; set; }

    [JsonPropertyName("_isimport")]
    public Boolean? Isimport { get; set; }
    [JsonPropertyName("link")]

    public String? Link { get; set; }

    [JsonPropertyName("name")]

    public String? Name { get; set; }

    [JsonPropertyName("newincidenttype")]
    public Int32? Newincidenttype { get; set; }
    [JsonPropertyName("newservicereqtype")]
    public Int32? Newservicereqtype { get; set; }
    [JsonPropertyName("override_site_id")]
    public Int32? OverrideSiteId { get; set; }
    [JsonPropertyName("owningservice")]
    public Int32? Owningservice { get; set; }
    [JsonPropertyName("owningservice_guid")]
    public Guid? OwningserviceGuid { get; set; }
    [JsonPropertyName("owning_service_name")]

    public String? OwningServiceName { get; set; }

    [JsonPropertyName("pricingrange")]
    public Double? Pricingrange { get; set; }
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
    [JsonPropertyName("search_score")]
    public Double? SearchScore { get; set; }
    [JsonPropertyName("sequence")]
    public Int32? Sequence { get; set; }
    [JsonPropertyName("service_category_guid")]
    public Guid? ServiceCategoryGuid { get; set; }
    [JsonPropertyName("service_category_id")]
    public Int32? ServiceCategoryId { get; set; }
    [JsonPropertyName("service_category_name")]

    public String? ServiceCategoryName { get; set; }

    [JsonPropertyName("servicedetailshtml_list")]

    public String? ServicedetailshtmlList { get; set; }

    [JsonPropertyName("serviceshownewreqscreen")]
    public Boolean? Serviceshownewreqscreen { get; set; }
    [JsonPropertyName("service_template_id")]
    public Int32? ServiceTemplateId { get; set; }
    [JsonPropertyName("service_tickettype_id")]
    public Int32? ServiceTickettypeId { get; set; }
    [JsonPropertyName("service_url")]

    public String? ServiceUrl { get; set; }

    [JsonPropertyName("showintechcatalog")]
    public Boolean? Showintechcatalog { get; set; }
    [JsonPropertyName("showinusercatalog")]
    public Boolean? Showinusercatalog { get; set; }
    [JsonPropertyName("status_date")]
    public DateTimeOffset? StatusDate { get; set; }
    [JsonPropertyName("status_end_date")]
    public DateTimeOffset? StatusEndDate { get; set; }
    [JsonPropertyName("status_message_update_internal")]

    public String? StatusMessageUpdateInternal { get; set; }

    [JsonPropertyName("status_message_update_internal_html")]

    public String? StatusMessageUpdateInternalHtml { get; set; }

    [JsonPropertyName("status_message_update_public")]

    public String? StatusMessageUpdatePublic { get; set; }

    [JsonPropertyName("status_message_update_public_html")]

    public String? StatusMessageUpdatePublicHtml { get; set; }

    [JsonPropertyName("status_ticket_end_date")]
    public DateTimeOffset? StatusTicketEndDate { get; set; }
    [JsonPropertyName("status_ticket_id")]
    public Int32? StatusTicketId { get; set; }
    [JsonPropertyName("status_ticket_start_date")]
    public DateTimeOffset? StatusTicketStartDate { get; set; }
    [JsonPropertyName("subscribable")]
    public Boolean? Subscribable { get; set; }
    [JsonPropertyName("subscriber_count")]
    public Int32? SubscriberCount { get; set; }
    [JsonPropertyName("summary")]

    public String? Summary { get; set; }

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

    [JsonPropertyName("trackstatus")]
    public Boolean? Trackstatus { get; set; }
    [JsonPropertyName("use")]

    public String? Use { get; set; }

    [JsonPropertyName("user_subscribed")]
    public Boolean? UserSubscribed { get; set; }
    [JsonPropertyName("using_default_public_message")]
    public Boolean? UsingDefaultPublicMessage { get; set; }
    [JsonPropertyName("workdays")]
    public Int32? Workdays { get; set; }
}

