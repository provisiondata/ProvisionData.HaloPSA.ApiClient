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

public record RecurringInvoice : InvoiceBase
{
	[JsonPropertyName("disabled")]
	public Boolean Disabled { get; set; }

	[JsonPropertyName("use")]
	public String Use { get; set; } = "invoice";

	[JsonPropertyName("client_name")]
	public String ClientName { get; set; } = String.Empty;

	[JsonPropertyName("site_name")]
	public String SiteName { get; set; } = String.Empty;

	[JsonPropertyName("accountsid")]
	public String Accountsid { get; set; } = String.Empty;

	[JsonPropertyName("salesorder_id")]
	public Int32 SalesorderId { get; set; }

	[JsonPropertyName("percentold")]
	public Decimal Percentold { get; set; }

	[JsonPropertyName("contract_id")]
	public Int32 ContractId { get; set; }

	[JsonPropertyName("contract_ref")]
	public String ContractRef { get; set; } = String.Empty;

	[JsonPropertyName("currency_code")]
	public Int32 CurrencyCode { get; set; }

	[JsonPropertyName("currency_conversion_rate")]
	public Decimal CurrencyConversionRate { get; set; }

	[JsonPropertyName("ticket_id")]
	public Int32 TicketId { get; set; }

	[JsonPropertyName("shipaddress")]
	public Address Shipaddress { get; set; } = new();

	[JsonPropertyName("pdftemplate_id")]
	public Int32 PdftemplateId { get; set; }

	[JsonPropertyName("revenue")]
	public Decimal Revenue { get; set; }

	[JsonPropertyName("tax_total")]
	public Decimal TaxTotal { get; set; }

	[JsonPropertyName("total")]
	public Decimal Total { get; set; }

	[JsonPropertyName("is_recurring_invoice")]
	public Boolean IsRecurringInvoice { get; set; }

	[JsonPropertyName("schedule_id")]
	public Int32 ScheduleId { get; set; }

	[JsonPropertyName("lastcreated")]
	public DateTime LastCreated { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("nextcreationdate")]
	public DateTime NextCreationDate { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("period")]
	public Int32 Period { get; set; }

	[JsonPropertyName("recurring_invoice_id")]
	public Int32 RecurringInvoiceId { get; set; }

	[JsonPropertyName("add_contract_assets")]
	public Int32 AddContractAssets { get; set; }

	[JsonPropertyName("add_labour")]
	public Int32 AddLabour { get; set; }

	[JsonPropertyName("add_project")]
	public Int32 AddProject { get; set; }

	[JsonPropertyName("add_travel")]
	public Int32 AddTravel { get; set; }

	[JsonPropertyName("add_mileage")]
	public Int32 AddMileage { get; set; }

	[JsonPropertyName("add_itemsissued")]
	public Int32 AddItemsissued { get; set; }

	[JsonPropertyName("add_prepay")]
	public Int32 AddPrepay { get; set; }

	[JsonPropertyName("add_salesorder")]
	public Int32 AddSalesorder { get; set; }

	[JsonPropertyName("qboid")]
	public Int32 Qboid { get; set; }

	[JsonPropertyName("billingcategory")]
	public Int32 Billingcategory { get; set; }

	[JsonPropertyName("xero_tenant_id")]
	public String XeroTenantId { get; set; } = String.Empty;

	[JsonPropertyName("xero_branding_theme_id")]
	public String XeroBrandingThemeId { get; set; } = String.Empty;

	[JsonPropertyName("xero_branding_theme_name")]
	public String XeroBrandingThemeName { get; set; } = String.Empty;

	[JsonPropertyName("due_date_int")]
	public Int32 DueDateInt { get; set; }

	[JsonPropertyName("due_date_type")]
	public Int32 DueDateType { get; set; }

	[JsonPropertyName("internal_note")]
	public String InternalNote { get; set; } = String.Empty;

	[JsonPropertyName("kashflow_tenant_id")]
	public Int32 KashflowTenantId { get; set; }

	[JsonPropertyName("kashflow_pdf")]
	public String KashflowPdf { get; set; } = String.Empty;

	[JsonPropertyName("original_client_id")]
	public Int32 OriginalClientId { get; set; }

	[JsonPropertyName("xero_status")]
	public String XeroStatus { get; set; } = String.Empty;

	[JsonPropertyName("snelstart_id")]
	public String SnelstartId { get; set; } = String.Empty;

	[JsonPropertyName("startdate")]
	public DateTime StartDate { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("enddate")]
	public DateTime EndDate { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("date_created")]
	public DateTime DateCreated { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("invoice_prorata_periods_ahead")]
	public Int32 InvoiceProrataPeriodsAhead { get; set; }

	[JsonPropertyName("nextcreationperiod")]
	public String Nextcreationperiod { get; set; } = String.Empty;

	[JsonPropertyName("qbo_company_id")]
	public String QboCompanyId { get; set; } = String.Empty;

	[JsonPropertyName("dbc_id")]
	public String DbcId { get; set; } = String.Empty;

	[JsonPropertyName("dbc_company_id")]
	public String DbcCompanyId { get; set; } = String.Empty;

	[JsonPropertyName("reviewrequired")]
	public Boolean Reviewrequired { get; set; }

	[JsonPropertyName("creditlinkedtoinvoiceid")]
	public Int32 Creditlinkedtoinvoiceid { get; set; }

	[JsonPropertyName("sage_business_cloud_details_id")]
	public Int32 SageBusinessCloudDetailsId { get; set; }

	[JsonPropertyName("sage_business_cloud_id")]
	public String SageBusinessCloudId { get; set; } = String.Empty;

	[JsonPropertyName("exact_id")]
	public String ExactId { get; set; } = String.Empty;

	[JsonPropertyName("exact_division")]
	public Int32 ExactDivision { get; set; }

	[JsonPropertyName("xero_line_tax")]
	public String XeroLineTax { get; set; } = String.Empty;

	[JsonPropertyName("invoice_percent_increase")]
	public Decimal InvoicePercentIncrease { get; set; }

	[JsonPropertyName("schedule_ignore_delete")]
	public Boolean ScheduleIgnoreDelete { get; set; }

	[JsonPropertyName("assigned_agent")]
	public Int32 AssignedAgent { get; set; }

	[JsonPropertyName("approval_status")]
	public Int32 ApprovalStatus { get; set; }

	[JsonPropertyName("approvalagent")]
	public Int32 Approvalagent { get; set; }

	[JsonPropertyName("approvalemailaddress")]
	public String Approvalemailaddress { get; set; } = String.Empty;

	[JsonPropertyName("approvalnote")]
	public String Approvalnote { get; set; } = String.Empty;

	[JsonPropertyName("approvalagentid")]
	public Int32 Approvalagentid { get; set; }

	[JsonPropertyName("approvaldatetime")]
	public DateTime Approvaldatetime { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("take_payment_on_duedate")]
	public Int32 TakePaymentOnDuedate { get; set; }

	[JsonPropertyName("supplier_id")]
	public Int32 SupplierId { get; set; }

	[JsonPropertyName("include_in_autopay")]
	public Boolean IncludeInAutopay { get; set; }

	[JsonPropertyName("twilio_invoice")]
	public Boolean TwilioInvoice { get; set; }

	[JsonPropertyName("invoice_separately")]
	public Boolean InvoiceSeparately { get; set; }

	[JsonPropertyName("minimum_price_active")]
	public Boolean MinimumPriceActive { get; set; }

	[JsonPropertyName("minimum_line_description")]
	public String MinimumLineDescription { get; set; } = String.Empty;

	[JsonPropertyName("minimum_amount")]
	public Decimal MinimumAmount { get; set; }

	[JsonPropertyName("mark_credit_as_used")]
	public Boolean MarkCreditAsUsed { get; set; }

	[JsonPropertyName("invoice_display")]
	public String InvoiceDisplay { get; set; } = String.Empty;

	[JsonPropertyName("schedule")]
	public RecurringInvoiceSchedule Schedule { get; set; } = new();
}
