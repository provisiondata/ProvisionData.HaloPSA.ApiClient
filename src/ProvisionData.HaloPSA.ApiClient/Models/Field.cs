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

public class Field
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
	public Boolean ShowOnActivity { get; set; }

	[JsonPropertyName("lookup")]
	public Int32 Lookup { get; set; }

	[JsonPropertyName("systemuse")]
	public Int32 SystemUse { get; set; }

	[JsonPropertyName("parenttype_id")]
	public Int32 ParentTypeId { get; set; }

	[JsonPropertyName("url")]
	public String Url { get; set; } = String.Empty;
	[JsonPropertyName("mapping_id")]
	public Int32 MappingId { get; set; }
	[JsonPropertyName("access_level")]
	public Int32 AccessLevel { get; set; }
	[JsonPropertyName("show_on_relationship_edit")]
	public Boolean ShowOnRelationshipEdit { get; set; }
	[JsonPropertyName("typeinfo_id")]
	public Int32 TypeInfoId { get; set; }
	[JsonPropertyName("tab_id")]
	public Int32 TabId { get; set; }
	[JsonPropertyName("tab_name")]
	public String TabName { get; set; } = String.Empty;
	[JsonPropertyName("tab_sequence")]
	public Int32 TabSequence { get; set; }
	[JsonPropertyName("tab_columns")]
	public Int32 TabColumns { get; set; }
	[JsonPropertyName("groupname")]
	public String GroupName { get; set; } = String.Empty;
	[JsonPropertyName("techdetail")]
	public Int32 TechDetail { get; set; }
	[JsonPropertyName("userdetail")]
	public Int32 UserDetail { get; set; }
	[JsonPropertyName("group_visibility_conditions")]
	public GroupVisibilityCondition[] GroupVisibilityConditions { get; set; } = [];
	[JsonPropertyName("hint_type")]
	public Int32 HintType { get; set; }
	[JsonPropertyName("hint")]
	public String Hint { get; set; } = String.Empty;
}
