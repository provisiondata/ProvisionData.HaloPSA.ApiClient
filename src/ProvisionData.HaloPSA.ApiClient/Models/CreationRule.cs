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

public class CreationRule
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("parent_template_id")]
    public Int32 ParentTemplateId { get; set; }

    [JsonPropertyName("child_template_id")]
    public Int32 ChildTemplateId { get; set; }

    [JsonPropertyName("usage")]
    public Int32 Usage { get; set; }

    [JsonPropertyName("rule_type")]
    public Int32 RuleType { get; set; }

    [JsonPropertyName("createonchildclose_id")]
    public Int32 CreateonchildcloseId { get; set; }

    [JsonPropertyName("createonchildclose_name")]
    public String CreateonchildcloseName { get; set; } = String.Empty;

    [JsonPropertyName("working_days")]
    public Int32 WorkingDays { get; set; }

    [JsonPropertyName("outcome_id")]
    public Int32 OutcomeId { get; set; }

    [JsonPropertyName("outcome_name")]
    public String OutcomeName { get; set; } = String.Empty;

    [JsonPropertyName("field_id")]
    public Int32 FieldId { get; set; }

    [JsonPropertyName("field_value")]
    public Int32 FieldValue { get; set; }

    [JsonPropertyName("field_value_string")]
    public String FieldValueString { get; set; } = String.Empty;

    [JsonPropertyName("field_contains")]
    public String FieldContains { get; set; } = String.Empty;

    [JsonPropertyName("field_name")]
    public String FieldName { get; set; } = String.Empty;

    [JsonPropertyName("approvalstatus")]
    public Int32 Approvalstatus { get; set; }

    [JsonPropertyName("group_id")]
    public Int32 GroupId { get; set; }

    [JsonPropertyName("optionalservice_id")]
    public Int32 OptionalserviceId { get; set; }

    [JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;
}
