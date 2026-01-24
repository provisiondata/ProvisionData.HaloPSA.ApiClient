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

public class Restriction
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }
    [JsonPropertyName("criteriagroup_id")]
    public Int32 CriteriaGroupId { get; set; }
    [JsonPropertyName("field_id")]
    public Int32 FieldId { get; set; }
    [JsonPropertyName("type")]
    public Int32 Type { get; set; }
    [JsonPropertyName("value_id")]
    public Int32 ValueId { get; set; }
    [JsonPropertyName("value_name")]
    public String ValueName { get; set; } = String.Empty;
    [JsonPropertyName("fieldname")]
    public String FieldName { get; set; } = String.Empty;
    [JsonPropertyName("value_type")]
    public String ValueType { get; set; } = String.Empty;
    [JsonPropertyName("value_type_id")]
    public Int32 ValueTypeId { get; set; }
    [JsonPropertyName("value_int")]
    public Int32 ValueInt { get; set; }
    [JsonPropertyName("valueint_guid")]
    public String ValueIntGuid { get; set; } = String.Empty;
    [JsonPropertyName("value_string")]
    public String ValueString { get; set; } = String.Empty;
    [JsonPropertyName("value_datetime")]
    public DateTime ValueDateTime { get; set; }
    [JsonPropertyName("value_float")]
    public Int32 ValueFloat { get; set; }
    [JsonPropertyName("value_display")]
    public String ValueDisplay { get; set; } = String.Empty;
    [JsonPropertyName("alt_value_display")]
    public String AltValueDisplay { get; set; } = String.Empty;
    [JsonPropertyName("tablename")]
    public String TableName { get; set; } = String.Empty;
    [JsonPropertyName("timezonestring")]
    public String TimezoneString { get; set; } = String.Empty;
    [JsonPropertyName("match_after_start")]
    public Boolean MatchAfterStart { get; set; }
    [JsonPropertyName("match_after_target")]
    public Boolean MatchAfterTarget { get; set; }
}
