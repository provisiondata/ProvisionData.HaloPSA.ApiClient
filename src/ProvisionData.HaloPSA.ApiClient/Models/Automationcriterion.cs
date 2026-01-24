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

public class Automationcriterion
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("rule_id")]
    public Int32 RuleId { get; set; }

    [JsonPropertyName("autoassign_guid")]
    public String AutoassignGuid { get; set; } = String.Empty;
    [JsonPropertyName("qualification_criteria_id")]
    public Int32 QualificationCriteriaId { get; set; }

    [JsonPropertyName("fieldname")]
    public String Fieldname { get; set; } = String.Empty;
    [JsonPropertyName("value_type")]
    public String ValueType { get; set; } = String.Empty;
    [JsonPropertyName("value_int")]
    public Int32 ValueInt { get; set; }

    [JsonPropertyName("valueint_guid")]
    public String ValueintGuid { get; set; } = String.Empty;
    [JsonPropertyName("value_string")]
    public String ValueString { get; set; } = String.Empty;
    [JsonPropertyName("value_datetime")]
    public DateTime ValueDatetime { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("partialmatch")]
    public Boolean Partialmatch { get; set; }

    [JsonPropertyName("value_float")]
    public Int32 ValueFloat { get; set; }

    [JsonPropertyName("matchseparatedvalues")]
    public Boolean Matchseparatedvalues { get; set; }

    [JsonPropertyName("value_display")]
    public String ValueDisplay { get; set; } = String.Empty;
    [JsonPropertyName("tablename")]
    public String Tablename { get; set; } = String.Empty;
    [JsonPropertyName("type")]
    public Int32 Type { get; set; }

    [JsonPropertyName("flowsubdetails_criteria_id")]
    public Int32 FlowsubdetailsCriteriaId { get; set; }

    [JsonPropertyName("use")]
    public Int32 Use { get; set; }

    [JsonPropertyName("chatprofile_id")]
    public String ChatprofileId { get; set; } = String.Empty;
    [JsonPropertyName("chatprofile_flow_seq")]
    public Int32 ChatprofileFlowSeq { get; set; }

    [JsonPropertyName("timezonestring")]
    public String Timezonestring { get; set; } = String.Empty;
    [JsonPropertyName("match_after_start")]
    public Boolean MatchAfterStart { get; set; }

    [JsonPropertyName("match_after_target")]
    public Boolean MatchAfterTarget { get; set; }

    [JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;
    [JsonPropertyName("stdid")]
    public Int32 Stdid { get; set; }
}
