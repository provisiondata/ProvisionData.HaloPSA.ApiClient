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

public partial class FaultItem

{
    [JsonPropertyName("agent_id")]
    public Int32? AgentId { get; set; }

    [JsonPropertyName("assetgroup_name")]
    public String? AssetgroupName { get; set; }

    [JsonPropertyName("asset_id")]
    public Int32? AssetId { get; set; }

    [JsonPropertyName("asset_number")]
    public Int32? AssetNumber { get; set; }

    [JsonPropertyName("asset_site")]
    public Int32? AssetSite { get; set; }

    [JsonPropertyName("assettype_id")]
    public Int32? AssettypeId { get; set; }

    [JsonPropertyName("asset_type_matching_field_name")]
    public String? AssetTypeMatchingFieldName { get; set; }

    [JsonPropertyName("assettype_name")]
    public String? AssettypeName { get; set; }

    [JsonPropertyName("budgettype_id")]
    public Int32? BudgettypeId { get; set; }

    [JsonPropertyName("consignment_ids")]
    public List<Int32?>? ConsignmentIds { get; set; }
    [JsonPropertyName("cost_centre")]
    public Int32? CostCentre { get; set; }

    [JsonPropertyName("costprice")]
    public Double? Costprice { get; set; }

    [JsonPropertyName("date_shipped")]
    public DateTimeOffset? DateShipped { get; set; }

    [JsonPropertyName("dont_track_stock")]
    public Boolean? DontTrackStock { get; set; }

    [JsonPropertyName("from_order_id")]
    public Int32? FromOrderId { get; set; }

    [JsonPropertyName("from_order_line")]
    public Int32? FromOrderLine { get; set; }

    [JsonPropertyName("id")]
    public Int32? Id { get; set; }

    [JsonPropertyName("inventory_number")]
    public String? InventoryNumber { get; set; }

    [JsonPropertyName("item_external_reference")]
    public String? ItemExternalReference { get; set; }

    [JsonPropertyName("item_generic")]
    public Int32? ItemGeneric { get; set; }

    [JsonPropertyName("item_id")]
    public Int32? ItemId { get; set; }

    [JsonPropertyName("item_internal_reference")]
    public String? ItemInternalReference { get; set; }

    [JsonPropertyName("item_recurring")]
    public Boolean? ItemRecurring { get; set; }

    [JsonPropertyName("item_taxable")]
    public Boolean? ItemTaxable { get; set; }

    [JsonPropertyName("item_tax_code")]
    public Int32? ItemTaxCode { get; set; }

    [JsonPropertyName("item_tax_name")]
    public String? ItemTaxName { get; set; }

    [JsonPropertyName("name")]
    public String? Name { get; set; }

    [JsonPropertyName("net_total")]
    public Double? NetTotal { get; set; }

    [JsonPropertyName("note")]
    public String? Note { get; set; }

    [JsonPropertyName("note2")]
    public String? Note2 { get; set; }

    [JsonPropertyName("price")]
    public Double? Price { get; set; }

    [JsonPropertyName("quantity")]
    public Double? Quantity { get; set; }

    [JsonPropertyName("quantity_in_stock")]
    public Double? QuantityInStock { get; set; }

    [JsonPropertyName("quantity_shipped")]
    public Double? QuantityShipped { get; set; }

    [JsonPropertyName("recurringinvoice_id")]
    public Int32? RecurringinvoiceId { get; set; }

    [JsonPropertyName("reserved_assets")]
    public List<DeviceList>? ReservedAssets { get; set; }
    [JsonPropertyName("selected")]
    public Boolean? Selected { get; set; }

    [JsonPropertyName("serialise_only_one")]
    public Boolean? SerialiseOnlyOne { get; set; }

    [JsonPropertyName("status")]
    public String? Status { get; set; }

    [JsonPropertyName("stock_adjusted_already")]
    public Boolean? StockAdjustedAlready { get; set; }

    [JsonPropertyName("stockbin_id")]
    public Int32? StockbinId { get; set; }

    [JsonPropertyName("stocklocation_id")]
    public Int32? StocklocationId { get; set; }

    [JsonPropertyName("stocklocation_name")]
    public String? StocklocationName { get; set; }

    [JsonPropertyName("supplier_name")]
    public String? SupplierName { get; set; }

    [JsonPropertyName("supplier_part_code")]
    public String? SupplierPartCode { get; set; }

    [JsonPropertyName("tax")]
    public Double? Tax { get; set; }

    [JsonPropertyName("ticket_id")]
    public Int32? TicketId { get; set; }

    [JsonPropertyName("total_net_total")]
    public Double? TotalNetTotal { get; set; }

    [JsonPropertyName("total_price")]
    public Double? TotalPrice { get; set; }

    [JsonPropertyName("total_tax")]
    public Double? TotalTax { get; set; }

    [JsonPropertyName("unit")]
    public Int32? Unit { get; set; }

    [JsonPropertyName("_warning")]
    public String? Warning { get; set; }

    [JsonPropertyName("warranty_reported")]
    public Boolean? WarrantyReported { get; set; }
}

