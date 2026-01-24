// Provision Data Systems Inc.
// Copyright (C) 2024 Doug Wilson
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

public class SiteField
{
	[JsonPropertyName("id")]
	public Int32 Id { get; set; }

	[JsonPropertyName("name")]
    public String Name { get; set; } = String.Empty;
	[JsonPropertyName("validate")]
    public String Validate { get; set; } = String.Empty;
	[JsonPropertyName("value")]
    public String Value { get; set; } = String.Empty;
	[JsonPropertyName("display")]
    public String Display { get; set; } = String.Empty;
	[JsonPropertyName("mandatory")]
	public Boolean Mandatory { get; set; }

	[JsonPropertyName("showonactivity")]
	public Boolean Showonactivity { get; set; }

	[JsonPropertyName("lookup")]
	public Int32 Lookup { get; set; }

	[JsonPropertyName("systemuse")]
	public Int32 Systemuse { get; set; }

	[JsonPropertyName("parenttype_id")]
	public Int32 ParenttypeId { get; set; }

	[JsonPropertyName("url")]
    public String Url { get; set; } = String.Empty;
	[JsonPropertyName("mapping_id")]
	public Int32 MappingId { get; set; }

	[JsonPropertyName("access_level")]
	public Int32 AccessLevel { get; set; }

	[JsonPropertyName("typeinfo_id")]
	public Int32 TypeinfoId { get; set; }

	[JsonPropertyName("tab_id")]
	public Int32 TabId { get; set; }

	[JsonPropertyName("tab_name")]
    public String TabName { get; set; } = String.Empty;
	[JsonPropertyName("tab_sequence")]
	public Int32 TabSequence { get; set; }

	[JsonPropertyName("tab_columns")]
	public Int32 TabColumns { get; set; }

	[JsonPropertyName("groupname")]
    public String Groupname { get; set; } = String.Empty;
	[JsonPropertyName("techdetail")]
	public Int32 Techdetail { get; set; }

	[JsonPropertyName("userdetail")]
	public Int32 Userdetail { get; set; }

	[JsonPropertyName("visibility_conditions")]
    public List<VisibilityCondition> VisibilityConditions { get; set; } = [];
}
