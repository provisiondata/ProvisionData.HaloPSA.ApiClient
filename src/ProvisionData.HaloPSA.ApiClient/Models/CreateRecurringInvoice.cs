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

    [JsonPropertyName("_dont_fire_automations")]
    public Boolean DontFireAutomations { get; set; }

    [JsonPropertyName("_is_task_schedule")]
    public Boolean IsTaskSchedule { get; set; } = true;

 
}
