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
public record CreateRecurringInvoice //: InvoiceBase
{
	[JsonPropertyName("intent")]
	public String Intent { get; set; } = "ADD";

	[JsonPropertyName("name")]
	public required String Name { get; set; }

	[JsonPropertyName("client_id")]
	public required Int32 ClientId { get; set; }

	[JsonPropertyName("client")]
	public required Client Client { get; set; }

	[JsonPropertyName("accountsid")]
	public required String AccountsId { get; set; }

	[JsonPropertyName("thirdpartyinvoicenumber")]
	public required String ThirdPartyInvoiceNumber { get; set; }

	[JsonPropertyName("address")]
	public required Address Address { get; set; }

	/// <summary>
	/// This is the note under PO Number
	/// </summary>
	[JsonPropertyName("notes_1")]
	public String Notes1 { get; set; } = String.Empty;

	[JsonPropertyName("notes_2")]
	public String? Notes2 { get; set; }

	[JsonPropertyName("notes_3")]
	public String? Notes3 { get; set; }

	[JsonPropertyName("posted")]
	public Boolean Posted { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("invoice_date")]
	public DateTime? InvoiceDate { get; set; }

	[JsonPropertyName("paymentterms")]
	public Int32 PaymentTerms { get; set; }

	[JsonPropertyName("lines")]
	public required List<CreateInvoiceLine> Lines { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("schedule_date")]
	public DateTime? ScheduleDate { get; set; }

	[JsonPropertyName("paymentstatus")]
	public Int32 PaymentStatus { get; set; } = -1;

	[JsonPropertyName("reference")]
	public required String Reference { get; set; } = String.Empty;

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("duedate")]
	public DateTime? Duedate { get; set; }

	[JsonPropertyName("is_recurring_invoice")]
	public Boolean IsRecurringInvoice { get; set; } = true;

	[JsonPropertyName("lastcreated")]
	public DateTime? LastCreated { get; set; }

	[JsonPropertyName("nextcreationdate")]
	public required DateTime NextCreationDate { get; set; }

	[JsonPropertyName("period")]
	public required Int32 Period { get; set; }

	[JsonPropertyName("schedule")]
	public required Schedule Schedule { get; set; }

	[JsonPropertyName("create_recurring_invoice")]
	public Boolean CreateRecurring { get; set; } = true;

	[JsonPropertyName("force_creation")]
	public Boolean ForceCreation { get; set; }

	[JsonPropertyName("due_date_int")]
	public Int32 DueDateInt { get; set; }

	[JsonPropertyName("due_date_type")]
	public Int32 DueDateType { get; set; }

	[JsonPropertyName("internal_note")]
	public String InternalNote { get; set; } = String.Empty;

	[JsonPropertyName("period_type")]
	public Int32 PeriodType { get; set; }

	[JsonPropertyName("time")]
	public required DateTime Time { get; set; } = DateTime.Now.Date.AddHours(19);

	[JsonPropertyName("startdate")]
	public required DateTime StartDate { get; set; }

	[JsonPropertyName("enddate")]
	public DateTime? EndDate { get; set; }

	//[JsonPropertyName("period_start_date")]
	//public DateTime PeriodStartDate { get; set; }

	//[JsonPropertyName("period_end_date")]
	//public DateTime PeriodEndDate { get; set; }

	[JsonPropertyName("nextcreationperiod")]
	public required String NextCreationPeriod { get; set; }

	[JsonPropertyName("daysplus")]
	public Int32 Daysplus { get; set; } = 5;

	[JsonPropertyName("invoice_prorata_periods_ahead")]
	public Int32 InvoiceProrataPeriodsAhead { get; set; }

	[JsonPropertyName("invoice_percent_increase")]
	public Decimal InvoicePercentIncrease { get; set; } = Decimal.Zero;

	[JsonPropertyName("minimum_line_description")]
	public String MinimumLineDescription { get; set; } = String.Empty;

	[JsonPropertyName("invoice_display")]
	public String InvoiceDisplay { get; set; } = String.Empty;

	[JsonPropertyName("last_synced")]
	public required DateTime LastSynced { get; set; }

	//[JsonPropertyName("_print_preview")]
	//public Boolean PrintPreview { get; set; }

	//[JsonPropertyName("_print_generate")]
	//public Boolean PrintGenerate { get; set; }

	//[JsonPropertyName("_is_invoice_run")]
	//public Boolean IsInvoiceRun { get; set; }

	//[JsonPropertyName("_billing_cut_off")]
	//public DateTime BillingCutOff { get; set; }

	//[JsonPropertyName("_create_from_areaitems")]
	//public List<CreateFromAreaitem> CreateFromAreaitems { get; set; }

	//[JsonPropertyName("_create_from_contract")]
	//public Int32 CreateFromContract { get; set; }

	//[JsonPropertyName("_validateonly")]
	//public Boolean Validateonly { get; set; }

	//[JsonPropertyName("_sendmassinvoice")]
	//public Boolean Sendmassinvoice { get; set; }

	//[JsonPropertyName("_isimport")]
	//public Boolean IsImport { get; set; } = true;

	//[JsonPropertyName("_importtype")]
	//public String Importtype { get; set; }

	//[JsonPropertyName("_create_credit_note")]
	//public Boolean CreateCreditNote { get; set; }

	[JsonPropertyName("_dont_fire_automations")]
	public Boolean DontFireAutomations { get; set; }

	//[JsonPropertyName("_is_process")]
	//public Boolean IsProcess { get; set; }

	[JsonPropertyName("_is_task_schedule")]
	public Boolean IsTaskSchedule { get; set; } = true;

	//[JsonPropertyName("_forcethirdpartysync")]
	//public Boolean Forcethirdpartysync { get; set; }

	//[JsonPropertyName("_novalidate")]
	//public Boolean Novalidate { get; set; }

	//[JsonPropertyName("_dotaxsync")]
	//public Boolean Dotaxsync { get; set; }
}
