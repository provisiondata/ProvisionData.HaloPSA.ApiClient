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

public class AccessControl
{
	[JsonPropertyName("agent_id")]
	public Int32? AgentId { get; set; }
	[JsonPropertyName("department_guid")]
	public Guid? DepartmentGuid { get; set; }
	[JsonPropertyName("department_id")]
	public Int32? DepartmentId { get; set; }
	[JsonPropertyName("entity")]
	public String? Entity { get; set; }
	[JsonPropertyName("entity_id")]
	public Int32? EntityId { get; set; }
	[JsonPropertyName("entity_name")]
	public String? EntityName { get; set; }
	[JsonPropertyName("entity_text_id")]
	public String? EntityTextId { get; set; }
	[JsonPropertyName("id")]
	public Int32? Id { get; set; }
	[JsonPropertyName("level")]
	public Int32? Level { get; set; }
	[JsonPropertyName("name")]
	public String? Name { get; set; }
	[JsonPropertyName("role_id")]
	public Int32? RoleId { get; set; }
	[JsonPropertyName("team_guid")]
	public Guid? TeamGuid { get; set; }
	[JsonPropertyName("team_id")]
	public Int32? TeamId { get; set; }
	[JsonPropertyName("type")]
	public Int32? Type { get; set; }
	[JsonPropertyName("user_id")]
	public Int32? UserId { get; set; }
	[JsonPropertyName("_warning")]
	public String? Warning { get; set; }
}

