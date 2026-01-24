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

public class CustomButton
{
    [JsonPropertyName("guid")]
    public String Guid { get; set; } = String.Empty;

    [JsonPropertyName("intent")]
    public String Intent { get; set; } = String.Empty;

    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("usage")]
    public Int32 Usage { get; set; }

    [JsonPropertyName("name")]
    public String Name { get; set; } = String.Empty;

    [JsonPropertyName("label")]
    public String Label { get; set; } = String.Empty;

    [JsonPropertyName("seq")]
    public Int32 Seq { get; set; }

    [JsonPropertyName("icon")]
    public String Icon { get; set; } = String.Empty;

    [JsonPropertyName("url")]
    public String Url { get; set; } = String.Empty;

    [JsonPropertyName("newtab")]
    public Boolean NewTab { get; set; }

    [JsonPropertyName("msid")]
    public Int32 MsId { get; set; }

    [JsonPropertyName("type")]
    public Int32 Type { get; set; }

    [JsonPropertyName("runbook_id")]
    public String RunbookId { get; set; } = String.Empty;

    [JsonPropertyName("runbook_name")]
    public String RunbookName { get; set; } = String.Empty;

    [JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;

    [JsonPropertyName("button_visibility_ac")]
    public Int32 ButtonVisibilityAc { get; set; }

    [JsonPropertyName("restrict_by_asset_status")]
    public Boolean RestrictByAssetStatus { get; set; }

    [JsonPropertyName("button_visibility_statuses")]
    public ButtonVisibilityStatus[] ButtonVisibilityStatuses { get; set; } = [];
}

