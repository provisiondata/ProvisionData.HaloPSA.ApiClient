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
// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public class CreateRecurringScheduleResponse
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("guid")]
    public Guid Guid { get; set; }

    [JsonPropertyName("type")]
    public Int32 Type { get; set; }

    [JsonPropertyName("group_id")]
    public Int32 GroupId { get; set; }

    [JsonPropertyName("restriction_type")]
    public String RestrictionType { get; set; } = String.Empty;

    [JsonPropertyName("tickettype_id")]
    public Int32 TickettypeId { get; set; }

    [JsonPropertyName("time")]
    public DateTime Time { get; set; }

    [JsonPropertyName("disabled")]
    public Boolean Disabled { get; set; }

    [JsonPropertyName("lastcreated")]
    public DateTime Lastcreated { get; set; }

    [JsonPropertyName("execution_type")]
    public Int32 ExecutionType { get; set; }

    [JsonPropertyName("startdate")]
    public DateTime Startdate { get; set; }

    [JsonPropertyName("end_date")]
    public DateTime EndDate { get; set; }

    [JsonPropertyName("period")]
    public Int32 Period { get; set; }

    [JsonPropertyName("create_locked")]
    public Boolean CreateLocked { get; set; }

    [JsonPropertyName("one_ticket_id")]
    public Int32 OneTicketId { get; set; }

    [JsonPropertyName("approval_id")]
    public Int32 ApprovalId { get; set; }

    [JsonPropertyName("users_can_use")]
    public Boolean UsersCanUse { get; set; }

    [JsonPropertyName("priority_id")]
    public Int32 PriorityId { get; set; }

    [JsonPropertyName("status_id")]
    public Int32 StatusId { get; set; }

    [JsonPropertyName("workflow_id")]
    public Int32 WorkflowId { get; set; }

    [JsonPropertyName("team")]
    public String Team { get; set; } = String.Empty;

    [JsonPropertyName("agent_id")]
    public Int32 AgentId { get; set; }

    [JsonPropertyName("showforusers")]
    public Boolean Showforusers { get; set; }

    [JsonPropertyName("excludefromsla")]
    public Boolean Excludefromsla { get; set; }

    [JsonPropertyName("defaultresourcetype")]
    public Int32 Defaultresourcetype { get; set; }

    [JsonPropertyName("dom")]
    public Int32 Dom { get; set; }

    [JsonPropertyName("mon")]
    public Int32 Mon { get; set; }

    [JsonPropertyName("tue")]
    public Int32 Tue { get; set; }

    [JsonPropertyName("wed")]
    public Int32 Wed { get; set; }

    [JsonPropertyName("thu")]
    public Int32 Thu { get; set; }

    [JsonPropertyName("fri")]
    public Int32 Fri { get; set; }

    [JsonPropertyName("sat")]
    public Int32 Sat { get; set; }

    [JsonPropertyName("sun")]
    public Int32 Sun { get; set; }

    [JsonPropertyName("year")]
    public Int32 Year { get; set; }

    [JsonPropertyName("daysplus")]
    public Int32 Daysplus { get; set; }

    [JsonPropertyName("every")]
    public Int32 Every { get; set; }

    [JsonPropertyName("impact")]
    public Int32 Impact { get; set; }

    [JsonPropertyName("urgency")]
    public Int32 Urgency { get; set; }

    [JsonPropertyName("repeat")]
    public Int32 Repeat { get; set; }

    [JsonPropertyName("did")]
    public Int32 Did { get; set; }

    [JsonPropertyName("yeargapvalue")]
    public Int32 Yeargapvalue { get; set; }

    [JsonPropertyName("csv")]
    public Boolean Csv { get; set; }

    [JsonPropertyName("json")]
    public Boolean Json { get; set; }

    [JsonPropertyName("prompt")]
    public Boolean Prompt { get; set; }

    [JsonPropertyName("pdf")]
    public Boolean Pdf { get; set; }

    [JsonPropertyName("copied_from_id")]
    public Int32 CopiedFromId { get; set; }

    [JsonPropertyName("create_on_nonworkdays")]
    public Boolean CreateOnNonworkdays { get; set; }

    [JsonPropertyName("invoice_id")]
    public Int32 InvoiceId { get; set; }

    [JsonPropertyName("creationtype")]
    public Int32 Creationtype { get; set; }

    [JsonPropertyName("parentticketid")]
    public Int32 Parentticketid { get; set; }

    [JsonPropertyName("kb_id")]
    public Int32 KbId { get; set; }

    [JsonPropertyName("forwardinboundupdates")]
    public Boolean Forwardinboundupdates { get; set; }

    [JsonPropertyName("emailcclist")]
    public String Emailcclist { get; set; } = String.Empty;

    [JsonPropertyName("_canupdate")]
    public Boolean Canupdate { get; set; }

    [JsonPropertyName("user_id")]
    public Int32 UserId { get; set; }

    [JsonPropertyName("updateparent_status_close")]
    public Int32 UpdateparentStatusClose { get; set; }

    [JsonPropertyName("updateparent_target_create")]
    public Double UpdateparentTargetCreate { get; set; }

    [JsonPropertyName("access_control")]
    public List<AccessControl> AccessControl { get; } = [];
    [JsonPropertyName("access_control_level")]
    public Int32 AccessControlLevel { get; set; }

    [JsonPropertyName("increasecontractnextcalldate")]
    public Int32 Increasecontractnextcalldate { get; set; }

    [JsonPropertyName("showforusers_int")]
    public Int32 ShowforusersInt { get; set; }

    [JsonPropertyName("forwardinboundupdates_int")]
    public Int32 ForwardinboundupdatesInt { get; set; }

    [JsonPropertyName("excludefromsla_int")]
    public Int32 ExcludefromslaInt { get; set; }

    [JsonPropertyName("start_num_days_added")]
    public Int32 StartNumDaysAdded { get; set; }

    [JsonPropertyName("target_num_days_added")]
    public Int32 TargetNumDaysAdded { get; set; }

    [JsonPropertyName("sqltoselectusers")]
    public Boolean Sqltoselectusers { get; set; }

    [JsonPropertyName("service")]
    public Int32 Service { get; set; }
}

