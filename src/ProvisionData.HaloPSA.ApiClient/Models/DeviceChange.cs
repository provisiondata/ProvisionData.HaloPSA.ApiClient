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

public partial class DeviceChange

{
    [JsonPropertyName("asset_id")]
    public Int32? AssetId { get; set; }

    [JsonPropertyName("asset_number")]
    public Int32? AssetNumber { get; set; }

    [JsonPropertyName("asset_site")]
    public Int32? AssetSite { get; set; }

    [JsonPropertyName("customfield_id")]
    public Int32? CustomfieldId { get; set; }

    [JsonPropertyName("datetime")]
    public DateTimeOffset? Datetime { get; set; }

    [JsonPropertyName("field_desc")]
    public String? FieldDesc { get; set; }

    [JsonPropertyName("field_id")]
    public Int32? FieldId { get; set; }

    [JsonPropertyName("field_name")]
    public String? FieldName { get; set; }

    [JsonPropertyName("id")]
    public Int64? Id { get; set; }

    [JsonPropertyName("item_id")]
    public Int32? ItemId { get; set; }

    [JsonPropertyName("new_site")]
    public Int32? NewSite { get; set; }

    [JsonPropertyName("new_value")]
    public String? NewValue { get; set; }

    [JsonPropertyName("old_site")]
    public Int32? OldSite { get; set; }

    [JsonPropertyName("old_value")]
    public String? OldValue { get; set; }

    [JsonPropertyName("software_id")]
    public Int32? SoftwareId { get; set; }

    [JsonPropertyName("software_user_id")]
    public Int32? SoftwareUserId { get; set; }

    [JsonPropertyName("software_user_name")]
    public String? SoftwareUserName { get; set; }

    [JsonPropertyName("who")]
    public String? Who { get; set; }

    [JsonPropertyName("who_id")]
    public Int32? WhoId { get; set; }
}

