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

public class Criterion
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("invoicedetailquantity_id")]
    public Int32 InvoicedetailquantityId { get; set; }

    [JsonPropertyName("tablename")]
    public String Tablename { get; set; } = String.Empty;

    [JsonPropertyName("fieldname")]
    public String Fieldname { get; set; } = String.Empty;

    [JsonPropertyName("value_type")]
    public String ValueType { get; set; } = String.Empty;

    [JsonPropertyName("value_int")]
    public Int32 ValueInt { get; set; }

    [JsonPropertyName("value_float")]
    public Int32 ValueFloat { get; set; }

    [JsonPropertyName("value_string")]
    public String ValueString { get; set; } = String.Empty;

    [JsonPropertyName("value_datetime")]
    public DateTime ValueDatetime { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("value_display")]
    public String ValueDisplay { get; set; } = String.Empty;

    [JsonPropertyName("type")]
    public Int32 Type { get; set; }

    [JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;
}
