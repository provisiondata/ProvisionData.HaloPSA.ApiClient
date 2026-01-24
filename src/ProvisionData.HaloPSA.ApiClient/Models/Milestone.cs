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

public class Milestone
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("ticket_id")]
    public Int32 TicketId { get; set; }

    [JsonPropertyName("name")]
    public String Name { get; set; } = String.Empty;

    [JsonPropertyName("sequence")]
    public Int32 Sequence { get; set; }

    [JsonPropertyName("start_date")]
    public DateTime StartDate { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("target_date")]
    public DateTime TargetDate { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("milestone_dependencies")]
    public List<String> MilestoneDependencies { get; set; } = [];

    [JsonPropertyName("dependencies")]
    public List<Dependency> Dependencies { get; set; } = [];

    [JsonPropertyName("tickets")]
    public List<Ticket> Tickets { get; set; } = [];

    [JsonPropertyName("_complete")]
    public Boolean Complete { get; set; }

    [JsonPropertyName("_dateschanged")]
    public Boolean Dateschanged { get; set; }

    [JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;

    [JsonPropertyName("start_days")]
    public Int32 StartDays { get; set; }

    [JsonPropertyName("target_days")]
    public Int32 TargetDays { get; set; }

    [JsonPropertyName("_fromtemplate")]
    public Int32 Fromtemplate { get; set; }

    [JsonPropertyName("milestone_value")]
    public Int32 MilestoneValue { get; set; }

    [JsonPropertyName("processed_date")]
    public DateTime ProcessedDate { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("invoicenumber")]
    public String Invoicenumber { get; set; } = String.Empty;

    [JsonPropertyName("from_template_id")]
    public Int32 FromTemplateId { get; set; }
}
