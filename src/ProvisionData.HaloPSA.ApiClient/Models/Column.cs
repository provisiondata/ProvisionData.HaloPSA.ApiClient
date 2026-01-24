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

public class Column
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("columns_id")]
    public Int32 ColumnsId { get; set; }

    [JsonPropertyName("column_seq")]
    public Int32 ColumnSeq { get; set; }

    [JsonPropertyName("column_name")]
    public String ColumnName { get; set; } = String.Empty;

    [JsonPropertyName("width")]
    public Int32 Width { get; set; }

    [JsonPropertyName("order_seq")]
    public Int32 OrderSeq { get; set; }

    [JsonPropertyName("order_desc")]
    public Boolean OrderDesc { get; set; }

    [JsonPropertyName("column_title_override")]
    public String ColumnTitleOverride { get; set; } = String.Empty;

    [JsonPropertyName("groupbystatus")]
    public Int32 GroupByStatus { get; set; }

    [JsonPropertyName("columns_guid")]
    public String ColumnsGuid { get; set; } = String.Empty;
}
