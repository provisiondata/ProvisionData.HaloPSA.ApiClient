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



public partial class FieldHelper

{
	[JsonPropertyName("access_level")]
	public Int32? AccessLevel { get; set; }
	[JsonPropertyName("display")]

	public String? Display { get; set; }

	[JsonPropertyName("groupname")]

	public String? Groupname { get; set; }

	[JsonPropertyName("group_visibility_conditions")]
	public List<GroupVisibilityCondition>? GroupVisibilityConditions { get; set; }

	[JsonPropertyName("hint")]

	public String? Hint { get; set; }

	[JsonPropertyName("hint_type")]
	public Int32? HintType { get; set; }
	[JsonPropertyName("id")]
	public Int32? Id { get; set; }
	[JsonPropertyName("lookup")]
	public Int32? Lookup { get; set; }
	[JsonPropertyName("mandatory")]
	public Boolean? Mandatory { get; set; }
	[JsonPropertyName("mapping_id")]
	public Int32? MappingId { get; set; }
	[JsonPropertyName("name")]

	public String? Name { get; set; }

	[JsonPropertyName("parenttype_id")]
	public Int32? ParenttypeId { get; set; }
	[JsonPropertyName("showonactivity")]
	public Boolean? Showonactivity { get; set; }
	[JsonPropertyName("show_on_relationship_edit")]
	public Boolean? ShowOnRelationshipEdit { get; set; }
	[JsonPropertyName("systemuse")]
	public Int32? Systemuse { get; set; }
	[JsonPropertyName("tab_columns")]
	public Int32? TabColumns { get; set; }
	[JsonPropertyName("tab_id")]
	public Int32? TabId { get; set; }
	[JsonPropertyName("tab_name")]

	public String? TabName { get; set; }

	[JsonPropertyName("tab_sequence")]
	public Int32? TabSequence { get; set; }
	[JsonPropertyName("techdetail")]
	public Int32? Techdetail { get; set; }
	[JsonPropertyName("typeinfo_id")]
	public Int32? TypeinfoId { get; set; }
	[JsonPropertyName("url")]

	public String? Url { get; set; }

	[JsonPropertyName("userdetail")]
	public Int32? Userdetail { get; set; }
	[JsonPropertyName("validate")]

	public String? Validate { get; set; }

	//[JsonPropertyName("value")]
	//public UntypedNode? Value { get; set; }

}

