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

public record Client
{
	[JsonPropertyName("id")]
	public Int32 Id { get; set; }

	[JsonPropertyName("name")]
	public String Name { get; set; } = String.Empty;

	[JsonPropertyName("toplevel_id")]
	public Int32 ToplevelId { get; set; }

	[JsonPropertyName("toplevel_name")]
	public String ToplevelName { get; set; } = String.Empty;

	[JsonPropertyName("inactive")]
	public Boolean Inactive { get; set; }

	[JsonPropertyName("colour")]
	public String Colour { get; set; } = String.Empty;

	[JsonPropertyName("confirmemail")]
	public Int32 Confirmemail { get; set; }

	[JsonPropertyName("actionemail")]
	public Int32 Actionemail { get; set; }

	[JsonPropertyName("clearemail")]
	public Int32 Clearemail { get; set; }

	[JsonPropertyName("messagegroup_id")]
	public Int32 MessagegroupId { get; set; }

	[JsonPropertyName("mailbox_override")]
	public Int32 MailboxOverride { get; set; }

	[JsonPropertyName("default_mailbox_id")]
	public Int32 DefaultMailboxId { get; set; }

	[JsonPropertyName("item_tax_code")]
	public Int32 ItemTaxCode { get; set; }

	[JsonPropertyName("service_tax_code")]
	public Int32 ServiceTaxCode { get; set; }

	[JsonPropertyName("prepay_tax_code")]
	public Int32 PrepayTaxCode { get; set; }

	[JsonPropertyName("contract_tax_code")]
	public Int32 ContractTaxCode { get; set; }

	[JsonPropertyName("pritech")]
	public Int32 Pritech { get; set; }

	[JsonPropertyName("sectech")]
	public Int32 Sectech { get; set; }

	[JsonPropertyName("accountmanagertech")]
	public Int32 Accountmanagertech { get; set; }

	[JsonPropertyName("notes")]
	public String Notes { get; set; } = String.Empty;

	[JsonPropertyName("datecreated")]
	public DateTime Datecreated { get; set; }

	[JsonPropertyName("createdfrom_id")]
	public Int32 CreatedfromId { get; set; }

	[JsonPropertyName("pritech_name")]
	public String PritechName { get; set; } = String.Empty;

	[JsonPropertyName("sectech_name")]
	public String SectechName { get; set; } = String.Empty;

	[JsonPropertyName("prinotify")]
	public Boolean Prinotify { get; set; }

	[JsonPropertyName("secnotify")]
	public Boolean Secnotify { get; set; }

	[JsonPropertyName("priassign")]
	public Boolean Priassign { get; set; }

	[JsonPropertyName("secassign")]
	public Boolean Secassign { get; set; }

	[JsonPropertyName("accountmanagertech_name")]
	public String AccountmanagertechName { get; set; } = String.Empty;

	[JsonPropertyName("invoiceyes")]
	public Boolean Invoiceyes { get; set; }

	[JsonPropertyName("floverride")]
	public Boolean Floverride { get; set; }

	[JsonPropertyName("fluserdef1hide")]
	public Boolean Fluserdef1hide { get; set; }

	[JsonPropertyName("fluserdef2hide")]
	public Boolean Fluserdef2hide { get; set; }

	[JsonPropertyName("fluserdef3hide")]
	public Boolean Fluserdef3hide { get; set; }

	[JsonPropertyName("fluserdef4hide")]
	public Boolean Fluserdef4hide { get; set; }

	[JsonPropertyName("fluserdef5hide")]
	public Boolean Fluserdef5hide { get; set; }

	[JsonPropertyName("fluserdef1mand")]
	public Boolean Fluserdef1mand { get; set; }

	[JsonPropertyName("fluserdef2mand")]
	public Boolean Fluserdef2mand { get; set; }

	[JsonPropertyName("fluserdef3mand")]
	public Boolean Fluserdef3mand { get; set; }

	[JsonPropertyName("fluserdef4mand")]
	public Boolean Fluserdef4mand { get; set; }

	[JsonPropertyName("fluserdef5mand")]
	public Boolean Fluserdef5mand { get; set; }

	[JsonPropertyName("includeactions")]
	public Boolean Includeactions { get; set; }

	[JsonPropertyName("needsinvoice")]
	public Boolean Needsinvoice { get; set; }

	[JsonPropertyName("dontinvoice")]
	public Boolean Dontinvoice { get; set; }

	[JsonPropertyName("showslaonweb")]
	public Boolean Showslaonweb { get; set; }

	[JsonPropertyName("item_tax_code_name")]
	public String ItemTaxCodeName { get; set; } = String.Empty;

	[JsonPropertyName("service_tax_code_name")]
	public String ServiceTaxCodeName { get; set; } = String.Empty;

	[JsonPropertyName("contract_tax_code_name")]
	public String ContractTaxCodeName { get; set; } = String.Empty;

	[JsonPropertyName("prepay_tax_code_name")]
	public String PrepayTaxCodeName { get; set; } = String.Empty;

	[JsonPropertyName("imageindex")]
	public Int32 Imageindex { get; set; }

	[JsonPropertyName("fcemail")]
	public Int32 Fcemail { get; set; }

	[JsonPropertyName("emailinvoice")]
	public Boolean Emailinvoice { get; set; }

	[JsonPropertyName("monthlyreportinclude")]
	public Boolean Monthlyreportinclude { get; set; }

	[JsonPropertyName("monthlyreportemaildirect")]
	public Boolean Monthlyreportemaildirect { get; set; }

	[JsonPropertyName("monthlyreportemailmanager")]
	public Boolean Monthlyreportemailmanager { get; set; }

	[JsonPropertyName("monthlyreportshowonweb")]
	public Boolean Monthlyreportshowonweb { get; set; }

	[JsonPropertyName("unmatchedcombinations")]
	public Int32 Unmatchedcombinations { get; set; }

	[JsonPropertyName("billforrecurringprepayamount")]
	public Boolean Billforrecurringprepayamount { get; set; }

	[JsonPropertyName("accountsemailaddress")]
	public String Accountsemailaddress { get; set; } = String.Empty;

	[JsonPropertyName("autotopupthreshhold")]
	public Decimal Autotopupthreshhold { get; set; }

	[JsonPropertyName("autotopupcostperhour")]
	public Decimal Autotopupcostperhour { get; set; }

	[JsonPropertyName("autotopupbyamount")]
	public Decimal Autotopupbyamount { get; set; }

	[JsonPropertyName("surchargeid")]
	public Int32 Surchargeid { get; set; }

	[JsonPropertyName("billingtemplate_id")]
	public Int32 BillingtemplateId { get; set; }

	[JsonPropertyName("isopportunity")]
	public Int32 Isopportunity { get; set; }

	[JsonPropertyName("main_site_id")]
	public Int32 MainSiteId { get; set; }

	[JsonPropertyName("main_site_name")]
	public String MainSiteName { get; set; } = String.Empty;

	[JsonPropertyName("all_organisations_allowed")]
	public Boolean AllOrganisationsAllowed { get; set; }

	[JsonPropertyName("allowed_organisations")]
	public List<Object> AllowedOrganisations { get; } = [];

	[JsonPropertyName("faqlists")]
	public List<Object> Faqlists { get; } = [];

	[JsonPropertyName("popup_notes")]
	public List<PopupNote> PopupNotes { get; } = [];

	[JsonPropertyName("allowall_tickettypes")]
	public Boolean AllowallTickettypes { get; set; }

	[JsonPropertyName("allowed_tickettypes")]
	public List<Object> AllowedTickettypes { get; } = [];

	[JsonPropertyName("allowall_category1")]
	public Boolean AllowallCategory1 { get; set; }

	[JsonPropertyName("allowed_category1")]
	public List<Object> AllowedCategory1 { get; } = [];

	[JsonPropertyName("allowall_category2")]
	public Boolean AllowallCategory2 { get; set; }

	[JsonPropertyName("allowed_category2")]
	public List<Object> AllowedCategory2 { get; } = [];

	[JsonPropertyName("allowall_category3")]
	public Boolean AllowallCategory3 { get; set; }

	[JsonPropertyName("allowed_category3")]
	public List<Object> AllowedCategory3 { get; } = [];

	[JsonPropertyName("allowall_category4")]
	public Boolean AllowallCategory4 { get; set; }

	[JsonPropertyName("alocked")]
	public Boolean Alocked { get; set; }

	[JsonPropertyName("allowed_category4")]
	public List<Object> AllowedCategory4 { get; } = [];

	[JsonPropertyName("billingplans")]
	public List<Billingplan> Billingplans { get; } = [];

	[JsonPropertyName("overriding_rates")]
	public List<Object> OverridingRates { get; } = [];

	[JsonPropertyName("allowallchargerates")]
	public Boolean Allowallchargerates { get; set; }

	[JsonPropertyName("chargerates")]
	public List<Object> Chargerates { get; } = [];

	[JsonPropertyName("excludefrominvoicesync")]
	public Boolean Excludefrominvoicesync { get; set; }

	[JsonPropertyName("allow_api_access")]
	public Boolean AllowApiAccess { get; set; }

	[JsonPropertyName("areaitems")]
	public List<Object> Areaitems { get; } = [];

	[JsonPropertyName("override_portalcolour")]
	public Boolean OverridePortalcolour { get; set; }

	[JsonPropertyName("portalcolour")]
	public String Portalcolour { get; set; } = String.Empty;

	[JsonPropertyName("ninjarmmid")]
	public Int32 Ninjarmmid { get; set; }

	[JsonPropertyName("purchase_tax_code")]
	public Int32 PurchaseTaxCode { get; set; }

	[JsonPropertyName("purchase_tax_code_name")]
	public String PurchaseTaxCodeName { get; set; } = String.Empty;

	[JsonPropertyName("prepayrecurringminimumdeductiononlyactive")]
	public Boolean Prepayrecurringminimumdeductiononlyactive { get; set; }

	[JsonPropertyName("qbodefaulttax")]
	public Int32 Qbodefaulttax { get; set; }

	[JsonPropertyName("device42id")]
	public Int32 Device42id { get; set; }

	[JsonPropertyName("xero_tenant_name")]
	public String XeroTenantName { get; set; } = String.Empty;

	[JsonPropertyName("servicenowid")]
	public String Servicenowid { get; set; } = String.Empty;

	[JsonPropertyName("isnhserveremaildefault")]
	public Boolean Isnhserveremaildefault { get; set; }

	[JsonPropertyName("datto_id")]
	public String DattoId { get; set; } = String.Empty;

	[JsonPropertyName("datto_alternate_id")]
	public Int32 DattoAlternateId { get; set; }

	[JsonPropertyName("datto_url")]
	public String DattoUrl { get; set; } = String.Empty;

	[JsonPropertyName("dattocommerce_tenantid")]
	public Int32 DattocommerceTenantid { get; set; }

	[JsonPropertyName("qbodefaulttaxcode")]
	public Int32 Qbodefaulttaxcode { get; set; }

	[JsonPropertyName("qbodefaulttaxcodename")]
	public String Qbodefaulttaxcodename { get; set; } = String.Empty;

	[JsonPropertyName("connectwiseid")]
	public Int32 Connectwiseid { get; set; }

	[JsonPropertyName("autotaskid")]
	public Int32 Autotaskid { get; set; }

	[JsonPropertyName("ateraid")]
	public Int32 Ateraid { get; set; }

	[JsonPropertyName("kashflowid")]
	public Int32 Kashflowid { get; set; }

	[JsonPropertyName("kashflow_tenant_name")]
	public String KashflowTenantName { get; set; } = String.Empty;

	[JsonPropertyName("website")]
	public String Website { get; set; } = String.Empty;

	[JsonPropertyName("alastupdate")]
	public DateTime Alastupdate { get; set; }

	[JsonPropertyName("service_access")]
	public List<ServiceAccess> ServiceAccess { get; } = [];

	[JsonPropertyName("service_subscriptions")]
	public List<Object> ServiceSubscriptions { get; } = [];

	[JsonPropertyName("snelstart_id")]
	public String SnelstartId { get; set; } = String.Empty;

	[JsonPropertyName("default_currency_code_name")]
	public String DefaultCurrencyCodeName { get; set; } = String.Empty;

	[JsonPropertyName("syncroid")]
	public Int32 Syncroid { get; set; }

	[JsonPropertyName("hubspot_id")]
	public String HubspotId { get; set; } = String.Empty;

	[JsonPropertyName("hubspot_url")]
	public String HubspotUrl { get; set; } = String.Empty;

	[JsonPropertyName("hubspot_dont_sync")]
	public Boolean HubspotDontSync { get; set; }

	[JsonPropertyName("hubspot_archived")]
	public Boolean HubspotArchived { get; set; }

	[JsonPropertyName("domain")]
	public String Domain { get; set; } = String.Empty;

	[JsonPropertyName("passportal_id")]
	public Int32 PassportalId { get; set; }

	[JsonPropertyName("prepayasamount")]
	public Boolean Prepayasamount { get; set; }

	[JsonPropertyName("qbo_company_name")]
	public String QboCompanyName { get; set; } = String.Empty;

	[JsonPropertyName("hubspot_lifecycle")]
	public String HubspotLifecycle { get; set; } = String.Empty;

	[JsonPropertyName("prepayrecurringexpirymonths")]
	public Int32 Prepayrecurringexpirymonths { get; set; }

	[JsonPropertyName("defaultcontractoverride_ref")]
	public String DefaultcontractoverrideRef { get; set; } = String.Empty;

	[JsonPropertyName("external_links")]
	public List<Object> ExternalLinks { get; } = [];

	[JsonPropertyName("liongardid")]
	public Int32 Liongardid { get; set; }

	[JsonPropertyName("liongard_url")]
	public String LiongardUrl { get; set; } = String.Empty;

	[JsonPropertyName("regmanagertech_name")]
	public String RegmanagertechName { get; set; } = String.Empty;

	[JsonPropertyName("logmanagertech_name")]
	public String LogmanagertechName { get; set; } = String.Empty;

	[JsonPropertyName("salesreptech_name")]
	public String SalesreptechName { get; set; } = String.Empty;

	[JsonPropertyName("default_team_to_salesrep_override")]
	public Boolean DefaultTeamToSalesrepOverride { get; set; }

	[JsonPropertyName("cxmleadtech_name")]
	public String CxmleadtechName { get; set; } = String.Empty;

	[JsonPropertyName("portalchatprofile")]
	public String Portalchatprofile { get; set; } = String.Empty;

	[JsonPropertyName("portalchatprofile_name")]
	public String PortalchatprofileName { get; set; } = String.Empty;

	[JsonPropertyName("trading_name")]
	public String TradingName { get; set; } = String.Empty;

	[JsonPropertyName("dbc_company_name")]
	public String DbcCompanyName { get; set; } = String.Empty;

	[JsonPropertyName("salesforce_dontsync")]
	public Boolean SalesforceDontsync { get; set; }

	[JsonPropertyName("stripe_payment_method_id")]
	public String StripePaymentMethodId { get; set; } = String.Empty;

	[JsonPropertyName("servicenow_url")]
	public String ServicenowUrl { get; set; } = String.Empty;

	[JsonPropertyName("servicenow_locale")]
	public String ServicenowLocale { get; set; } = String.Empty;

	[JsonPropertyName("servicenow_username")]
	public String ServicenowUsername { get; set; } = String.Empty;

	[JsonPropertyName("servicenow_assignment_group")]
	public String ServicenowAssignmentGroup { get; set; } = String.Empty;

	[JsonPropertyName("servicenow_assignment_group_name")]
	public String ServicenowAssignmentGroupName { get; set; } = String.Empty;

	[JsonPropertyName("servicenow_defaultuser_id")]
	public String ServicenowDefaultuserId { get; set; } = String.Empty;

	[JsonPropertyName("servicenow_defaultuser_name")]
	public String ServicenowDefaultuserName { get; set; } = String.Empty;

	[JsonPropertyName("sage_business_cloud_details_id")]
	public Int32 SageBusinessCloudDetailsId { get; set; }

	[JsonPropertyName("sage_business_cloud_details_name")]
	public String SageBusinessCloudDetailsName { get; set; } = String.Empty;

	[JsonPropertyName("exact_division")]
	public Int32 ExactDivision { get; set; }

	[JsonPropertyName("exact_division_name")]
	public String ExactDivisionName { get; set; } = String.Empty;

	[JsonPropertyName("ncentral_details_id")]
	public Int32 NcentralDetailsId { get; set; }

	[JsonPropertyName("jira_url")]
	public String JiraUrl { get; set; } = String.Empty;

	[JsonPropertyName("jira_username")]
	public String JiraUsername { get; set; } = String.Empty;

	[JsonPropertyName("jira_servicedesk_id")]
	public String JiraServicedeskId { get; set; } = String.Empty;

	[JsonPropertyName("jira_servicedesk_name")]
	public String JiraServicedeskName { get; set; } = String.Empty;

	[JsonPropertyName("jira_user_id")]
	public String JiraUserId { get; set; } = String.Empty;

	[JsonPropertyName("jira_user_name")]
	public String JiraUserName { get; set; } = String.Empty;

	[JsonPropertyName("defaultpdftemplateinvoicetickets_name")]
	public String DefaultpdftemplateinvoiceticketsName { get; set; } = String.Empty;

	[JsonPropertyName("defaultpdftemplateinvoiceorders_name")]
	public String DefaultpdftemplateinvoiceordersName { get; set; } = String.Empty;

	[JsonPropertyName("defaultpdftemplateinvoicerecurring_name")]
	public String DefaultpdftemplateinvoicerecurringName { get; set; } = String.Empty;

	[JsonPropertyName("main_delivery_address")]
	public MainDeliveryAddress MainDeliveryAddress { get; set; } = new();

	[JsonPropertyName("main_contact_name")]
	public String MainContactName { get; set; } = String.Empty;

	[JsonPropertyName("main_phonenumber")]
	public String MainPhonenumber { get; set; } = String.Empty;

	[JsonPropertyName("servicenow_enable_webhook")]
	public Boolean ServicenowEnableWebhook { get; set; }

	[JsonPropertyName("servicenow_webhook_user")]
	public Int32 ServicenowWebhookUser { get; set; }

	[JsonPropertyName("servicenow_webhook_tickettype")]
	public Int32 ServicenowWebhookTickettype { get; set; }

	[JsonPropertyName("sync_servicenow_attachments")]
	public Int32 SyncServicenowAttachments { get; set; }

	[JsonPropertyName("override_layout_id")]
	public Int32 OverrideLayoutId { get; set; }

	[JsonPropertyName("override_layout_name")]
	public String OverrideLayoutName { get; set; } = String.Empty;

	[JsonPropertyName("extratabs")]
	public List<Object> Extratabs { get; } = [];

	[JsonPropertyName("servicenow_ticket_sync")]
	public String ServicenowTicketSync { get; set; } = String.Empty;

	[JsonPropertyName("jira_webhook_username")]
	public String JiraWebhookUsername { get; set; } = String.Empty;

	[JsonPropertyName("use")]
	public String Use { get; set; } = String.Empty;

	[JsonPropertyName("xero_tenant_id")]
	public String XeroTenantId { get; set; } = String.Empty;

	[JsonPropertyName("accountsid")]
	public String AccountsId { get; set; } = String.Empty;

	[JsonPropertyName("overridepdftemplateinvoice")]
	public Int32 Overridepdftemplateinvoice { get; set; }

	[JsonPropertyName("overridepdftemplateinvoice_name")]
	public String OverridepdftemplateinvoiceName { get; set; } = String.Empty;

	[JsonPropertyName("client_to_invoice")]
	public Int32 ClientToInvoice { get; set; }

	[JsonPropertyName("client_to_invoice_name")]
	public String ClientToInvoiceName { get; set; } = String.Empty;

	[JsonPropertyName("itglue_id")]
	public String ItglueId { get; set; } = String.Empty;

	[JsonPropertyName("sentinel_subscription_id")]
	public String SentinelSubscriptionId { get; set; } = String.Empty;

	[JsonPropertyName("sentinel_workspace_name")]
	public String SentinelWorkspaceName { get; set; } = String.Empty;

	[JsonPropertyName("sentinel_resource_group_name")]
	public String SentinelResourceGroupName { get; set; } = String.Empty;

	[JsonPropertyName("sentinel_tenant_name")]
	public String SentinelTenantName { get; set; } = String.Empty;

	[JsonPropertyName("default_currency_code")]
	public Int32 DefaultCurrencyCode { get; set; }

	[JsonPropertyName("client_to_invoice_recurring")]
	public Int32 ClientToInvoiceRecurring { get; set; }

	[JsonPropertyName("client_to_invoice_recurring_name")]
	public String ClientToInvoiceRecurringName { get; set; } = String.Empty;

	[JsonPropertyName("azure_tenants")]
	public List<Object> AzureTenants { get; } = [];

	[JsonPropertyName("qbo_company_id")]
	public String QboCompanyId { get; set; } = String.Empty;

	[JsonPropertyName("automatic_sales_tax")]
	public Boolean AutomaticSalesTax { get; set; }

	[JsonPropertyName("dbc_company_id")]
	public String DbcCompanyId { get; set; } = String.Empty;

	[JsonPropertyName("stopped")]
	public Int32 Stopped { get; set; }

	[JsonPropertyName("customertype")]
	public Int32 Customertype { get; set; }

	[JsonPropertyName("servicenow_validated")]
	public Boolean ServicenowValidated { get; set; }

	[JsonPropertyName("sentinel_default_user_override_name")]
	public String SentinelDefaultUserOverrideName { get; set; } = String.Empty;

	[JsonPropertyName("jira_validated")]
	public Boolean JiraValidated { get; set; }

	[JsonPropertyName("ref")]
	public String Ref { get; set; } = String.Empty;

	[JsonPropertyName("ticket_invoices_for_each_site")]
	public Boolean TicketInvoicesForEachSite { get; set; }

	[JsonPropertyName("is_vip")]
	public Boolean IsVip { get; set; }

	[JsonPropertyName("accountownertech_name")]
	public String AccountownertechName { get; set; } = String.Empty;

	[JsonPropertyName("taxable")]
	public Boolean Taxable { get; set; }

	[JsonPropertyName("percentage_to_survey")]
	public Int32 PercentageToSurvey { get; set; }

	[JsonPropertyName("overridepdftemplatequote")]
	public Int32 Overridepdftemplatequote { get; set; }

	[JsonPropertyName("overridepdftemplatequote_name")]
	public String OverridepdftemplatequoteName { get; set; } = String.Empty;
	public List<Site> Sites { get; set; } = [];
}

public class Billingplan
{
	[JsonPropertyName("client_id")]
	public Int32 ClientId { get; set; }

	[JsonPropertyName("seq")]
	public Int32 Seq { get; set; }

	[JsonPropertyName("type")]
	public Int32 Type { get; set; }

	[JsonPropertyName("itil_requesttype")]
	public Int32 ItilRequesttype { get; set; }

	[JsonPropertyName("requesttype")]
	public Int32 Requesttype { get; set; }

	[JsonPropertyName("priority")]
	public Int32 Priority { get; set; }

	[JsonPropertyName("chargerate_id")]
	public Int32 ChargerateId { get; set; }

	[JsonPropertyName("chargerate_name")]
	public String ChargerateName { get; set; } = String.Empty;

	[JsonPropertyName("multiplier")]
	public Int32 Multiplier { get; set; }

	[JsonPropertyName("plan_id")]
	public Int32 PlanId { get; set; }

	[JsonPropertyName("plan_name")]
	public String PlanName { get; set; } = String.Empty;

	[JsonPropertyName("category_1")]
	public String Category1 { get; set; } = String.Empty;

	[JsonPropertyName("partialmatchcategory")]
	public Boolean Partialmatchcategory { get; set; }

	[JsonPropertyName("category_2")]
	public String Category2 { get; set; } = String.Empty;

	[JsonPropertyName("partialmatchcategory2")]
	public Boolean Partialmatchcategory2 { get; set; }

	[JsonPropertyName("category_3")]
	public String Category3 { get; set; } = String.Empty;

	[JsonPropertyName("partialmatchcategory3")]
	public Boolean Partialmatchcategory3 { get; set; }

	[JsonPropertyName("category_4")]
	public String Category4 { get; set; } = String.Empty;

	[JsonPropertyName("partialmatchcategory4")]
	public Boolean Partialmatchcategory4 { get; set; }

	[JsonPropertyName("user_covered_billingdescription")]
	public Int32 UserCoveredBillingdescription { get; set; }

	[JsonPropertyName("site")]
	public Int32 Site { get; set; }

	[JsonPropertyName("site_name")]
	public String SiteName { get; set; } = String.Empty;

	[JsonPropertyName("allowallcontracts")]
	public Boolean Allowallcontracts { get; set; }

	[JsonPropertyName("asset_covered_by_contract")]
	public Boolean AssetCoveredByContract { get; set; }

	[JsonPropertyName("user_covered_by_contract")]
	public Boolean UserCoveredByContract { get; set; }

	[JsonPropertyName("work_hours_covered")]
	public Int32 WorkHoursCovered { get; set; }

	[JsonPropertyName("order")]
	public Int32 Order { get; set; }

	[JsonPropertyName("billing_plan_desc")]
	public String BillingPlanDesc { get; set; } = String.Empty;
}

public record MainDeliveryAddress
{
	[JsonPropertyName("id")]
	public Int32 Id { get; set; }

	[JsonPropertyName("type")]
	public Int32 Type { get; set; }

	[JsonPropertyName("line1")]
	public String Line1 { get; set; } = String.Empty;

	[JsonPropertyName("line2")]
	public String Line2 { get; set; } = String.Empty;

	[JsonPropertyName("line3")]
	public String Line3 { get; set; } = String.Empty;

	[JsonPropertyName("line4")]
	public String Line4 { get; set; } = String.Empty;

	[JsonPropertyName("postcode")]
	public String Postcode { get; set; } = String.Empty;

	[JsonPropertyName("primary")]
	public Boolean Primary { get; set; }

	[JsonPropertyName("inactive")]
	public Boolean Inactive { get; set; }

	[JsonPropertyName("date_active")]
	public DateTime DateActive { get; set; }

	[JsonPropertyName("site_id")]
	public Int32 SiteId { get; set; }
}

public record PopupNote
{
	[JsonPropertyName("id")]
	public Int32 Id { get; set; }

	[JsonPropertyName("client_id")]
	public Int32 ClientId { get; set; }

	[JsonPropertyName("date_created")]
	public DateTime DateCreated { get; set; }

	[JsonPropertyName("note")]
	public String Note { get; set; } = String.Empty;

	[JsonPropertyName("dismissable")]
	public Boolean Dismissable { get; set; }

	[JsonPropertyName("read_status")]
	public Int32 ReadStatus { get; set; }

	[JsonPropertyName("displaymodal")]
	public Boolean Displaymodal { get; set; }

	[JsonPropertyName("displayhtml")]
	public Boolean Displayhtml { get; set; }

	[JsonPropertyName("limitdaterange")]
	public Boolean Limitdaterange { get; set; }
}

public record ServiceAccess
{
	[JsonPropertyName("id")]
	public Int32 Id { get; set; }

	[JsonPropertyName("service_category_id")]
	public Int32 ServiceCategoryId { get; set; }

	[JsonPropertyName("service_id")]
	public Int32 ServiceId { get; set; }

	[JsonPropertyName("type")]
	public String Type { get; set; } = String.Empty;

	[JsonPropertyName("data_id")]
	public Int32 DataId { get; set; }

	[JsonPropertyName("data_name")]
	public String DataName { get; set; } = String.Empty;

	[JsonPropertyName("service_name")]
	public String ServiceName { get; set; } = String.Empty;

	[JsonPropertyName("allow_access")]
	public Boolean AllowAccess { get; set; }
}
