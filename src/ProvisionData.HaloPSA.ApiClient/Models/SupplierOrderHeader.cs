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

public partial class SupplierOrderHeader

{
    [JsonPropertyName("accounts_ref")]
    public String? AccountsRef { get; set; }

    [JsonPropertyName("approvalagent")]
    public Int32? Approvalagent { get; set; }

    [JsonPropertyName("approvalagentid")]
    public Int32? Approvalagentid { get; set; }

    [JsonPropertyName("approvaldatetime")]
    public DateTimeOffset? Approvaldatetime { get; set; }

    [JsonPropertyName("approvalemailaddress")]
    public String? Approvalemailaddress { get; set; }

    [JsonPropertyName("approvalnote")]
    public String? Approvalnote { get; set; }

    [JsonPropertyName("approval_process_id")]
    public Int32? ApprovalProcessId { get; set; }

    [JsonPropertyName("approval_start")]
    public Boolean? ApprovalStart { get; set; }

    [JsonPropertyName("approval_status")]
    public Int32? ApprovalStatus { get; set; }

    [JsonPropertyName("assigned_agent")]
    public Int32? AssignedAgent { get; set; }

    [JsonPropertyName("assigned_agent_name")]
    public String? AssignedAgentName { get; set; }

    [JsonPropertyName("attachment_id")]
    public Int32? AttachmentId { get; set; }

    [JsonPropertyName("auth_by")]
    public String? AuthBy { get; set; }

    [JsonPropertyName("avalara_details_id")]
    public Int32? AvalaraDetailsId { get; set; }

    [JsonPropertyName("avalara_details_name")]
    public String? AvalaraDetailsName { get; set; }

    [JsonPropertyName("carriage_desc")]
    public String? CarriageDesc { get; set; }

    [JsonPropertyName("carriage_price")]
    public Double? CarriagePrice { get; set; }

    [JsonPropertyName("change_seq")]
    public Int32? ChangeSeq { get; set; }

    [JsonPropertyName("client_id")]
    public Int32? ClientId { get; set; }

    [JsonPropertyName("client_name")]
    public String? ClientName { get; set; }

    [JsonPropertyName("client_toplevel_name")]
    public String? ClientToplevelName { get; set; }

    [JsonPropertyName("cost_centre_id")]
    public Int32? CostCentreId { get; set; }

    [JsonPropertyName("cost_centre_name")]
    public String? CostCentreName { get; set; }

    [JsonPropertyName("createdbyagentname")]
    public String? Createdbyagentname { get; set; }

    [JsonPropertyName("_create_invoice")]
    public Boolean? CreateInvoice { get; set; }

    [JsonPropertyName("_create_invoice_amount")]
    public Double? CreateInvoiceAmount { get; set; }

    [JsonPropertyName("_create_invoice_invoice_date")]
    public DateTimeOffset? CreateInvoiceInvoiceDate { get; set; }

    [JsonPropertyName("_create_invoice_line_description")]
    public String? CreateInvoiceLineDescription { get; set; }

    [JsonPropertyName("_create_invoice_method")]
    public Int32? CreateInvoiceMethod { get; set; }

    [JsonPropertyName("_create_invoice_percentage")]
    public Double? CreateInvoicePercentage { get; set; }

    [JsonPropertyName("_create_invoice_qty")]
    public Double? CreateInvoiceQty { get; set; }

    [JsonPropertyName("_create_invoice_reference")]
    public String? CreateInvoiceReference { get; set; }

    [JsonPropertyName("currency")]
    public String? Currency { get; set; }

    [JsonPropertyName("currency_code")]
    public Int32? CurrencyCode { get; set; }

    [JsonPropertyName("currency_code_name")]
    public String? CurrencyCodeName { get; set; }

    [JsonPropertyName("currency_conversion_rate")]
    public Double? CurrencyConversionRate { get; set; }

    [JsonPropertyName("custombuttons")]
    public List<CustomButton>? CustomButtons { get; set; }
    [JsonPropertyName("customfields")]
    public List<CustomField>? CustomFields { get; set; }
    [JsonPropertyName("date")]
    public DateTimeOffset? Date { get; set; }

    [JsonPropertyName("date_published")]
    public DateTimeOffset? DatePublished { get; set; }

    [JsonPropertyName("datesent")]
    public DateTimeOffset? Datesent { get; set; }

    [JsonPropertyName("dbc_company_id")]
    public String? DbcCompanyId { get; set; }

    [JsonPropertyName("deladdress1")]
    public String? Deladdress1 { get; set; }

    [JsonPropertyName("deladdress2")]
    public String? Deladdress2 { get; set; }

    [JsonPropertyName("deladdress3")]
    public String? Deladdress3 { get; set; }

    [JsonPropertyName("deladdress4")]
    public String? Deladdress4 { get; set; }

    [JsonPropertyName("deladdress5")]
    public String? Deladdress5 { get; set; }

    [JsonPropertyName("deliver_to_so_address")]
    public Boolean? DeliverToSoAddress { get; set; }

    [JsonPropertyName("deliver_to_ticket_address")]
    public Boolean? DeliverToTicketAddress { get; set; }

    [JsonPropertyName("deliver_to_us")]
    public Boolean? DeliverToUs { get; set; }

    [JsonPropertyName("delivery_backup")]
    public Int32? DeliveryBackup { get; set; }

    [JsonPropertyName("_dodistributorsync")]
    public Boolean? Dodistributorsync { get; set; }

    [JsonPropertyName("_dont_fire_automations")]
    public Boolean? DontFireAutomations { get; set; }

    [JsonPropertyName("_dotaxsync")]
    public Boolean? Dotaxsync { get; set; }

    [JsonPropertyName("duedate")]
    public DateTimeOffset? Duedate { get; set; }

    [JsonPropertyName("est_delivery_date")]
    public DateTimeOffset? EstDeliveryDate { get; set; }

    [JsonPropertyName("external_links")]
    public List<ExternalLinkList>? ExternalLinks { get; set; }
    [JsonPropertyName("extratabs")]
    public List<Tabname>? Extratabs { get; set; }
    [JsonPropertyName("_forcethirdpartysync")]
    public Boolean? Forcethirdpartysync { get; set; }

    [JsonPropertyName("goodsin_status")]
    public Int32? GoodsinStatus { get; set; }

    [JsonPropertyName("id")]
    public Int32? Id { get; set; }

    [JsonPropertyName("ignore_change_seq")]
    public Boolean? IgnoreChangeSeq { get; set; }

    [JsonPropertyName("import_details_id")]
    public Int32? ImportDetailsId { get; set; }

    [JsonPropertyName("_importthirdpartyid")]
    public String? Importthirdpartyid { get; set; }

    [JsonPropertyName("_importtype")]
    public String? Importtype { get; set; }

    [JsonPropertyName("_importtypeid")]
    public Int32? Importtypeid { get; set; }

    [JsonPropertyName("intacct_class")]
    public String? IntacctClass { get; set; }

    [JsonPropertyName("intacct_class_name")]
    public String? IntacctClassName { get; set; }

    [JsonPropertyName("intacct_save_location")]
    public String? IntacctSaveLocation { get; set; }

    [JsonPropertyName("invoice_count")]
    public Int32? InvoiceCount { get; set; }

    [JsonPropertyName("_isbatch")]
    public Boolean? Isbatch { get; set; }

    [JsonPropertyName("_iscopy")]
    public Boolean? Iscopy { get; set; }

    [JsonPropertyName("is_po_screen")]
    public Boolean? IsPoScreen { get; set; }

    [JsonPropertyName("_isupdateimport")]
    public Boolean? Isupdateimport { get; set; }

    [JsonPropertyName("last_change_agent")]
    public Int32? LastChangeAgent { get; set; }

    [JsonPropertyName("last_change_seq")]
    public Int32? LastChangeSeq { get; set; }

    [JsonPropertyName("last_synced")]
    public DateTimeOffset? LastSynced { get; set; }

    [JsonPropertyName("last_update_time")]
    public DateTimeOffset? LastUpdateTime { get; set; }

    [JsonPropertyName("new_approvalprocess_agent_id")]
    public Int32? NewApprovalprocessAgentId { get; set; }

    [JsonPropertyName("new_approvalprocess_cab_id")]
    public Int32? NewApprovalprocessCabId { get; set; }

    [JsonPropertyName("new_approvalprocess_email")]
    public String? NewApprovalprocessEmail { get; set; }

    [JsonPropertyName("new_approvalprocess_role_id")]
    public Int32? NewApprovalprocessRoleId { get; set; }

    [JsonPropertyName("new_approvalprocess_user_id")]
    public Int32? NewApprovalprocessUserId { get; set; }

    [JsonPropertyName("new_approvalprocess_users")]
    public List<UsersList>? NewApprovalprocessUsers { get; set; }
    [JsonPropertyName("new_external_link")]
    public ExternalLinkList? NewExternalLink { get; set; }

    [JsonPropertyName("note")]
    public String? Note { get; set; }

    [JsonPropertyName("note_count")]
    public Int32? NoteCount { get; set; }

    [JsonPropertyName("_novalidate")]
    public Boolean? Novalidate { get; set; }

    [JsonPropertyName("originaddress1")]
    public String? Originaddress1 { get; set; }

    [JsonPropertyName("originaddress2")]
    public String? Originaddress2 { get; set; }

    [JsonPropertyName("originaddress3")]
    public String? Originaddress3 { get; set; }

    [JsonPropertyName("originaddress4")]
    public String? Originaddress4 { get; set; }

    [JsonPropertyName("originaddress5")]
    public String? Originaddress5 { get; set; }

    [JsonPropertyName("pdf_attachment_id")]
    public Int32? PdfAttachmentId { get; set; }

    [JsonPropertyName("pdftemplate_id")]
    public Int32? PdftemplateId { get; set; }

    [JsonPropertyName("pdftemplate_name")]
    public String? PdftemplateName { get; set; }

    [JsonPropertyName("percentage_invoiced")]
    public Double? PercentageInvoiced { get; set; }

    [JsonPropertyName("po_ref")]
    public String? PoRef { get; set; }

    [JsonPropertyName("price")]
    public Double? Price { get; set; }

    [JsonPropertyName("_print_generate")]
    public Boolean? PrintGenerate { get; set; }

    [JsonPropertyName("printhtml")]
    public String? Printhtml { get; set; }

    [JsonPropertyName("_print_preview")]
    public Boolean? PrintPreview { get; set; }

    [JsonPropertyName("_purchasing_run")]
    public Boolean? PurchasingRun { get; set; }

    [JsonPropertyName("qbo_company_id")]
    public String? QboCompanyId { get; set; }

    [JsonPropertyName("qbo_id")]
    public Int32? QboId { get; set; }

    [JsonPropertyName("receipt_confirmation_date")]
    public DateTimeOffset? ReceiptConfirmationDate { get; set; }

    [JsonPropertyName("receipt_confirmed")]
    public Boolean? ReceiptConfirmed { get; set; }

    [JsonPropertyName("requires_approval")]
    public Boolean? RequiresApproval { get; set; }

    [JsonPropertyName("_return_invoice")]
    public Boolean? ReturnInvoice { get; set; }

    [JsonPropertyName("revenue")]
    public Double? Revenue { get; set; }

    [JsonPropertyName("runbook_button_id")]
    public Int32? RunbookButtonId { get; set; }

    [JsonPropertyName("salesorder_id")]
    public Int32? SalesorderId { get; set; }

    [JsonPropertyName("site_id")]
    public Int32? SiteId { get; set; }

    [JsonPropertyName("site_name")]
    public String? SiteName { get; set; }

    [JsonPropertyName("so_assets")]
    public List<DeviceList>? SoAssets { get; set; }
    [JsonPropertyName("status")]
    public Int32? Status { get; set; }

    [JsonPropertyName("supplier_id")]
    public Int32? SupplierId { get; set; }

    [JsonPropertyName("supplier_name")]
    public String? SupplierName { get; set; }

    [JsonPropertyName("suppliers_order_reference")]
    public String? SuppliersOrderReference { get; set; }

    [JsonPropertyName("tax_total")]
    public Double? TaxTotal { get; set; }

    [JsonPropertyName("third_party_id")]
    public String? ThirdPartyId { get; set; }

    [JsonPropertyName("thirdparty_status")]
    public Int32? ThirdpartyStatus { get; set; }

    [JsonPropertyName("Threerd_party_ponumber")]
    public String? ThreerdPartyPonumber { get; set; }

    [JsonPropertyName("_ticket_access")]
    public Boolean? TicketAccess { get; set; }

    [JsonPropertyName("ticket_id")]
    public Int32? TicketId { get; set; }

    [JsonPropertyName("ticket_note")]
    public String? TicketNote { get; set; }

    [JsonPropertyName("ticket_summary")]
    public String? TicketSummary { get; set; }

    [JsonPropertyName("title")]
    public String? Title { get; set; }

    [JsonPropertyName("token")]
    public String? Token { get; set; }

    [JsonPropertyName("toplevel_name")]
    public String? ToplevelName { get; set; }

    [JsonPropertyName("total")]
    public Double? Total { get; set; }

    [JsonPropertyName("use")]
    public String? Use { get; set; }

    [JsonPropertyName("user_id")]
    public Int32? UserId { get; set; }

    [JsonPropertyName("user_name")]
    public String? UserName { get; set; }

    [JsonPropertyName("use_ticket_approval")]
    public Boolean? UseTicketApproval { get; set; }

    [JsonPropertyName("_validateonly")]
    public Boolean? Validateonly { get; set; }

    [JsonPropertyName("_warning")]
    public String? Warning { get; set; }

    [JsonPropertyName("warrantyurl")]
    public String? Warrantyurl { get; set; }

    [JsonPropertyName("xero_id")]
    public String? XeroId { get; set; }

    [JsonPropertyName("xero_status")]
    public String? XeroStatus { get; set; }

    [JsonPropertyName("xero_tenant_id")]
    public String? XeroTenantId { get; set; }
}
