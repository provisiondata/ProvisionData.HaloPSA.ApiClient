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

public class LinkedItem
{
    [JsonPropertyName("asset_type_matching_field_name")]
    public String AssetTypeMatchingFieldName { get; set; } = String.Empty;

    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("use")]
    public String Use { get; set; } = String.Empty;

    [JsonPropertyName("name")]
    public String Name { get; set; } = String.Empty;

    [JsonPropertyName("status")]
    public Int32 Status { get; set; }

    [JsonPropertyName("assetgroup_id")]
    public Int32 AssetgroupId { get; set; }

    [JsonPropertyName("assetgroup_name")]
    public String AssetgroupName { get; set; } = String.Empty;

    [JsonPropertyName("third_party_assetgroup_id")]
    public String ThirdPartyAssetgroupId { get; set; } = String.Empty;

    [JsonPropertyName("note")]
    public String Note { get; set; } = String.Empty;

    [JsonPropertyName("supplier_part_code")]
    public String SupplierPartCode { get; set; } = String.Empty;

    [JsonPropertyName("description")]
    public String Description { get; set; } = String.Empty;

    [JsonPropertyName("purchase_description")]
    public String PurchaseDescription { get; set; } = String.Empty;

    [JsonPropertyName("internalreference")]
    public String Internalreference { get; set; } = String.Empty;

    [JsonPropertyName("externalreference")]
    public String Externalreference { get; set; } = String.Empty;

    [JsonPropertyName("quantity_in_stock")]
    public Int32 QuantityInStock { get; set; }

    [JsonPropertyName("quantity_reserved")]
    public Int32 QuantityReserved { get; set; }

    [JsonPropertyName("quantity_on_order")]
    public Int32 QuantityOnOrder { get; set; }

    [JsonPropertyName("goodsinunit")]
    public String Goodsinunit { get; set; } = String.Empty;

    [JsonPropertyName("goodsoutunit")]
    public String Goodsoutunit { get; set; } = String.Empty;

    [JsonPropertyName("inoutconversion")]
    public Int32 Inoutconversion { get; set; }

    [JsonPropertyName("qtyissuedthisyear")]
    public Int32 Qtyissuedthisyear { get; set; }

    [JsonPropertyName("baseprice")]
    public Int32 Baseprice { get; set; }

    [JsonPropertyName("created_by")]
    public Int32 CreatedBy { get; set; }

    [JsonPropertyName("supplier_id")]
    public Int32 SupplierId { get; set; }

    [JsonPropertyName("supplier_name")]
    public String SupplierName { get; set; } = String.Empty;

    [JsonPropertyName("assettype_id")]
    public Int32 AssettypeId { get; set; }

    [JsonPropertyName("assettype_name")]
    public String AssettypeName { get; set; } = String.Empty;

    [JsonPropertyName("minstockqty")]
    public Int32 Minstockqty { get; set; }

    [JsonPropertyName("min_purchase_qty")]
    public Int32 MinPurchaseQty { get; set; }

    [JsonPropertyName("secondprice")]
    public Int32 Secondprice { get; set; }

    [JsonPropertyName("promptforprice")]
    public Boolean Promptforprice { get; set; }

    [JsonPropertyName("sleeveprice")]
    public Int32 Sleeveprice { get; set; }

    [JsonPropertyName("taxcode")]
    public Int32 Taxcode { get; set; }

    [JsonPropertyName("taxcode_name")]
    public String TaxcodeName { get; set; } = String.Empty;

    [JsonPropertyName("taxcodeother")]
    public Int32 Taxcodeother { get; set; }

    [JsonPropertyName("taxcodeother_name")]
    public String TaxcodeotherName { get; set; } = String.Empty;

    [JsonPropertyName("costprice")]
    public Int32 Costprice { get; set; }

    [JsonPropertyName("accountsid")]
    public String Accountsid { get; set; } = String.Empty;

    [JsonPropertyName("margin")]
    public Int32 Margin { get; set; }

    [JsonPropertyName("reorderqty")]
    public Int32 Reorderqty { get; set; }

    [JsonPropertyName("binlocation")]
    public String Binlocation { get; set; } = String.Empty;

    [JsonPropertyName("nominalcode")]
    public String Nominalcode { get; set; } = String.Empty;

    [JsonPropertyName("costingmethod")]
    public Int32 Costingmethod { get; set; }

    [JsonPropertyName("servicefee")]
    public Int32 Servicefee { get; set; }

    [JsonPropertyName("recovery")]
    public Int32 Recovery { get; set; }

    [JsonPropertyName("avco")]
    public Int32 Avco { get; set; }

    [JsonPropertyName("qtyonallsalesorders")]
    public Int32 Qtyonallsalesorders { get; set; }

    [JsonPropertyName("doesnotneedconsigning")]
    public Boolean Doesnotneedconsigning { get; set; }

    [JsonPropertyName("shaccountsid")]
    public String Shaccountsid { get; set; } = String.Empty;

    [JsonPropertyName("applydiscount")]
    public Boolean Applydiscount { get; set; }

    [JsonPropertyName("secondhandprice")]
    public Int32 Secondhandprice { get; set; }

    [JsonPropertyName("hours")]
    public Int32 Hours { get; set; }

    [JsonPropertyName("markupperc")]
    public Int32 Markupperc { get; set; }

    [JsonPropertyName("metertype")]
    public Int32 Metertype { get; set; }

    [JsonPropertyName("meterlife")]
    public Int32 Meterlife { get; set; }

    [JsonPropertyName("isrecurringitem")]
    public Boolean Isrecurringitem { get; set; }

    [JsonPropertyName("template_id")]
    public Int32 TemplateId { get; set; }

    [JsonPropertyName("template_name")]
    public String TemplateName { get; set; } = String.Empty;

    [JsonPropertyName("recurringprice")]
    public Int32 Recurringprice { get; set; }

    [JsonPropertyName("showmobilescanner")]
    public Boolean Showmobilescanner { get; set; }

    [JsonPropertyName("icon")]
    public String Icon { get; set; } = String.Empty;

    [JsonPropertyName("icon_download_url")]
    public String IconDownloadUrl { get; set; } = String.Empty;

    [JsonPropertyName("customfields")]
    public List<CustomField> Customfields { get; set; } = [];

    [JsonPropertyName("_isimport")]
    public Boolean Isimport { get; set; }

    [JsonPropertyName("_importtype")]
    public String Importtype { get; set; } = String.Empty;

    [JsonPropertyName("group_third_party_id")]
    public String GroupThirdPartyId { get; set; } = String.Empty;

    [JsonPropertyName("sagetoken")]
    public String Sagetoken { get; set; } = String.Empty;

    [JsonPropertyName("third_party_id")]
    public String ThirdPartyId { get; set; } = String.Empty;

    [JsonPropertyName("custombuttons")]
    public List<CustomButton> Custombuttons { get; set; } = [];

    [JsonPropertyName("item_suppliers")]
    public List<ItemSupplier> ItemSuppliers { get; set; } = [];

    [JsonPropertyName("xero_salestax")]
    public String XeroSalestax { get; set; } = String.Empty;

    [JsonPropertyName("xero_purchasetax")]
    public String XeroPurchasetax { get; set; } = String.Empty;

    [JsonPropertyName("purchasenominalcode")]
    public String Purchasenominalcode { get; set; } = String.Empty;

    [JsonPropertyName("fullyqualifiedname")]
    public String Fullyqualifiedname { get; set; } = String.Empty;

    [JsonPropertyName("salestaxincluded")]
    public Boolean Salestaxincluded { get; set; }

    [JsonPropertyName("purchasetaxincluded")]
    public Boolean Purchasetaxincluded { get; set; }

    [JsonPropertyName("taxable")]
    public Boolean Taxable { get; set; }

    [JsonPropertyName("assetaccountcode")]
    public Int32 Assetaccountcode { get; set; }

    [JsonPropertyName("qbo_quantity")]
    public Int32 QboQuantity { get; set; }

    [JsonPropertyName("qboinitial_quantity_date")]
    public DateTime QboinitialQuantityDate { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("stocklocations")]
    public List<StockLocation> Stocklocations { get; set; } = [];

    [JsonPropertyName("xero_tenant_id")]
    public String XeroTenantId { get; set; } = String.Empty;

    [JsonPropertyName("xero_tenant_name")]
    public String XeroTenantName { get; set; } = String.Empty;

    [JsonPropertyName("xerodetails_id")]
    public Int32 XerodetailsId { get; set; }

    [JsonPropertyName("income_account_name")]
    public String IncomeAccountName { get; set; } = String.Empty;

    [JsonPropertyName("expense_account_name")]
    public String ExpenseAccountName { get; set; } = String.Empty;

    [JsonPropertyName("asset_account_name")]
    public String AssetAccountName { get; set; } = String.Empty;

    [JsonPropertyName("income_account")]
    public IncomeAccount IncomeAccount { get; set; } = default!;

    [JsonPropertyName("expense_account")]
    public ExpenseAccount ExpenseAccount { get; set; } = default!;

    [JsonPropertyName("asset_account")]
    public AssetAccount AssetAccount { get; set; } = default!;

    [JsonPropertyName("qbosku")]
    public String Qbosku { get; set; } = String.Empty;

    [JsonPropertyName("qbocategoryid")]
    public String Qbocategoryid { get; set; } = String.Empty;

    [JsonPropertyName("qbocategoryname")]
    public String Qbocategoryname { get; set; } = String.Empty;

    [JsonPropertyName("qbo_category")]
    public QboCategory QboCategory { get; set; } = default!;

    [JsonPropertyName("autotaskserviceid")]
    public Int32 Autotaskserviceid { get; set; }

    [JsonPropertyName("autotaskproductid")]
    public Int32 Autotaskproductid { get; set; }

    [JsonPropertyName("iscontractitem")]
    public Boolean Iscontractitem { get; set; }

    [JsonPropertyName("dontinvoice")]
    public Boolean Dontinvoice { get; set; }

    [JsonPropertyName("kashflowid")]
    public Int32 Kashflowid { get; set; }

    [JsonPropertyName("kashflow_tenant_id")]
    public Int32 KashflowTenantId { get; set; }

    [JsonPropertyName("kashflow_tenant_name")]
    public String KashflowTenantName { get; set; } = String.Empty;

    [JsonPropertyName("nominalcode_name")]
    public String NominalcodeName { get; set; } = String.Empty;

    [JsonPropertyName("purchasenominalcode_name")]
    public String PurchasenominalcodeName { get; set; } = String.Empty;

    [JsonPropertyName("linked_item_id")]
    public Int32 LinkedItemId { get; set; }

    [JsonPropertyName("linked_item_name")]
    public String LinkedItemName { get; set; } = String.Empty;

    [JsonPropertyName("update_recurring_invoice_price")]
    public Boolean UpdateRecurringInvoicePrice { get; set; }

    [JsonPropertyName("update_recurring_invoice_cost")]
    public Boolean UpdateRecurringInvoiceCost { get; set; }

    [JsonPropertyName("snelstart_id")]
    public String SnelstartId { get; set; } = String.Empty;

    [JsonPropertyName("snelstart_department_id")]
    public String SnelstartDepartmentId { get; set; } = String.Empty;

    [JsonPropertyName("snelstart_department_name")]
    public String SnelstartDepartmentName { get; set; } = String.Empty;

    [JsonPropertyName("snelstart_department")]
    public SnelstartDepartment SnelstartDepartment { get; set; } = default!;

    [JsonPropertyName("linked_asset_defaults")]
    public List<LinkedAssetDefault> LinkedAssetDefaults { get; set; } = [];

    [JsonPropertyName("maxitemdiscount")]
    public Int32 Maxitemdiscount { get; set; }

    [JsonPropertyName("item_default_billing_period")]
    public Int32 ItemDefaultBillingPeriod { get; set; }

    [JsonPropertyName("primaryimageid")]
    public Int32 Primaryimageid { get; set; }

    [JsonPropertyName("datecreated")]
    public DateTime Datecreated { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("lastmodified")]
    public DateTime Lastmodified { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("qbo_company_id")]
    public String QboCompanyId { get; set; } = String.Empty;

    [JsonPropertyName("import_details_id")]
    public Int32 ImportDetailsId { get; set; }

    [JsonPropertyName("quickbooks_details")]
    public QuickbooksDetails QuickbooksDetails { get; set; } = default!;

    [JsonPropertyName("qbo_company_name")]
    public String QboCompanyName { get; set; } = String.Empty;

    [JsonPropertyName("extra_invoice_description")]
    public String ExtraInvoiceDescription { get; set; } = String.Empty;

    [JsonPropertyName("isitemdetails")]
    public Boolean Isitemdetails { get; set; }

    [JsonPropertyName("intacct_type")]
    public String IntacctType { get; set; } = String.Empty;

    [JsonPropertyName("item_group_nominalcode")]
    public String ItemGroupNominalcode { get; set; } = String.Empty;

    [JsonPropertyName("item_group_nominalcode_purchase")]
    public String ItemGroupNominalcodePurchase { get; set; } = String.Empty;

    [JsonPropertyName("item_group_itemcode")]
    public Int32 ItemGroupItemcode { get; set; }

    [JsonPropertyName("item_group_taxcode")]
    public Int32 ItemGroupTaxcode { get; set; }

    [JsonPropertyName("item_group_taxcode_purchase")]
    public Int32 ItemGroupTaxcodePurchase { get; set; }

    [JsonPropertyName("recurringcost")]
    public Int32 Recurringcost { get; set; }

    [JsonPropertyName("dbc_company_id")]
    public String DbcCompanyId { get; set; } = String.Empty;

    [JsonPropertyName("dbc_company_name")]
    public String DbcCompanyName { get; set; } = String.Empty;

    [JsonPropertyName("type")]
    public Int32 Type { get; set; }

    [JsonPropertyName("external_links")]
    public List<ExternalLink> ExternalLinks { get; set; } = [];

    [JsonPropertyName("new_external_link")]
    public NewExternalLink NewExternalLink { get; set; } = default!;

    [JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;

    [JsonPropertyName("sage_business_cloud_details_id")]
    public Int32 SageBusinessCloudDetailsId { get; set; }

    [JsonPropertyName("sage_business_cloud_details_name")]
    public String SageBusinessCloudDetailsName { get; set; } = String.Empty;

    [JsonPropertyName("budgettype_id")]
    public Int32 BudgettypeId { get; set; }

    [JsonPropertyName("budgettype_name")]
    public String BudgettypeName { get; set; } = String.Empty;

    [JsonPropertyName("serialise_only_one")]
    public Boolean SerialiseOnlyOne { get; set; }

    [JsonPropertyName("exact_division")]
    public Int32 ExactDivision { get; set; }

    [JsonPropertyName("exact_division_name")]
    public String ExactDivisionName { get; set; } = String.Empty;

    [JsonPropertyName("dattocommerce_tenant")]
    public Int32 DattocommerceTenant { get; set; }

    [JsonPropertyName("user_description")]
    public String UserDescription { get; set; } = String.Empty;

    [JsonPropertyName("weight")]
    public Int32 Weight { get; set; }

    [JsonPropertyName("ignore_from_accounting_sync")]
    public Boolean IgnoreFromAccountingSync { get; set; }

    [JsonPropertyName("invoice_class")]
    public String InvoiceClass { get; set; } = String.Empty;

    [JsonPropertyName("sage50uk_department_id")]
    public Int32 Sage50ukDepartmentId { get; set; }

    [JsonPropertyName("dont_track_stock")]
    public Boolean DontTrackStock { get; set; }

    [JsonPropertyName("xero_inventory_account_code")]
    public String XeroInventoryAccountCode { get; set; } = String.Empty;

    [JsonPropertyName("xero_cogs_account_code")]
    public String XeroCogsAccountCode { get; set; } = String.Empty;

    [JsonPropertyName("xero_inventory_account_code_name")]
    public String XeroInventoryAccountCodeName { get; set; } = String.Empty;

    [JsonPropertyName("xero_cogs_account_code_name")]
    public String XeroCogsAccountCodeName { get; set; } = String.Empty;

    [JsonPropertyName("intacct_product_line_id")]
    public String IntacctProductLineId { get; set; } = String.Empty;

    [JsonPropertyName("_updateitemtype")]
    public Int32 Updateitemtype { get; set; }

    [JsonPropertyName("related_item_count")]
    public Int32 RelatedItemCount { get; set; }

    [JsonPropertyName("myob_tenant")]
    public Int32 MyobTenant { get; set; }

    [JsonPropertyName("myob_tenant_name")]
    public String MyobTenantName { get; set; } = String.Empty;

    [JsonPropertyName("row_version")]
    public String RowVersion { get; set; } = String.Empty;

    [JsonPropertyName("myob_asset_account_code")]
    public String MyobAssetAccountCode { get; set; } = String.Empty;

    [JsonPropertyName("items_per_buying_price")]
    public Int32 ItemsPerBuyingPrice { get; set; }

    [JsonPropertyName("items_per_selling_price")]
    public Int32 ItemsPerSellingPrice { get; set; }
}
