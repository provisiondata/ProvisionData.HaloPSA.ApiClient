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

public class ExternalLink
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("table_id")]
    public Int32 TableId { get; set; }

    [JsonPropertyName("module_id")]
    public Int32 ModuleId { get; set; }

    [JsonPropertyName("halo_id")]
    public Int32 HaloId { get; set; }

    [JsonPropertyName("third_party_id")]
    public String ThirdPartyId { get; set; } = String.Empty;

    [JsonPropertyName("third_party_desc")]
    public String ThirdPartyDesc { get; set; } = String.Empty;

    [JsonPropertyName("third_party_type")]
    public String ThirdPartyType { get; set; } = String.Empty;

    [JsonPropertyName("third_party_url")]
    public String ThirdPartyUrl { get; set; } = String.Empty;

    [JsonPropertyName("third_party_assigned_to")]
    public String ThirdPartyAssignedTo { get; set; } = String.Empty;

    [JsonPropertyName("third_party_count")]
    public Int32 ThirdPartyCount { get; set; }

    [JsonPropertyName("primary")]
    public Boolean Primary { get; set; }

    [JsonPropertyName("halo_desc")]
    public String HaloDesc { get; set; } = String.Empty;

    [JsonPropertyName("halo_second_id")]
    public Int32 HaloSecondId { get; set; }

    [JsonPropertyName("halo_second_desc")]
    public String HaloSecondDesc { get; set; } = String.Empty;

    [JsonPropertyName("extra_match_field")]
    public String ExtraMatchField { get; set; } = String.Empty;

    [JsonPropertyName("details_id")]
    public Int32 DetailsId { get; set; }

    [JsonPropertyName("third_party_secondary_id")]
    public String ThirdPartySecondaryId { get; set; } = String.Empty;

    [JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;

    [JsonPropertyName("third_party_status")]
    public String ThirdPartyStatus { get; set; } = String.Empty;

    [JsonPropertyName("third_party_priority")]
    public String ThirdPartyPriority { get; set; } = String.Empty;

    [JsonPropertyName("_match")]
    public Boolean Match { get; set; }

    [JsonPropertyName("populate_url")]
    public Boolean PopulateUrl { get; set; }

    [JsonPropertyName("date_created")]
    public DateTime DateCreated { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("date_updated")]
    public DateTime DateUpdated { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("subscription_id")]
    public String SubscriptionId { get; set; } = String.Empty;

    [JsonPropertyName("new_subscription_key")]
    public String NewSubscriptionKey { get; set; } = String.Empty;

    [JsonPropertyName("subscription_expiry")]
    public DateTime SubscriptionExpiry { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("_webhookaction")]
    public Int32 Webhookaction { get; set; }

    [JsonPropertyName("revisions")]
    public Int32 Revisions { get; set; }
}
