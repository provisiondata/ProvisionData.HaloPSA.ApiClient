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

public class QuickbooksDetails
{
	[JsonPropertyName("id")]
	public Int32 Id { get; set; }

	[JsonPropertyName("name")]
    public String Name { get; set; } = String.Empty;
	[JsonPropertyName("country")]
    public String Country { get; set; } = String.Empty;
	[JsonPropertyName("company_id")]
    public String CompanyId { get; set; } = String.Empty;
	[JsonPropertyName("company_name")]
    public String CompanyName { get; set; } = String.Empty;
	[JsonPropertyName("new_access_token")]
    public String NewAccessToken { get; set; } = String.Empty;
	[JsonPropertyName("new_refresh_token")]
    public String NewRefreshToken { get; set; } = String.Empty;
	[JsonPropertyName("token_expiry")]
	public DateTime TokenExpiry { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("authorized")]
	public Boolean Authorized { get; set; }

	[JsonPropertyName("redirect_uri")]
    public String RedirectUri { get; set; } = String.Empty;
	[JsonPropertyName("authorization_code")]
    public String AuthorizationCode { get; set; } = String.Empty;
	[JsonPropertyName("_exchangecode")]
	public Boolean Exchangecode { get; set; }

	[JsonPropertyName("_disconnect")]
	public Boolean Disconnect { get; set; }

	[JsonPropertyName("_importtype")]
    public String Importtype { get; set; } = String.Empty;
	[JsonPropertyName("new_method")]
	public Boolean NewMethod { get; set; }

	[JsonPropertyName("automatic_sales_tax")]
	public Boolean AutomaticSalesTax { get; set; }

	[JsonPropertyName("online_payments")]
	public Boolean OnlinePayments { get; set; }

	[JsonPropertyName("api_url")]
    public String ApiUrl { get; set; } = String.Empty;
	[JsonPropertyName("client_id")]
    public String ClientId { get; set; } = String.Empty;
	[JsonPropertyName("new_client_secret")]
    public String NewClientSecret { get; set; } = String.Empty;
	[JsonPropertyName("default_tax_code_id")]
	public Int32 DefaultTaxCodeId { get; set; }

	[JsonPropertyName("default_tax_code_name")]
    public String DefaultTaxCodeName { get; set; } = String.Empty;
	[JsonPropertyName("default_tax_code")]
	public DefaultTaxCode DefaultTaxCode { get; set; } = default!;

	[JsonPropertyName("zero_tax_rate_id")]
	public Int32 ZeroTaxRateId { get; set; }

	[JsonPropertyName("zero_tax_rate_name")]
    public String ZeroTaxRateName { get; set; } = String.Empty;
	[JsonPropertyName("zero_tax_rate")]
	public ZeroTaxRate ZeroTaxRate { get; set; } = default!;

	[JsonPropertyName("client_top_level")]
	public Int32 ClientTopLevel { get; set; }

	[JsonPropertyName("client_top_level_name")]
    public String ClientTopLevelName { get; set; } = String.Empty;
	[JsonPropertyName("client_name_field")]
	public Int32 ClientNameField { get; set; }

	[JsonPropertyName("inventory_item_group")]
	public Int32 InventoryItemGroup { get; set; }

	[JsonPropertyName("inventory_item_group_name")]
    public String InventoryItemGroupName { get; set; } = String.Empty;
	[JsonPropertyName("non_inventory_item_group")]
	public Int32 NonInventoryItemGroup { get; set; }

	[JsonPropertyName("non_inventory_item_group_name")]
    public String NonInventoryItemGroupName { get; set; } = String.Empty;
	[JsonPropertyName("service_item_group")]
	public Int32 ServiceItemGroup { get; set; }

	[JsonPropertyName("service_item_group_name")]
    public String ServiceItemGroupName { get; set; } = String.Empty;
	[JsonPropertyName("enable_sync")]
	public Boolean EnableSync { get; set; }

	[JsonPropertyName("sync_entities")]
    public String SyncEntities { get; set; } = String.Empty;
	[JsonPropertyName("sync_entities_list")]
    public List<SyncEntitiesList> SyncEntitiesList { get; set; } = [];
	[JsonPropertyName("show_message")]
	public Boolean ShowMessage { get; set; }

	[JsonPropertyName("deactivate_customers")]
	public Boolean DeactivateCustomers { get; set; }

	[JsonPropertyName("default_invoice_item")]
	public Int32 DefaultInvoiceItem { get; set; }

	[JsonPropertyName("default_order_item")]
	public Int32 DefaultOrderItem { get; set; }

	[JsonPropertyName("default_invoice_item_name")]
    public String DefaultInvoiceItemName { get; set; } = String.Empty;
	[JsonPropertyName("default_order_item_name")]
    public String DefaultOrderItemName { get; set; } = String.Empty;
	[JsonPropertyName("invoice_email_status")]
	public Int32 InvoiceEmailStatus { get; set; }

	[JsonPropertyName("supplier_top_level")]
	public Int32 SupplierTopLevel { get; set; }

	[JsonPropertyName("supplier_top_level_name")]
    public String SupplierTopLevelName { get; set; } = String.Empty;
	[JsonPropertyName("supplier_name_field")]
	public Int32 SupplierNameField { get; set; }

	[JsonPropertyName("default_order_account_id")]
	public Int32 DefaultOrderAccountId { get; set; }

	[JsonPropertyName("default_order_account_name")]
    public String DefaultOrderAccountName { get; set; } = String.Empty;
	[JsonPropertyName("default_order_account")]
	public Account DefaultOrderAccount { get; set; } = default!;

	[JsonPropertyName("order_email_status")]
	public Int32 OrderEmailStatus { get; set; }

	[JsonPropertyName("multi_currency")]
	public Boolean MultiCurrency { get; set; }

	[JsonPropertyName("default_sales_account_id")]
	public Int32 DefaultSalesAccountId { get; set; }

	[JsonPropertyName("default_sales_account_name")]
    public String DefaultSalesAccountName { get; set; } = String.Empty;
	[JsonPropertyName("default_sales_account")]
	public Account DefaultSalesAccount { get; set; } = default!;

	[JsonPropertyName("default_expense_account_id")]
	public Int32 DefaultExpenseAccountId { get; set; }

	[JsonPropertyName("default_expense_account_name")]
    public String DefaultExpenseAccountName { get; set; } = String.Empty;
	[JsonPropertyName("default_expense_account")]
	public Account DefaultExpenseAccount { get; set; } = default!;

	[JsonPropertyName("default_asset_account_id")]
	public Int32 DefaultAssetAccountId { get; set; }

	[JsonPropertyName("default_asset_account_name")]
    public String DefaultAssetAccountName { get; set; } = String.Empty;
	[JsonPropertyName("default_asset_account")]
	public Account DefaultAssetAccount { get; set; } = default!;

	[JsonPropertyName("receive_client_created")]
	public Boolean ReceiveClientCreated { get; set; }

	[JsonPropertyName("receive_client_updated")]
	public Boolean ReceiveClientUpdated { get; set; }

	[JsonPropertyName("receive_payment_created")]
	public Boolean ReceivePaymentCreated { get; set; }

	[JsonPropertyName("receive_payment_updated")]
	public Boolean ReceivePaymentUpdated { get; set; }

	[JsonPropertyName("sync_halo_invoice_id")]
	public Boolean SyncHaloInvoiceId { get; set; }

	[JsonPropertyName("sync_invoice_class")]
	public Boolean SyncInvoiceClass { get; set; }

	[JsonPropertyName("sync_invoice_bill_address")]
	public Boolean SyncInvoiceBillAddress { get; set; }

	[JsonPropertyName("sync_invoice_ship_address")]
	public Boolean SyncInvoiceShipAddress { get; set; }

	[JsonPropertyName("use_qbo_invoice_terms")]
	public Boolean UseQboInvoiceTerms { get; set; }

	[JsonPropertyName("round_payments_to_2dp")]
	public Boolean RoundPaymentsTo2dp { get; set; }

	[JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;
	[JsonPropertyName("default_deferred_code_id")]
	public Int32 DefaultDeferredCodeId { get; set; }

	[JsonPropertyName("default_deferred_code_name")]
    public String DefaultDeferredCodeName { get; set; } = String.Empty;
	[JsonPropertyName("default_deferred_account")]
	public Account DefaultDeferredAccount { get; set; } = default!;
}
