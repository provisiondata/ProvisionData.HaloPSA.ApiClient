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

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public record ListClient
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

	[JsonPropertyName("use")]
	public String Use { get; set; } = String.Empty;

	[JsonPropertyName("xero_tenant_id")]
	public String XeroTenantId { get; set; } = String.Empty;

	[JsonPropertyName("accountsid")]
	public String Accountsid { get; set; } = String.Empty;

	[JsonPropertyName("overridepdftemplateinvoice")]
	public Int32 Overridepdftemplateinvoice { get; set; }

	[JsonPropertyName("client_to_invoice")]
	public Int32 ClientToInvoice { get; set; }

	[JsonPropertyName("itglue_id")]
	public String ItglueId { get; set; } = String.Empty;

	[JsonPropertyName("sentinel_subscription_id")]
	public String SentinelSubscriptionId { get; set; } = String.Empty;

	[JsonPropertyName("sentinel_workspace_name")]
	public String SentinelWorkspaceName { get; set; } = String.Empty;

	[JsonPropertyName("sentinel_resource_group_name")]
	public String SentinelResourceGroupName { get; set; } = String.Empty;

	[JsonPropertyName("default_currency_code")]
	public Int32 DefaultCurrencyCode { get; set; }

	[JsonPropertyName("client_to_invoice_recurring")]
	public Int32 ClientToInvoiceRecurring { get; set; }

	[JsonPropertyName("qbo_company_id")]
	public String QboCompanyId { get; set; } = String.Empty;

	[JsonPropertyName("dbc_company_id")]
	public String DbcCompanyId { get; set; } = String.Empty;

	[JsonPropertyName("stopped")]
	public Int32 Stopped { get; set; }

	[JsonPropertyName("customertype")]
	public Int32 Customertype { get; set; }

	[JsonPropertyName("servicenow_validated")]
	public Boolean ServicenowValidated { get; set; }

	[JsonPropertyName("jira_validated")]
	public Boolean JiraValidated { get; set; }

	[JsonPropertyName("ticket_invoices_for_each_site")]
	public Boolean TicketInvoicesForEachSite { get; set; }

	[JsonPropertyName("is_vip")]
	public Boolean IsVip { get; set; }

	[JsonPropertyName("taxable")]
	public Boolean Taxable { get; set; }

	[JsonPropertyName("percentage_to_survey")]
	public Int32 PercentageToSurvey { get; set; }

	[JsonPropertyName("overridepdftemplatequote")]
	public Int32 Overridepdftemplatequote { get; set; }

	[JsonPropertyName("notes")]
	public String Notes { get; set; } = String.Empty;

	[JsonPropertyName("ref")]
	public String Ref { get; set; } = String.Empty;

	[JsonPropertyName("logo")]
	public String Logo { get; set; } = String.Empty;
}

public class ListClientsResponse
{
	[JsonPropertyName("record_count")]
	public Int32 RecordCount { get; set; }

	[JsonPropertyName("clients")]
	public List<ListClient> Clients { get; set; } = [];
}

public class CreateClient
{
	[JsonPropertyName("client_name")]
	public String ClientName { get; set; } = String.Empty;
}
