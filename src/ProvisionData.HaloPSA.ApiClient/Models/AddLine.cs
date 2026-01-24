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

public class AddLine
{
	[JsonPropertyName("customfields")]
	public List<CustomField> Customfields { get; set; } = [];
	[JsonPropertyName("id")]
	public Int32 Id { get; set; }

	[JsonPropertyName("ihid")]
	public Int32 Ihid { get; set; }

	[JsonPropertyName("item_code")]
	public String ItemCode { get; set; } = String.Empty;
	[JsonPropertyName("item_shortdescription")]
	public String ItemShortdescription { get; set; } = String.Empty;
	[JsonPropertyName("item_longdescription")]
	public String ItemLongdescription { get; set; } = String.Empty;
	[JsonPropertyName("nominal_code")]
	public String NominalCode { get; set; } = String.Empty;
	[JsonPropertyName("tax_code")]
	public String TaxCode { get; set; } = String.Empty;
	[JsonPropertyName("qty_order")]
	public Int32 QtyOrder { get; set; }

	[JsonPropertyName("unit_price")]
	public Int32 UnitPrice { get; set; }

	[JsonPropertyName("net_amount")]
	public Int32 NetAmount { get; set; }

	[JsonPropertyName("tax_amount")]
	public Int32 TaxAmount { get; set; }

	[JsonPropertyName("tax_rate")]
	public Int32 TaxRate { get; set; }

	[JsonPropertyName("comment_1")]
	public String Comment1 { get; set; } = String.Empty;
	[JsonPropertyName("comment_2")]
	public String Comment2 { get; set; } = String.Empty;
	[JsonPropertyName("itemonorder")]
	public Boolean Itemonorder { get; set; }

	[JsonPropertyName("dsite")]
	public Int32 Dsite { get; set; }

	[JsonPropertyName("ddevnum")]
	public Int32 Ddevnum { get; set; }

	[JsonPropertyName("_itemid")]
	public Int32 Itemid { get; set; }

	[JsonPropertyName("productnumber")]
	public String Productnumber { get; set; } = String.Empty;
	[JsonPropertyName("unit_cost")]
	public Int32 UnitCost { get; set; }

	[JsonPropertyName("asset_id")]
	public Int32 AssetId { get; set; }

	[JsonPropertyName("asset_inventory_number")]
	public String AssetInventoryNumber { get; set; } = String.Empty;
	[JsonPropertyName("contract_id")]
	public Int32 ContractId { get; set; }

	[JsonPropertyName("recurring_invoice_id")]
	public Int32 RecurringInvoiceId { get; set; }

	[JsonPropertyName("recurring_invoice_line_id")]
	public Int32 RecurringInvoiceLineId { get; set; }

	[JsonPropertyName("actioncode")]
	public Int32 Actioncode { get; set; }

	[JsonPropertyName("site")]
	public Int32 Site { get; set; }

	[JsonPropertyName("meter_id")]
	public Int32 MeterId { get; set; }

	[JsonPropertyName("ticket_id")]
	public Int32 TicketId { get; set; }

	[JsonPropertyName("lineactiondate")]
	public DateTime Lineactiondate { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("labourdepartmentid")]
	public Int32 Labourdepartmentid { get; set; }

	[JsonPropertyName("salesorder_line")]
	public Int32 SalesorderLine { get; set; }

	[JsonPropertyName("salesorder_line_id")]
	public Int32 SalesorderLineId { get; set; }

	[JsonPropertyName("meter_pricing_method")]
	public Int32 MeterPricingMethod { get; set; }

	[JsonPropertyName("line_fully_invoiced")]
	public Boolean LineFullyInvoiced { get; set; }

	[JsonPropertyName("item_tax_code")]
	public Int32 ItemTaxCode { get; set; }

	[JsonPropertyName("net_total")]
	public Int32 NetTotal { get; set; }

	[JsonPropertyName("total_price")]
	public Int32 TotalPrice { get; set; }

	[JsonPropertyName("total_tax")]
	public Int32 TotalTax { get; set; }

	[JsonPropertyName("total_discount")]
	public Int32 TotalDiscount { get; set; }

	[JsonPropertyName("xero_lineid")]
	public String XeroLineid { get; set; } = String.Empty;
	[JsonPropertyName("prepay_id")]
	public Int32 PrepayId { get; set; }

	[JsonPropertyName("calculate_price_from_assets")]
	public Boolean CalculatePriceFromAssets { get; set; }

	[JsonPropertyName("calculate_price_from_users")]
	public Boolean CalculatePriceFromUsers { get; set; }

	[JsonPropertyName("creditlinkedidid")]
	public Int32 Creditlinkedidid { get; set; }

	[JsonPropertyName("recurring_invoice_price_type")]
	public Int32 RecurringInvoicePriceType { get; set; }

	[JsonPropertyName("entity_type")]
	public String EntityType { get; set; } = String.Empty;
	[JsonPropertyName("item_internal_reference")]
	public String ItemInternalReference { get; set; } = String.Empty;
	[JsonPropertyName("item_external_reference")]
	public String ItemExternalReference { get; set; } = String.Empty;
	[JsonPropertyName("linked_item")]
	public LinkedItem LinkedItem { get; set; } = default!;

	[JsonPropertyName("item_tax_name")]
	public String ItemTaxName { get; set; } = String.Empty;
	[JsonPropertyName("xero_tax_code")]
	public String XeroTaxCode { get; set; } = String.Empty;
	[JsonPropertyName("override_ast_total")]
	public Int32 OverrideAstTotal { get; set; }

	[JsonPropertyName("prorata_next_invoice")]
	public Boolean ProrataNextInvoice { get; set; }

	[JsonPropertyName("prorata_quantity")]
	public Int32 ProrataQuantity { get; set; }

	[JsonPropertyName("prorata_unit_price")]
	public Int32 ProrataUnitPrice { get; set; }

	[JsonPropertyName("prorata_shortdescription")]
	public String ProrataShortdescription { get; set; } = String.Empty;
	[JsonPropertyName("prorata_longdescription")]
	public String ProrataLongdescription { get; set; } = String.Empty;
	[JsonPropertyName("isinactive")]
	public Boolean Isinactive { get; set; }

	[JsonPropertyName("period_type")]
	public Int32 PeriodType { get; set; }

	[JsonPropertyName("group_id")]
	public Int32 GroupId { get; set; }

	[JsonPropertyName("isgroupdesc")]
	public Boolean Isgroupdesc { get; set; }

	[JsonPropertyName("kashflow_line_id")]
	public Int32 KashflowLineId { get; set; }

	[JsonPropertyName("_is_calculated_line")]
	public Boolean IsCalculatedLine { get; set; }

	[JsonPropertyName("override_tax_code")]
	public Int32 OverrideTaxCode { get; set; }

	[JsonPropertyName("tax_code_overriden")]
	public Boolean TaxCodeOverriden { get; set; }

	[JsonPropertyName("is_meter")]
	public Boolean IsMeter { get; set; }

	[JsonPropertyName("current_reading")]
	public Int32 CurrentReading { get; set; }

	[JsonPropertyName("last_reading_date")]
	public DateTime LastReadingDate { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("prorata_data")]
	public List<ProrataDatum> ProrataData { get; set; } = [];
	[JsonPropertyName("quantity_users")]
	public List<QuantityUser> QuantityUsers { get; set; } = [];
	[JsonPropertyName("quantity_assets")]
	public List<QuantityAsset> QuantityAssets { get; set; } = [];
	[JsonPropertyName("quantity_licences")]
	public List<QuantityLicence> QuantityLicences { get; set; } = [];
	[JsonPropertyName("quantity_subscriptions")]
	public List<QuantitySubscription> QuantitySubscriptions { get; set; } = [];
	[JsonPropertyName("recurring_invoice_quantity_type")]
	public Int32 RecurringInvoiceQuantityType { get; set; }

	[JsonPropertyName("_warning")]
	public String Warning { get; set; } = String.Empty;
	[JsonPropertyName("tax_name")]
	public String TaxName { get; set; } = String.Empty;
	[JsonPropertyName("_isimport")]
	public Boolean Isimport { get; set; }

	[JsonPropertyName("billingperiod")]
	public Int32 Billingperiod { get; set; }

	[JsonPropertyName("line_periods")]
	public Int32 LinePeriods { get; set; }

	[JsonPropertyName("percent_increase")]
	public Int32 PercentIncrease { get; set; }

	[JsonPropertyName("min_meter_units")]
	public Int32 MinMeterUnits { get; set; }

	[JsonPropertyName("sequenceid")]
	public Int32 Sequenceid { get; set; }

	[JsonPropertyName("startdate")]
	public DateTime Startdate { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("enddate")]
	public DateTime Enddate { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("autorenew")]
	public Boolean Autorenew { get; set; }

	[JsonPropertyName("intacct_location_id")]
	public String IntacctLocationId { get; set; } = String.Empty;
	[JsonPropertyName("intacct_department_id")]
	public String IntacctDepartmentId { get; set; } = String.Empty;
	[JsonPropertyName("synced_to_intacct")]
	public Boolean SyncedToIntacct { get; set; }

	[JsonPropertyName("hideitems")]
	public Boolean Hideitems { get; set; }

	[JsonPropertyName("includegrouppriceandqty")]
	public Boolean Includegrouppriceandqty { get; set; }

	[JsonPropertyName("auto_increase_period")]
	public Int32 AutoIncreasePeriod { get; set; }

	[JsonPropertyName("auto_increase_last_date")]
	public DateTime AutoIncreaseLastDate { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("onetimecharge")]
	public Boolean Onetimecharge { get; set; }

	[JsonPropertyName("onetimechargeinvoiceid")]
	public Int32 Onetimechargeinvoiceid { get; set; }

	[JsonPropertyName("needsreviewbeforecreation")]
	public Boolean Needsreviewbeforecreation { get; set; }

	[JsonPropertyName("reviewed")]
	public Boolean Reviewed { get; set; }

	[JsonPropertyName("metertype")]
	public Int32 Metertype { get; set; }

	[JsonPropertyName("importcsvid")]
	public Int32 Importcsvid { get; set; }

	[JsonPropertyName("client_name")]
	public String ClientName { get; set; } = String.Empty;
	[JsonPropertyName("_importtype")]
	public String Importtype { get; set; } = String.Empty;
	[JsonPropertyName("dbc_id")]
	public String DbcId { get; set; } = String.Empty;
	[JsonPropertyName("purchaseorder_id")]
	public Int32 PurchaseorderId { get; set; }

	[JsonPropertyName("purchaseorder_line_id")]
	public Int32 PurchaseorderLineId { get; set; }

	[JsonPropertyName("baseprice")]
	public Int32 Baseprice { get; set; }

	[JsonPropertyName("discount_perc")]
	public Int32 DiscountPerc { get; set; }

	[JsonPropertyName("exclude_auto_increase")]
	public Boolean ExcludeAutoIncrease { get; set; }

	[JsonPropertyName("createproratanormallines")]
	public Int32 Createproratanormallines { get; set; }

	[JsonPropertyName("pro_rata_line_id")]
	public Int32 ProRataLineId { get; set; }

	[JsonPropertyName("supplier")]
	public Int32 Supplier { get; set; }

	[JsonPropertyName("supplier_name")]
	public String SupplierName { get; set; } = String.Empty;
	[JsonPropertyName("hide_on_pdf")]
	public Boolean HideOnPdf { get; set; }

	[JsonPropertyName("intacct_warehouse_id")]
	public String IntacctWarehouseId { get; set; } = String.Empty;
	[JsonPropertyName("invoice_class")]
	public String InvoiceClass { get; set; } = String.Empty;
	[JsonPropertyName("percent_invoiced")]
	public Int32 PercentInvoiced { get; set; }

	[JsonPropertyName("is_bundled_line")]
	public Boolean IsBundledLine { get; set; }

	[JsonPropertyName("meter_tiers")]
	public List<MeterTier> MeterTiers { get; set; } = [];
	[JsonPropertyName("meter_min_quantity")]
	public Int32 MeterMinQuantity { get; set; }

	[JsonPropertyName("original_client_id")]
	public Int32 OriginalClientId { get; set; }

	[JsonPropertyName("myob_row_version")]
	public String MyobRowVersion { get; set; } = String.Empty;
	[JsonPropertyName("myob_location")]
	public String MyobLocation { get; set; } = String.Empty;
	[JsonPropertyName("myob_row_id")]
	public Int32 MyobRowId { get; set; }

	[JsonPropertyName("dbc_sequence_id")]
	public Int32 DbcSequenceId { get; set; }

	[JsonPropertyName("minimum_line_total")]
	public Int32 MinimumLineTotal { get; set; }

	[JsonPropertyName("hide_grouped_items_price")]
	public Boolean HideGroupedItemsPrice { get; set; }

	[JsonPropertyName("credit_id")]
	public Int32 CreditId { get; set; }

	[JsonPropertyName("taxRuleResult")]
	public List<TaxRuleResult> TaxRuleResult { get; set; } = [];
}
