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

public class Subscriber
{
	[JsonPropertyName("id")]
	public Int32 Id { get; set; }
	[JsonPropertyName("criteriagroup_id")]
	public Int32 CriteriaGroupId { get; set; }
	[JsonPropertyName("service_name")]
	public String ServiceName { get; set; } = String.Empty;
	[JsonPropertyName("type")]
	public String Type { get; set; } = String.Empty;
	[JsonPropertyName("data_id")]
	public Int32 DataId { get; set; }
	[JsonPropertyName("data_name")]
	public String DataName { get; set; } = String.Empty;
	[JsonPropertyName("emailupdates")]
	public Boolean EmailUpdates { get; set; }
	[JsonPropertyName("subscriber_type")]
	public Int32 SubscriberType { get; set; }
	[JsonPropertyName("_warning")]
	public String Warning { get; set; } = String.Empty;
}
