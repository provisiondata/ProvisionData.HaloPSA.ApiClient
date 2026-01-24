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

public partial class Holidays

{
    [JsonPropertyName("agent_id")]
    public Int32? AgentId { get; set; }
    [JsonPropertyName("agent_name")]

    public String? AgentName { get; set; }

    [JsonPropertyName("allday")]
    public Boolean? Allday { get; set; }

    //[JsonPropertyName("appointmentobj")]
    //public UntypedNode? Appointmentobj { get; set; }

    [JsonPropertyName("approvalnote")]

    public String? Approvalnote { get; set; }

    [JsonPropertyName("approval_start")]
    public Boolean? ApprovalStart { get; set; }
    [JsonPropertyName("approval_status")]
    public Int32? ApprovalStatus { get; set; }

    //[JsonPropertyName("change_freeze_clients")]
    //public List<UntypedNode>? ChangeFreezeClients { get; set; }

    [JsonPropertyName("createnextappt")]
    public Boolean? Createnextappt { get; set; }
    [JsonPropertyName("date")]
    public DateTimeOffset? Date { get; set; }
    [JsonPropertyName("date_datetime")]
    public DateTimeOffset? DateDatetime { get; set; }
    [JsonPropertyName("date_only")]
    public DateTimeOffset? DateOnly { get; set; }
    [JsonPropertyName("duration")]
    public Double? Duration { get; set; }
    [JsonPropertyName("enable_change_freeze_per_client")]
    public Boolean? EnableChangeFreezePerClient { get; set; }
    [JsonPropertyName("end_date")]
    public DateTimeOffset? EndDate { get; set; }
    [JsonPropertyName("end_date_only")]
    public DateTimeOffset? EndDateOnly { get; set; }
    [JsonPropertyName("entity")]
    public Int32? Entity { get; set; }
    [JsonPropertyName("entity_id")]
    public Int32? EntityId { get; set; }
    [JsonPropertyName("environment")]
    public Int32? Environment { get; set; }
    [JsonPropertyName("_force")]
    public Boolean? Force { get; set; }
    [JsonPropertyName("holid")]
    public Int32? Holid { get; set; }
    [JsonPropertyName("holiday_type")]
    public Int32? HolidayType { get; set; }
    [JsonPropertyName("id")]
    public Guid? Id { get; set; }
    [JsonPropertyName("isrecurring")]
    public Boolean? Isrecurring { get; set; }
    [JsonPropertyName("name")]

    public String? Name { get; set; }

    [JsonPropertyName("_return_appointment")]
    public Boolean? ReturnAppointment { get; set; }

    [JsonPropertyName("schedule")]
    public Schedule? Schedule { get; set; }

    [JsonPropertyName("schedulehandledtype")]
    public Int32? Schedulehandledtype { get; set; }
    [JsonPropertyName("thirdpartyid")]

    public String? Thirdpartyid { get; set; }

    [JsonPropertyName("_warning")]

    public String? Warning { get; set; }

    [JsonPropertyName("workday_guid")]
    public Guid? WorkdayGuid { get; set; }
    [JsonPropertyName("workday_id")]
    public Int32? WorkdayId { get; set; }
}

