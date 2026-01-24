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

public partial class TabConfig

{
    [JsonPropertyName("display")]
    public Int32? Display { get; set; }
    [JsonPropertyName("entity_id")]
    public Int32? EntityId { get; set; }
    [JsonPropertyName("icon")]

    public String? Icon { get; set; }

    [JsonPropertyName("icon_override")]
    public Boolean? IconOverride { get; set; }
    [JsonPropertyName("id")]
    public Int32? Id { get; set; }
    [JsonPropertyName("new_icon")]

    public String? NewIcon { get; set; }

    [JsonPropertyName("nosidemenu")]
    public Boolean? Nosidemenu { get; set; }
    [JsonPropertyName("open_in_new_tab")]
    public Boolean? OpenInNewTab { get; set; }
    [JsonPropertyName("screenlayout_id")]
    public Int32? ScreenlayoutId { get; set; }
    [JsonPropertyName("sequence")]
    public Int32? Sequence { get; set; }
    [JsonPropertyName("tab_id")]
    public Int32? TabId { get; set; }
    [JsonPropertyName("tab_name")]

    public String? TabName { get; set; }

    [JsonPropertyName("url")]

    public String? Url { get; set; }

    [JsonPropertyName("usage")]
    public Int32? Usage { get; set; }
}

