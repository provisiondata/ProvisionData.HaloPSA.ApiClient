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



public partial class DeviceApplications

{
	[JsonPropertyName("bundledesc")]

	public String? Bundledesc { get; set; }

	[JsonPropertyName("cost")]
	public Double? Cost { get; set; }
	[JsonPropertyName("count")]
	public Int32? Count { get; set; }
	[JsonPropertyName("did")]
	public Int32? Did { get; set; }
	[JsonPropertyName("expiry_date")]
	public DateTimeOffset? ExpiryDate { get; set; }
	[JsonPropertyName("id")]
	public Int32? Id { get; set; }
	[JsonPropertyName("install_date")]
	public DateTimeOffset? InstallDate { get; set; }
	[JsonPropertyName("lastused")]
	public DateTimeOffset? Lastused { get; set; }
	[JsonPropertyName("licence_id")]
	public Int32? LicenceId { get; set; }
	[JsonPropertyName("licence_name")]

	public String? LicenceName { get; set; }

	[JsonPropertyName("licence_required")]
	public Boolean? LicenceRequired { get; set; }
	[JsonPropertyName("moduleid")]
	public Int32? Moduleid { get; set; }
	[JsonPropertyName("name")]

	public String? Name { get; set; }

	[JsonPropertyName("new_devices")]

	public List<Device>? NewDevices { get; set; }

	[JsonPropertyName("new_users")]
	public List<User>? NewUsers { get; set; }

	[JsonPropertyName("role_id")]
	public Int32? RoleId { get; set; }
	[JsonPropertyName("role_name")]

	public String? RoleName { get; set; }

	[JsonPropertyName("snowid")]

	public String? Snowid { get; set; }

	[JsonPropertyName("user_id")]
	public Int32? UserId { get; set; }
	[JsonPropertyName("version")]

	public String? Version { get; set; }

	[JsonPropertyName("_warning")]

	public String? Warning { get; set; }
}

