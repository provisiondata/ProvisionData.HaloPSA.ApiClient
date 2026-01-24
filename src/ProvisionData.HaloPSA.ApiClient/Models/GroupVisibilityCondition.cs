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

public class GroupVisibilityCondition
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }
    [JsonPropertyName("entity_id")]
    public Int32 EntityId { get; set; }
    [JsonPropertyName("entity_name")]
    public String EntityName { get; set; } = String.Empty;
    [JsonPropertyName("entity_id2")]
    public Int32 EntityId2 { get; set; }
    [JsonPropertyName("entity_guid2")]
    public String EntityGuid2 { get; set; } = String.Empty;
    [JsonPropertyName("entity_id3")]
    public Int32 EntityId3 { get; set; }
    [JsonPropertyName("type")]
    public Int32 Type { get; set; }
    [JsonPropertyName("desc")]
    public String Desc { get; set; } = String.Empty;
    [JsonPropertyName("seq")]
    public Int32 Seq { get; set; }
    [JsonPropertyName("allow_access")]
    public Boolean AllowAccess { get; set; }
    [JsonPropertyName("subscriber_type")]
    public Int32 SubscriberType { get; set; }
    [JsonPropertyName("restrictions")]
    public Restriction[] Restrictions { get; set; } = [];
    [JsonPropertyName("visibility_conditions")]
    public VisibilityCondition[] VisibilityConditions { get; set; } = [];
    [JsonPropertyName("user_access")]
    public UserAccess[] UserAccess { get; set; } = [];
    [JsonPropertyName("subscribers")]
    public Subscriber[] Subscribers { get; set; } = [];
    [JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;
}
