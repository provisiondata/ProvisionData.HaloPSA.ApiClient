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

public class Service
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("guid")]
    public String Guid { get; set; } = String.Empty;
    [JsonPropertyName("intent")]
    public String Intent { get; set; } = String.Empty;
    [JsonPropertyName("name")]
    public String Name { get; set; } = String.Empty;
    [JsonPropertyName("summary")]
    public String Summary { get; set; } = String.Empty;
    [JsonPropertyName("sequence")]
    public Int32 Sequence { get; set; }

    [JsonPropertyName("showinusercatalog")]
    public Boolean Showinusercatalog { get; set; }

    [JsonPropertyName("showintechcatalog")]
    public Boolean Showintechcatalog { get; set; }

    [JsonPropertyName("trackstatus")]
    public Boolean Trackstatus { get; set; }

    [JsonPropertyName("service_category_id")]
    public Int32 ServiceCategoryId { get; set; }

    [JsonPropertyName("service_category_guid")]
    public String ServiceCategoryGuid { get; set; } = String.Empty;
    [JsonPropertyName("service_category_name")]
    public String ServiceCategoryName { get; set; } = String.Empty;
    [JsonPropertyName("business_owner_id")]
    public Int32 BusinessOwnerId { get; set; }

    [JsonPropertyName("business_owner_name")]
    public String BusinessOwnerName { get; set; } = String.Empty;
    [JsonPropertyName("business_owner_cab_id")]
    public Int32 BusinessOwnerCabId { get; set; }

    [JsonPropertyName("business_owner_cab_name")]
    public String BusinessOwnerCabName { get; set; } = String.Empty;
    [JsonPropertyName("technical_owner_id")]
    public Int32 TechnicalOwnerId { get; set; }

    [JsonPropertyName("technical_owner_name")]
    public String TechnicalOwnerName { get; set; } = String.Empty;
    [JsonPropertyName("technical_owner_cab_id")]
    public Int32 TechnicalOwnerCabId { get; set; }

    [JsonPropertyName("technical_owner_cab_name")]
    public String TechnicalOwnerCabName { get; set; } = String.Empty;
    [JsonPropertyName("compliance_owner_id")]
    public Int32 ComplianceOwnerId { get; set; }

    [JsonPropertyName("compliance_owner_name")]
    public String ComplianceOwnerName { get; set; } = String.Empty;
    [JsonPropertyName("compliance_owner_cab_id")]
    public Int32 ComplianceOwnerCabId { get; set; }

    [JsonPropertyName("compliance_owner_cab_name")]
    public String ComplianceOwnerCabName { get; set; } = String.Empty;
    [JsonPropertyName("cost")]
    public Int32 Cost { get; set; }

    [JsonPropertyName("estimated_delivery")]
    public Int32 EstimatedDelivery { get; set; }

    [JsonPropertyName("estimated_delivery_days")]
    public Int32 EstimatedDeliveryDays { get; set; }

    [JsonPropertyName("subscribable")]
    public Boolean Subscribable { get; set; }

    [JsonPropertyName("subscriber_count")]
    public Int32 SubscriberCount { get; set; }

    [JsonPropertyName("asset_count")]
    public Int32 AssetCount { get; set; }

    [JsonPropertyName("assettype_id")]
    public Int32 AssettypeId { get; set; }

    [JsonPropertyName("assettype_ids")]
    public String AssettypeIds { get; set; } = String.Empty;
    [JsonPropertyName("current_status")]
    public Int32 CurrentStatus { get; set; }

    [JsonPropertyName("status_message_update_internal")]
    public String StatusMessageUpdateInternal { get; set; } = String.Empty;
    [JsonPropertyName("status_message_update_public")]
    public String StatusMessageUpdatePublic { get; set; } = String.Empty;
    [JsonPropertyName("using_default_public_message")]
    public Boolean UsingDefaultPublicMessage { get; set; }

    [JsonPropertyName("status_ticket_id")]
    public Int32 StatusTicketId { get; set; }

    [JsonPropertyName("status_date")]
    public DateTime StatusDate { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("service_tickettype_id")]
    public Int32 ServiceTickettypeId { get; set; }

    [JsonPropertyName("serviceshownewreqscreen")]
    public Boolean Serviceshownewreqscreen { get; set; }

    [JsonPropertyName("service_template_id")]
    public Int32 ServiceTemplateId { get; set; }

    [JsonPropertyName("newservicereqtype")]
    public Int32 Newservicereqtype { get; set; }

    [JsonPropertyName("incident_tickettype_id")]
    public Int32 IncidentTickettypeId { get; set; }

    [JsonPropertyName("incident_template_id")]
    public Int32 IncidentTemplateId { get; set; }

    [JsonPropertyName("newincidenttype")]
    public Int32 Newincidenttype { get; set; }

    [JsonPropertyName("relatedworkdayid")]
    public Int32 Relatedworkdayid { get; set; }

    [JsonPropertyName("status_end_date")]
    public DateTime StatusEndDate { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("status_ticket_start_date")]
    public DateTime StatusTicketStartDate { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("status_ticket_end_date")]
    public DateTime StatusTicketEndDate { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("requestdetails_count")]
    public Int32 RequestdetailsCount { get; set; }

    [JsonPropertyName("requestdetail_url")]
    public String RequestdetailUrl { get; set; } = String.Empty;
    [JsonPropertyName("requestdetail_shownewreqscreen")]
    public Boolean RequestdetailShownewreqscreen { get; set; }

    [JsonPropertyName("requestdetail_type")]
    public Int32 RequestdetailType { get; set; }

    [JsonPropertyName("screenafterlogging")]
    public Int32 Screenafterlogging { get; set; }

    [JsonPropertyName("pricingrange")]
    public Int32 Pricingrange { get; set; }

    [JsonPropertyName("override_site_id")]
    public Int32 OverrideSiteId { get; set; }

    [JsonPropertyName("failcreaterequest")]
    public Boolean Failcreaterequest { get; set; }

    [JsonPropertyName("workdays")]
    public Int32 Workdays { get; set; }

    [JsonPropertyName("checkminutes")]
    public Int32 Checkminutes { get; set; }

    [JsonPropertyName("failalwaysnewrequest")]
    public Boolean Failalwaysnewrequest { get; set; }

    [JsonPropertyName("criticality")]
    public Int32 Criticality { get; set; }

    [JsonPropertyName("use")]
    public String Use { get; set; } = String.Empty;
    [JsonPropertyName("icon")]
    public String Icon { get; set; } = String.Empty;
    [JsonPropertyName("relatedworkdayid_name")]
    public String RelatedworkdayidName { get; set; } = String.Empty;
    [JsonPropertyName("relatedworkdayid_content")]
    public String RelatedworkdayidContent { get; set; } = String.Empty;
    [JsonPropertyName("status_message_update_internal_html")]
    public String StatusMessageUpdateInternalHtml { get; set; } = String.Empty;
    [JsonPropertyName("status_message_update_public_html")]
    public String StatusMessageUpdatePublicHtml { get; set; } = String.Empty;
    [JsonPropertyName("future_statuses")]
    public List<FutureStatus> FutureStatuses { get; set; } = [];
    [JsonPropertyName("current_statuses")]
    public List<CurrentStatus> CurrentStatuses { get; set; } = [];
    [JsonPropertyName("service_url")]
    public String ServiceUrl { get; set; } = String.Empty;
    [JsonPropertyName("incident_url")]
    public String IncidentUrl { get; set; } = String.Empty;
    [JsonPropertyName("access_control")]
    public List<AccessControl> AccessControl { get; set; } = [];
    [JsonPropertyName("access_control_level")]
    public Int32 AccessControlLevel { get; set; }

    [JsonPropertyName("_isimport")]
    public Boolean Isimport { get; set; }
}
