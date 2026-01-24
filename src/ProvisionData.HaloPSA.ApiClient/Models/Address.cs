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

public record Address
{
	[JsonPropertyName("line1")]
	public String Street1 { get; set; } = String.Empty;

	[JsonPropertyName("line2")]
	public String Street2 { get; set; } = String.Empty;

	[JsonPropertyName("line3")]
	public String City { get; set; } = String.Empty;

	[JsonPropertyName("line4")]
	public String Province { get; set; } = String.Empty;

	[JsonPropertyName("postcode")]
	public String PostalCode { get; set; } = String.Empty;

	[JsonPropertyName("primary")]
	public Boolean Primary { get; set; }

	[JsonPropertyName("inactive")]
	public Boolean Inactive { get; set; }

	[JsonPropertyName("date_active")]
	public DateTime DateActive { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("site_id")]
	public Int32 SiteId { get; set; }
}

public record AddressEx : Address
{
	[JsonPropertyName("description")]
	public String Description { get; set; } = String.Empty;

	[JsonPropertyName("note")]
	public String Note { get; set; } = String.Empty;

	[JsonPropertyName("date_inactive")]
	public DateTime DateInactive { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("lat")]
	public Decimal Lat { get; set; }

	[JsonPropertyName("long")]
	public Decimal Long { get; set; }

	[JsonPropertyName("client_name")]
	public String ClientName { get; set; } = String.Empty;

	[JsonPropertyName("site_name")]
	public String SiteName { get; set; } = String.Empty;

	[JsonPropertyName("user_id")]
	public Int32 UserId { get; set; }

	[JsonPropertyName("user_name")]
	public String UserName { get; set; } = String.Empty;

	[JsonPropertyName("user_email")]
	public String UserEmail { get; set; } = String.Empty;

	[JsonPropertyName("_isimport")]
	public Boolean Isimport { get; set; }

	[JsonPropertyName("_warning")]
	public String Warning { get; set; } = String.Empty;
}

