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

public partial class KBEntryList

{
    [JsonPropertyName("agent_view_count")]
    public Int32? AgentViewCount { get; set; }

    [JsonPropertyName("all_version_view_count")]
    public Int32? AllVersionViewCount { get; set; }

    [JsonPropertyName("confluence_url")]
    public String? ConfluenceUrl { get; set; }

    [JsonPropertyName("customfields")]
    public List<CustomField>? CustomFields { get; set; }
    [JsonPropertyName("date_created")]
    public DateTimeOffset? DateCreated { get; set; }

    [JsonPropertyName("date_edited")]
    public DateTimeOffset? DateEdited { get; set; }

    [JsonPropertyName("description")]
    public String? Description { get; set; }

    [JsonPropertyName("description_list")]
    public String? DescriptionList { get; set; }

    [JsonPropertyName("editor_type")]
    public Int32? EditorType { get; set; }

    [JsonPropertyName("faqdseq")]
    public Int32? Faqdseq { get; set; }

    [JsonPropertyName("faqliststr")]
    public String? Faqliststr { get; set; }

    [JsonPropertyName("id")]
    public Int32? Id { get; set; }

    [JsonPropertyName("import_details_id")]
    public Int32? ImportDetailsId { get; set; }

    [JsonPropertyName("_importthirdpartyid")]
    public String? Importthirdpartyid { get; set; }

    [JsonPropertyName("_importtype")]
    public String? Importtype { get; set; }

    [JsonPropertyName("_importtypeid")]
    public Int32? Importtypeid { get; set; }

    [JsonPropertyName("inactive")]
    public Boolean? Inactive { get; set; }

    [JsonPropertyName("_isupdateimport")]
    public Boolean? Isupdateimport { get; set; }

    [JsonPropertyName("kb_tags")]
    public String? KbTags { get; set; }

    [JsonPropertyName("key")]
    public Int32? Key { get; set; }

    [JsonPropertyName("key_copy")]
    public Guid? KeyCopy { get; set; }

    [JsonPropertyName("limit_end_date")]
    public DateTimeOffset? LimitEndDate { get; set; }

    [JsonPropertyName("limit_start_date")]
    public DateTimeOffset? LimitStartDate { get; set; }

    [JsonPropertyName("link")]
    public String? Link { get; set; }

    [JsonPropertyName("name")]
    public String? Name { get; set; }

    [JsonPropertyName("new_external_link")]
    public ExternalLinkList? NewExternalLink { get; set; }

    [JsonPropertyName("next_review_date")]
    public DateTimeOffset? NextReviewDate { get; set; }

    [JsonPropertyName("notuseful_count")]
    public Int32? NotusefulCount { get; set; }

    [JsonPropertyName("resolution_list")]
    public String? ResolutionList { get; set; }

    [JsonPropertyName("search_score")]
    public Double? SearchScore { get; set; }

    [JsonPropertyName("tag_string")]
    public String? TagString { get; set; }

    [JsonPropertyName("ticket_template_id")]
    public Int32? TicketTemplateId { get; set; }

    [JsonPropertyName("type")]
    public Int32? Type { get; set; }

    [JsonPropertyName("use")]
    public String? Use { get; set; }

    [JsonPropertyName("useful_count")]
    public Int32? UsefulCount { get; set; }

    [JsonPropertyName("view_count")]
    public Int32? ViewCount { get; set; }
}

