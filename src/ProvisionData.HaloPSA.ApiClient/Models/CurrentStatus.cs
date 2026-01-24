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

public class CurrentStatus
{
    [JsonPropertyName("item1")]
    public Int32 Item1 { get; set; }

    [JsonPropertyName("item2")]
    public String Item2 { get; set; } = String.Empty;

    [JsonPropertyName("item3")]
    public DateTime Item3 { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("item4")]
    public Int32 Item4 { get; set; }

    [JsonPropertyName("item5")]
    public DateTime Item5 { get; set; } = DateTime.UnixEpoch;
}
