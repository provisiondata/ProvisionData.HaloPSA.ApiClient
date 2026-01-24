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

using System.ComponentModel.DataAnnotations;

namespace ProvisionData.HaloPSA.ApiClient.Models;

public abstract record ItemBase
{
    public override String ToString()
    {
        return $"[{Id}] {Name} ({SupplierPartCode}) <{IncomeAccount}> {SupplierName} {AssetGroup}".Trim();
    }

    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("use")]
    public String Use { get; set; } = "item";

    [JsonPropertyName("type")]
    public Int32 Type { get; set; }

    [JsonPropertyName("name")]
    public required String Name { get; set; }

    [JsonPropertyName("status")]
    public Int32 Status { get; set; } = 14;

    [JsonPropertyName("assetgroup_id")]
    public AssetGroup AssetGroup { get; set; } = AssetGroup.NonSerialized;
    [JsonPropertyName("assetgroup_name")]
    public String AssetgroupName { get; set; } = "Non-Serialized";

    [JsonPropertyName("note")]
    public String Note { get; set; } = String.Empty;

    [JsonPropertyName("supplier_part_code")]
    [Display(Name = "Manufacturer SKU")]
    public String SupplierPartCode { get; set; } = String.Empty;

    [JsonPropertyName("description")]
    public String Description { get; set; } = String.Empty;

    [JsonPropertyName("quantity_in_stock")]
    public Decimal QuantityInStock { get; set; }

    [JsonPropertyName("quantity_on_order")]
    public Decimal QuantityOnOrder { get; set; }

    [JsonPropertyName("baseprice")]
    public Decimal BasePrice { get; set; }

    [JsonPropertyName("created_by")]
    public Int32? CreatedBy { get; set; }

    [JsonPropertyName("supplier_id")]
    public Int32? SupplierId { get; set; }

    [JsonPropertyName("supplier_name")]
    public String SupplierName { get; set; } = String.Empty;

    [JsonPropertyName("assettype_id")]
    public Int32? AssettypeId { get; set; }

    [JsonPropertyName("assettype_name")]
    public String AssettypeName { get; set; } = String.Empty;

    [JsonPropertyName("min_purchase_qty")]
    public Decimal? MinPurchaseQty { get; set; }

    [JsonPropertyName("promptforprice")]
    public Boolean? Promptforprice { get; set; }

    [JsonPropertyName("taxcode")]
    public Int32 Taxcode { get; set; } = 3;
    [JsonPropertyName("taxcode_name")]
    public String TaxcodeName { get; set; } = "GP";

    [JsonPropertyName("taxcodeother")]
    public Int32? Taxcodeother { get; set; }

    [JsonPropertyName("costprice")]
    public Decimal CostPrice { get; set; }

    [JsonPropertyName("nominalcode")]
    public String NominalCode { get; set; } = "4192";
    [JsonPropertyName("nominalcode_name")]
    public String NominalcodeName { get; set; } = "Hardware";

    [JsonPropertyName("costingmethod")]
    public Int32? Costingmethod { get; set; }

    [JsonPropertyName("doesnotneedconsigning")]
    public Boolean? Doesnotneedconsigning { get; set; }

    [JsonPropertyName("markupperc")]
    public Decimal MarkUpPerC { get; set; }

    [JsonPropertyName("isrecurringitem")]
    public Boolean IsRecurring { get; set; }
    [JsonPropertyName("recurringprice")]
    public Decimal RecurringPrice { get; set; }

    [JsonPropertyName("template_id")]
    public Int32? TemplateId { get; set; }

    [JsonPropertyName("purchasenominalcode")]
    public String PurchaseNominalCode { get; set; } = String.Empty;

    [JsonPropertyName("salestaxincluded")]
    public Boolean? SalesTaxIncluded { get; set; }

    [JsonPropertyName("purchasetaxincluded")]
    public Boolean? PurchaseTaxIncluded { get; set; }

    [JsonPropertyName("item_suppliers")]
    public List<ItemSupplier> ItemSuppliers { get; set; } = [];

    [JsonPropertyName("taxable")]
    public Boolean Taxable { get; set; } = true;

    [JsonPropertyName("asset_account")]
    public AssetAccount? AssetAccount { get; set; }

    [JsonPropertyName("expense_account")]
    public ExpenseAccount? ExpenseAccount { get; set; }

    [JsonPropertyName("income_account")]
    public IncomeAccount? IncomeAccount { get; set; } = new IncomeAccount { Value = "4000", Label = "Sales" };

    [JsonPropertyName("accountsid")]
    public String? AccountId { get; set; }

    [JsonPropertyName("maxitemdiscount")]
    public Decimal MaxItemDiscount { get; set; }

    [JsonPropertyName("item_default_billing_period")]
    public Int32? ItemDefaultBillingPeriod { get; set; }

    [JsonPropertyName("datecreated")]
    public DateTime? DateCreated { get; set; }

    [JsonPropertyName("lastmodified")]
    public DateTime? LastModified { get; set; }

    [JsonPropertyName("item_group_nominalcode")]
    public String ItemGroupNominalCode { get; set; } = String.Empty;

    [JsonPropertyName("item_group_nominalcode_purchase")]
    public String ItemGroupNominalCodePurchase { get; set; } = String.Empty;

    [JsonPropertyName("user_description")]
    public String UserDescription { get; set; } = String.Empty;

    [JsonPropertyName("weight")]
    public Decimal? Weight { get; set; }
}
