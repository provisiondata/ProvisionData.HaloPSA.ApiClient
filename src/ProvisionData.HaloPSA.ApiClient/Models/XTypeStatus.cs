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



public partial class XTypeStatus

{
	[JsonPropertyName("allowafterallstatuses")]
	public Boolean? Allowafterallstatuses { get; set; }

	//[JsonPropertyName("allowedafterstatus")]
	//public List<UntypedNode>? Allowedafterstatus { get; set; }

	[JsonPropertyName("id")]
	public Int32? Id { get; set; }
	[JsonPropertyName("status_id")]
	public Int32? StatusId { get; set; }
	[JsonPropertyName("status_name")]

	public String? StatusName { get; set; }

	[JsonPropertyName("_warning")]

	public String? Warning { get; set; }

	[JsonPropertyName("xtype_id")]
	public Int32? XtypeId { get; set; }
	[JsonPropertyName("xtype_name")]

	public String? XtypeName { get; set; }
}

