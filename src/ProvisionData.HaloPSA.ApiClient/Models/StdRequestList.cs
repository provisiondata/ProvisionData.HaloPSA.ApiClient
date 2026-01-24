// Provision Data Systems Inc.
// Copyright (C) 2024 Doug Wilson
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

public partial class StdRequestList

{
	[JsonPropertyName("approval_id")]
	public Int32? ApprovalId { get; set; }
	[JsonPropertyName("automationtype")]
	public Int32? Automationtype { get; set; }
	[JsonPropertyName("clients")]

	public String? Clients { get; set; }

	[JsonPropertyName("created_ticket_id")]
	public Int32? CreatedTicketId { get; set; }
	[JsonPropertyName("create_locked")]
	public Boolean? CreateLocked { get; set; }

	//[JsonPropertyName("creation_rules")]
	//public List<UntypedNode>? CreationRules { get; set; }

	[JsonPropertyName("disabled")]
	public Boolean? Disabled { get; set; }
	[JsonPropertyName("domain")]

	public String? Domain { get; set; }

	[JsonPropertyName("emailbcc")]

	public String? Emailbcc { get; set; }

	[JsonPropertyName("emailcc")]

	public String? Emailcc { get; set; }

	[JsonPropertyName("emailsubject")]

	public String? Emailsubject { get; set; }

	[JsonPropertyName("emailto")]

	public String? Emailto { get; set; }

	[JsonPropertyName("end_date")]
	public DateTimeOffset? EndDate { get; set; }
	[JsonPropertyName("execution_type")]
	public Int32? ExecutionType { get; set; }
	[JsonPropertyName("group_id")]
	public Int32? GroupId { get; set; }
	[JsonPropertyName("guid")]
	public Guid? Guid { get; set; }
	[JsonPropertyName("id")]
	public Int32? Id { get; set; }
	[JsonPropertyName("intent")]

	public String? Intent { get; set; }

	[JsonPropertyName("lastcreated")]
	public DateTimeOffset? Lastcreated { get; set; }
	[JsonPropertyName("name")]

	public String? Name { get; set; }

	[JsonPropertyName("nextcreationdate")]
	public DateTimeOffset? Nextcreationdate { get; set; }
	[JsonPropertyName("nextcreationdate_after_end")]
	public DateTimeOffset? NextcreationdateAfterEnd { get; set; }
	[JsonPropertyName("one_ticket_id")]
	public Int32? OneTicketId { get; set; }
	[JsonPropertyName("optional_service")]
	public Int32? Optional_service { get; set; }
	[JsonPropertyName("optional_agent_id")]
	public Int32? OptionalAgentId { get; set; }
	[JsonPropertyName("optional_assets")]

	public List<Device_List>? OptionalAssets { get; set; }

	[JsonPropertyName("optional_budgettype_id")]
	public Int32? OptionalBudgettypeId { get; set; }
	[JsonPropertyName("optional_category_1")]

	public String? OptionalCategory1 { get; set; }

	[JsonPropertyName("optional_category_2")]

	public String? OptionalCategory2 { get; set; }

	[JsonPropertyName("optional_category_3")]

	public String? OptionalCategory3 { get; set; }

	[JsonPropertyName("optional_category_4")]

	public String? OptionalCategory4 { get; set; }

	[JsonPropertyName("optional_create_locked")]
	public Boolean? OptionalCreateLocked { get; set; }

	//[JsonPropertyName("optional_customfields")]
	//public List<UntypedNode>? OptionalCustomfields { get; set; }

	[JsonPropertyName("optional_defaultresourcetype")]
	public Int32? OptionalDefaultresourcetype { get; set; }
	[JsonPropertyName("optional_estimate")]
	public Double? OptionalEstimate { get; set; }
	[JsonPropertyName("optional_excludefromsla")]
	public Int32? OptionalExcludefromsla { get; set; }
	[JsonPropertyName("optional_forwardinboundupdates")]
	public Int32? OptionalForwardinboundupdates { get; set; }
	[JsonPropertyName("optional_impact")]
	public Int32? OptionalImpact { get; set; }
	[JsonPropertyName("optional_kb_id")]
	public Int32? OptionalKbId { get; set; }
	[JsonPropertyName("optional_priority_id")]
	public Int32? OptionalPriorityId { get; set; }
	[JsonPropertyName("optionalservice")]
	public Int32? Optionalservice { get; set; }
	[JsonPropertyName("optional_service_details_id")]
	public Int32? OptionalServiceDetailsId { get; set; }
	[JsonPropertyName("optional_showforusers")]
	public Int32? OptionalShowforusers { get; set; }
	[JsonPropertyName("optional_sla_id")]
	public Int32? OptionalSlaId { get; set; }
	[JsonPropertyName("optional_status_id")]
	public Int32? OptionalStatusId { get; set; }
	[JsonPropertyName("optional_team")]

	public String? OptionalTeam { get; set; }

	[JsonPropertyName("optional_tickettype_id")]
	public Int32? OptionalTickettypeId { get; set; }
	[JsonPropertyName("optional_urgency")]
	public Int32? OptionalUrgency { get; set; }
	[JsonPropertyName("optional_workflow_id")]
	public Int32? OptionalWorkflowId { get; set; }
	[JsonPropertyName("period")]
	public Int32? Period { get; set; }
	[JsonPropertyName("reportarea")]
	public Int32? Reportarea { get; set; }
	[JsonPropertyName("reportarea_name")]

	public String? ReportareaName { get; set; }

	[JsonPropertyName("restriction_type")]

	public String? RestrictionType { get; set; }

	[JsonPropertyName("restrictto_agent_id")]
	public Int32? RestricttoAgentId { get; set; }
	[JsonPropertyName("restrictto_agent_name")]

	public String? RestricttoAgentName { get; set; }

	[JsonPropertyName("restrictto_department_guid")]
	public Guid? RestricttoDepartmentGuid { get; set; }
	[JsonPropertyName("restrictto_department_id")]
	public Int32? RestricttoDepartmentId { get; set; }
	[JsonPropertyName("restrictto_department_name")]

	public String? RestricttoDepartmentName { get; set; }

	[JsonPropertyName("restrictto_team_guid")]
	public Guid? RestricttoTeamGuid { get; set; }
	[JsonPropertyName("restrictto_team_id")]
	public Int32? RestricttoTeamId { get; set; }
	[JsonPropertyName("restrictto_team_name")]

	public String? RestricttoTeamName { get; set; }

	[JsonPropertyName("rule_count")]
	public Int32? RuleCount { get; set; }
	[JsonPropertyName("service")]
	public Int32? Service { get; set; }
	[JsonPropertyName("startdate")]
	public DateTimeOffset? Startdate { get; set; }
	[JsonPropertyName("summary")]

	public String? Summary { get; set; }

	[JsonPropertyName("tickettype_guid")]
	public Guid? TickettypeGuid { get; set; }
	[JsonPropertyName("tickettype_id")]
	public Int32? TickettypeId { get; set; }
	[JsonPropertyName("time")]
	public DateTimeOffset? Time { get; set; }

	//[JsonPropertyName("todo_list")]
	//public List<UntypedNode>? TodoList { get; set; }

	[JsonPropertyName("type")]
	public Int32? Type { get; set; }
}

