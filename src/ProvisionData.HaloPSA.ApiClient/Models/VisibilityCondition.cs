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

public class VisibilityCondition
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("tickettype_id")]
    public Int32 TicketTypeId { get; set; }

    [JsonPropertyName("field_id")]
    public Int32 FieldId { get; set; }

    [JsonPropertyName("field_guid")]
    public String FieldGuid { get; set; } = String.Empty;

    [JsonPropertyName("lookup_field_id")]
    public Int32 LookupFieldId { get; set; }

    [JsonPropertyName("lookup_field_guid")]
    public String LookupFieldGuid { get; set; } = String.Empty;

    [JsonPropertyName("lookup_value_id")]
    public Int32 LookupValueId { get; set; }

    [JsonPropertyName("lookup_value")]
    public String LookupValue { get; set; } = String.Empty;

    [JsonPropertyName("field_value")]
    public Int32 FieldValue { get; set; }

    [JsonPropertyName("category_value_name")]
    public String CategoryValueName { get; set; } = String.Empty;

    [JsonPropertyName("dynamic_SQL_field")]
    public Boolean DynamicSqlField { get; set; }

    [JsonPropertyName("value_modified")]
    public Boolean ValueModified { get; set; }

    [JsonPropertyName("conditiontype")]
    public Int32 ConditionType { get; set; }

    [JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;

    [JsonPropertyName("field_usage")]
    public Int32 FieldUsage { get; set; }

    [JsonPropertyName("criteriagroup_id")]
    public Int32 CriteriaGroupId { get; set; }
}
