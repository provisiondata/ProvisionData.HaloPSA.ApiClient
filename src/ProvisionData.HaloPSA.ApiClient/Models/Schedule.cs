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

public class Schedule
{
    [JsonPropertyName("id")]
    public Int32? Id { get; set; }

    [JsonPropertyName("period")]
    public required Int32 Period { get; set; }

    [JsonPropertyName("guid")]
    public String Guid { get; set; } = String.Empty;

    [JsonPropertyName("intent")]
    public String Intent { get; set; } = String.Empty;

    [JsonPropertyName("name")]
    public String Name { get; set; } = String.Empty;

    [JsonPropertyName("type")]
    public Int32? Type { get; set; }

    [JsonPropertyName("domain")]
    public String Domain { get; set; } = String.Empty;

    [JsonPropertyName("group_id")]
    public Int32? GroupId { get; set; }

    [JsonPropertyName("restriction_type")]
    public String RestrictionType { get; set; } = String.Empty;

    [JsonPropertyName("restrictto_department_id")]
    public Int32? RestricttoDepartmentId { get; set; }

    [JsonPropertyName("restrictto_department_name")]
    public String RestricttoDepartmentName { get; set; } = String.Empty;

    [JsonPropertyName("restrictto_team_id")]
    public Int32? RestricttoTeamId { get; set; }

    [JsonPropertyName("restrictto_team_name")]
    public String RestricttoTeamName { get; set; } = String.Empty;

    [JsonPropertyName("restrictto_agent_id")]
    public Int32? RestricttoAgentId { get; set; }

    [JsonPropertyName("restrictto_agent_name")]
    public String RestricttoAgentName { get; set; } = String.Empty;

    [JsonPropertyName("summary")]
    public String Summary { get; set; } = String.Empty;

    [JsonPropertyName("tickettype_id")]
    public Int32? TickettypeId { get; set; }

    [JsonPropertyName("rule_count")]
    public Int32? RuleCount { get; set; }

    [JsonPropertyName("creation_rules")]
    public List<CreationRule> CreationRules { get; set; } = [];

    [JsonPropertyName("todo_list")]
    public List<TodoList> TodoList { get; set; } = [];

    [JsonPropertyName("emailto")]
    public String Emailto { get; set; } = String.Empty;

    [JsonPropertyName("emailcc")]
    public String Emailcc { get; set; } = String.Empty;

    [JsonPropertyName("emailsubject")]
    public String Emailsubject { get; set; } = String.Empty;

    [JsonPropertyName("time")]
    public required DateTime Time { get; set; }

    [JsonPropertyName("disabled")]
    public Boolean? Disabled { get; set; }

    [JsonPropertyName("lastcreated")]
    public DateTime? LastCreated { get; set; }

    [JsonPropertyName("nextcreationdate")]
    public required DateTime NextCreationDate { get; set; }

    [JsonPropertyName("nextcreationperiod")]
    public required String NextCreationPeriod { get; set; }

    [JsonPropertyName("nextcreationdate_after_end")]
    public DateTime? NextcreationdateAfterEnd { get; set; }

    [JsonPropertyName("execution_type")]
    public Int32? ExecutionType { get; set; }

    [JsonPropertyName("startdate")]
    public required DateTime StartDate { get; set; }

    [JsonPropertyName("end_date")]
    public DateTime? EndDate { get; set; }

    [JsonPropertyName("create_locked")]
    public Boolean? CreateLocked { get; set; }

    [JsonPropertyName("one_ticket_id")]
    public Int32? OneTicketId { get; set; }

    [JsonPropertyName("created_ticket_id")]
    public Int32? CreatedTicketId { get; set; }

    [JsonPropertyName("approval_id")]
    public Int32? ApprovalId { get; set; }

    [JsonPropertyName("reportarea")]
    public Int32? Reportarea { get; set; }

    [JsonPropertyName("reportarea_name")]
    public String ReportareaName { get; set; } = String.Empty;

    [JsonPropertyName("users_can_use")]
    public Boolean? UsersCanUse { get; set; }

    [JsonPropertyName("priority_id")]
    public Int32? PriorityId { get; set; }

    [JsonPropertyName("estimate")]
    public Int32? Estimate { get; set; }

    [JsonPropertyName("category_1")]
    public String Category1 { get; set; } = String.Empty;

    [JsonPropertyName("category_2")]
    public String Category2 { get; set; } = String.Empty;

    [JsonPropertyName("category_3")]
    public String Category3 { get; set; } = String.Empty;

    [JsonPropertyName("category_4")]
    public String Category4 { get; set; } = String.Empty;

    [JsonPropertyName("status_id")]
    public Int32? StatusId { get; set; }

    [JsonPropertyName("status_guid")]
    public String StatusGuid { get; set; } = String.Empty;

    [JsonPropertyName("details")]
    public String Details { get; set; } = String.Empty;

    [JsonPropertyName("details_html")]
    public String DetailsHtml { get; set; } = String.Empty;

    [JsonPropertyName("clearance")]
    public String Clearance { get; set; } = String.Empty;

    [JsonPropertyName("workflow_id")]
    public Int32? WorkflowId { get; set; }

    [JsonPropertyName("workflow_guid")]
    public String WorkflowGuid { get; set; } = String.Empty;

    [JsonPropertyName("workflow_name")]
    public String WorkflowName { get; set; } = String.Empty;

    [JsonPropertyName("approval_name")]
    public String ApprovalName { get; set; } = String.Empty;

    [JsonPropertyName("team")]
    public String Team { get; set; } = String.Empty;

    [JsonPropertyName("agent_id")]
    public Int32? AgentId { get; set; }

    [JsonPropertyName("agent_name")]
    public String AgentName { get; set; } = String.Empty;

    [JsonPropertyName("showforusers")]
    public Boolean? Showforusers { get; set; }

    [JsonPropertyName("excludefromsla")]
    public Boolean? Excludefromsla { get; set; }

    [JsonPropertyName("defaultresourcetype")]
    public Int32? Defaultresourcetype { get; set; }

    [JsonPropertyName("defaultresourcetype_name")]
    public String DefaultresourcetypeName { get; set; } = String.Empty;

    [JsonPropertyName("informlevel")]
    public Int32? Informlevel { get; set; }

    [JsonPropertyName("scheduletype")]
    public Int32? Scheduletype { get; set; }

    [JsonPropertyName("dom")]
    public Int32? Dom { get; set; }

    [JsonPropertyName("mon")]
    public Int32? Mon { get; set; }

    [JsonPropertyName("tue")]
    public Int32? Tue { get; set; }

    [JsonPropertyName("wed")]
    public Int32? Wed { get; set; }

    [JsonPropertyName("thu")]
    public Int32? Thu { get; set; }

    [JsonPropertyName("fri")]
    public Int32? Fri { get; set; }

    [JsonPropertyName("sat")]
    public Int32? Sat { get; set; }

    [JsonPropertyName("sun")]
    public Int32? Sun { get; set; }

    [JsonPropertyName("year")]
    public Int32? Year { get; set; }

    [JsonPropertyName("_clearlastrun")]
    public Boolean? Clearlastrun { get; set; }

    [JsonPropertyName("daysplus")]
    public Int32? Daysplus { get; set; }

    [JsonPropertyName("every")]
    public Int32? Every { get; set; }

    [JsonPropertyName("reportid")]
    public Int32? Reportid { get; set; }

    [JsonPropertyName("impact")]
    public Int32? Impact { get; set; }

    [JsonPropertyName("urgency")]
    public Int32? Urgency { get; set; }

    [JsonPropertyName("reportperiod")]
    public Int32? Reportperiod { get; set; }

    [JsonPropertyName("reportsite")]
    public Int32? Reportsite { get; set; }

    [JsonPropertyName("repeat")]
    public Int32? Repeat { get; set; }

    [JsonPropertyName("toplevel")]
    public Int32? Toplevel { get; set; }

    [JsonPropertyName("report_id")]
    public Int32? ReportId { get; set; }

    [JsonPropertyName("emailbody")]
    public String Emailbody { get; set; } = String.Empty;

    [JsonPropertyName("kbid")]
    public Int32? Kbid { get; set; }

    [JsonPropertyName("did")]
    public Int32? Did { get; set; }

    [JsonPropertyName("yeargapvalue")]
    public Int32? Yeargapvalue { get; set; }

    [JsonPropertyName("graph")]
    public Boolean? Graph { get; set; }

    [JsonPropertyName("table")]
    public Boolean? Table { get; set; }

    [JsonPropertyName("csv")]
    public Boolean? Csv { get; set; }

    [JsonPropertyName("json")]
    public Boolean? Json { get; set; }

    [JsonPropertyName("prompt")]
    public Boolean? Prompt { get; set; }

    [JsonPropertyName("promptproceed")]
    public Boolean? Promptproceed { get; set; }

    [JsonPropertyName("pdf")]
    public Boolean? Pdf { get; set; }

    [JsonPropertyName("sendifempty")]
    public Boolean? Sendifempty { get; set; }

    [JsonPropertyName("copied_from_id")]
    public Int32? CopiedFromId { get; set; }

    [JsonPropertyName("customfields")]
    public List<CustomField> Customfields { get; set; } = [];

    [JsonPropertyName("assets")]
    public List<Asset> Assets { get; set; } = [];

    [JsonPropertyName("users")]
    public List<User> Users { get; set; } = [];

    [JsonPropertyName("itil_request_type")]
    public Int32? ItilRequestType { get; set; }

    [JsonPropertyName("create_on_nonworkdays")]
    public Boolean? CreateOnNonworkdays { get; set; }

    [JsonPropertyName("invoice_id")]
    public Int32? InvoiceId { get; set; }

    [JsonPropertyName("webhook_id")]
    public String WebhookId { get; set; } = String.Empty;

    [JsonPropertyName("creationtype")]
    public Int32? Creationtype { get; set; }

    [JsonPropertyName("parentticketid")]
    public Int32? Parentticketid { get; set; }

    [JsonPropertyName("kb_id")]
    public Int32? KbId { get; set; }

    [JsonPropertyName("kb_name")]
    public String KbName { get; set; } = String.Empty;

    [JsonPropertyName("kb_accessible_for_enduser")]
    public Boolean? KbAccessibleForEnduser { get; set; }

    [JsonPropertyName("forwardinboundupdates")]
    public Boolean? Forwardinboundupdates { get; set; }

    [JsonPropertyName("enable_budget_table")]
    public Boolean? EnableBudgetTable { get; set; }

    [JsonPropertyName("budgets")]
    public List<Budget> Budgets { get; set; } = [];

    [JsonPropertyName("budgettype_id")]
    public Int32? BudgettypeId { get; set; }

    [JsonPropertyName("budgettype_name")]
    public String BudgettypeName { get; set; } = String.Empty;

    [JsonPropertyName("emailcclist")]
    public String Emailcclist { get; set; } = String.Empty;

    [JsonPropertyName("services")]
    public List<Service> Services { get; set; } = [];

    [JsonPropertyName("_canupdate")]
    public Boolean? Canupdate { get; set; }

    [JsonPropertyName("user_id")]
    public Int32? UserId { get; set; }

    [JsonPropertyName("user_name")]
    public String UserName { get; set; } = String.Empty;

    [JsonPropertyName("updateparent_status_close")]
    public Int32? UpdateparentStatusClose { get; set; }

    [JsonPropertyName("updateparent_target_create")]
    public Decimal UpdateParentTargetCreate { get; set; }

    [JsonPropertyName("access_control")]
    public List<AccessControl> AccessControl { get; set; } = [];

    [JsonPropertyName("access_control_level")]
    public Int32? AccessControlLevel { get; set; }

    [JsonPropertyName("clone_parent_id")]
    public Int32? CloneParentId { get; set; }

    [JsonPropertyName("increasecontractnextcalldate")]
    public Int32? Increasecontractnextcalldate { get; set; }

    [JsonPropertyName("_queue")]
    public Boolean? Queue { get; set; }

    [JsonPropertyName("_sendnow")]
    public Boolean? Sendnow { get; set; }

    [JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;

    [JsonPropertyName("automationcriteria")]
    public List<Automationcriterion> Automationcriteria { get; set; } = [];

    [JsonPropertyName("isclone")]
    public Boolean? Isclone { get; set; }

    [JsonPropertyName("showforusers_int")]
    public Int32? ShowforusersInt { get; set; }

    [JsonPropertyName("forwardinboundupdates_int")]
    public Int32? ForwardinboundupdatesInt { get; set; }

    [JsonPropertyName("excludefromsla_int")]
    public Int32? ExcludefromslaInt { get; set; }

    [JsonPropertyName("start_num_days_added")]
    public Int32? StartNumDaysAdded { get; set; }

    [JsonPropertyName("target_num_days_added")]
    public Int32? TargetNumDaysAdded { get; set; }

    [JsonPropertyName("milestones")]
    public List<Milestone> Milestones { get; set; } = [];

    [JsonPropertyName("sqltoselectusers")]
    public Boolean? Sqltoselectusers { get; set; }

    [JsonPropertyName("usersqllookup")]
    public String Usersqllookup { get; set; } = String.Empty;

    [JsonPropertyName("notification_id")]
    public Int32? NotificationId { get; set; }

    [JsonPropertyName("additional_agents")]
    public List<AdditionalAgent> AdditionalAgents { get; set; } = [];

    [JsonPropertyName("restrictto_department_guid")]
    public String RestricttoDepartmentGuid { get; set; } = String.Empty;

    [JsonPropertyName("restrictto_team_guid")]
    public String RestricttoTeamGuid { get; set; } = String.Empty;

    [JsonPropertyName("clients")]
    public String Clients { get; set; } = String.Empty;

    [JsonPropertyName("tickettype_guid")]
    public String TickettypeGuid { get; set; } = String.Empty;

    [JsonPropertyName("automationtype")]
    public Int32? Automationtype { get; set; }

    [JsonPropertyName("optionalservice")]
    public Int32? Optionalservice { get; set; }

    [JsonPropertyName("optional_agent_id")]
    public Int32? OptionalAgentId { get; set; }

    [JsonPropertyName("optional_team")]
    public String OptionalTeam { get; set; } = String.Empty;

    [JsonPropertyName("optional_status_id")]
    public Int32? OptionalStatusId { get; set; }

    [JsonPropertyName("optional_tickettype_id")]
    public Int32? OptionalTickettypeId { get; set; }

    [JsonPropertyName("optional_create_locked")]
    public Boolean? OptionalCreateLocked { get; set; }

    [JsonPropertyName("optional_defaultresourcetype")]
    public Int32? OptionalDefaultresourcetype { get; set; }

    [JsonPropertyName("optional_excludefromsla")]
    public Int32? OptionalExcludefromsla { get; set; }

    [JsonPropertyName("optional_customfields")]
    public List<OptionalCustomfield> OptionalCustomfields { get; set; } = [];

    [JsonPropertyName("optional_assets")]
    public List<OptionalAsset> OptionalAssets { get; set; } = [];

    [JsonPropertyName("optional_forwardinboundupdates")]
    public Int32? OptionalForwardinboundupdates { get; set; }

    [JsonPropertyName("optional_showforusers")]
    public Int32? OptionalShowforusers { get; set; }

    [JsonPropertyName("optional_urgency")]
    public Int32? OptionalUrgency { get; set; }

    [JsonPropertyName("optional_impact")]
    public Int32? OptionalImpact { get; set; }

    [JsonPropertyName("optional_workflow_id")]
    public Int32? OptionalWorkflowId { get; set; }

    [JsonPropertyName("optional_estimate")]
    public Int32? OptionalEstimate { get; set; }

    [JsonPropertyName("optional_category_1")]
    public String OptionalCategory1 { get; set; } = String.Empty;

    [JsonPropertyName("optional_category_2")]
    public String OptionalCategory2 { get; set; } = String.Empty;

    [JsonPropertyName("optional_category_3")]
    public String OptionalCategory3 { get; set; } = String.Empty;

    [JsonPropertyName("optional_category_4")]
    public String OptionalCategory4 { get; set; } = String.Empty;

    [JsonPropertyName("optional_priority_id")]
    public Int32? OptionalPriorityId { get; set; }

    [JsonPropertyName("optional_budgettype_id")]
    public Int32? OptionalBudgettypeId { get; set; }

    [JsonPropertyName("optional_kb_id")]
    public Int32? OptionalKbId { get; set; }

    [JsonPropertyName("optional_service")]
    public Int32? OptionalService { get; set; }

    [JsonPropertyName("service")]
    public Int32? Service { get; set; }
}
