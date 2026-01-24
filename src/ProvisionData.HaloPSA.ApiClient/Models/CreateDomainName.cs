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

public class CreateDomainName
{
    [JsonPropertyName("site_id")]
    public required Int32 SiteId { get; set; }

    [JsonPropertyName("assettype_id")]
    public required Int32 AssettypeId { get; init; } = 141;
    [JsonPropertyName("inventory_number")]
    public required String InventoryNumber { get; set; }

    [JsonPropertyName("key_field")]
    public String KeyField1 { get; set; } = String.Empty;

    [JsonPropertyName("key_field2")]
    public String KeyField2 { get; set; } = String.Empty;

    [JsonPropertyName("key_field3")]
    public String KeyField3 { get; set; } = String.Empty;
}
