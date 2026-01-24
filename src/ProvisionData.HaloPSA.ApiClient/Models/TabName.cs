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

public partial class Tabname

{
    [JsonPropertyName("columns")]
    public Int32? Columns { get; set; }

    //[JsonPropertyName("fields")]
    //public List<UntypedNode>? Fields { get; set; }

    [JsonPropertyName("guid")]
    public Guid? Guid { get; set; }
    [JsonPropertyName("icon")]

    public String? Icon { get; set; }

    [JsonPropertyName("id")]
    public Int32? Id { get; set; }
    [JsonPropertyName("intent")]

    public String? Intent { get; set; }

    [JsonPropertyName("linked_dashboard_id")]
    public Int32? LinkedDashboardId { get; set; }
    [JsonPropertyName("module_id")]
    public Int32? ModuleId { get; set; }
    [JsonPropertyName("name")]

    public String? Name { get; set; }

    [JsonPropertyName("new_iframe_secret")]

    public String? NewIframeSecret { get; set; }

    [JsonPropertyName("open_in_new_tab")]
    public Boolean? OpenInNewTab { get; set; }
    [JsonPropertyName("send_secure_url_parameter")]
    public Boolean? SendSecureUrlParameter { get; set; }
    [JsonPropertyName("sequence")]
    public Int32? Sequence { get; set; }
    [JsonPropertyName("tableid")]
    public Int32? Tableid { get; set; }
    [JsonPropertyName("url")]

    public String? Url { get; set; }

    [JsonPropertyName("_warning")]

    public String? Warning { get; set; }
}

