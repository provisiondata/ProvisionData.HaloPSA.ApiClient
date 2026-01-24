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

public class ItemSupplier
{
    [JsonPropertyName("id")]
    public required Int32 Id { get; set; }

    [JsonPropertyName("guid")]
    public required String Guid { get; set; }

    [JsonPropertyName("item_id")]
    public Int32? ItemId { get; set; }

    [JsonPropertyName("supplier_id")]
    public Int32? SupplierId { get; set; }

    [JsonPropertyName("supplier_name")]
    public required String SupplierName { get; set; }

    [JsonPropertyName("price")]
    public Int32? Price { get; set; }

    [JsonPropertyName("cost")]
    public Int32? Cost { get; set; }

    [JsonPropertyName("client_id")]
    public Int32 ClientId { get; set; } = -1;

    [JsonPropertyName("client_name")]
    public String ClientName { get; set; } = String.Empty;

    [JsonPropertyName("note")]
    public String Note { get; set; } = String.Empty;

    [JsonPropertyName("supplier_sku")]
    public required String SupplierSku { get; set; }
}
