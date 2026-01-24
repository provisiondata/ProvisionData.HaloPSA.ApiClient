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



public partial class ItemStock

{
	[JsonPropertyName("cost")]
	public Double? Cost { get; set; }
	[JsonPropertyName("date")]
	public DateTimeOffset? Date { get; set; }
	[JsonPropertyName("delivering_to_user")]
	public Boolean? DeliveringToUser { get; set; }
	[JsonPropertyName("dont_track_stock")]
	public Boolean? DontTrackStock { get; set; }
	[JsonPropertyName("id")]
	public Int32? Id { get; set; }
	[JsonPropertyName("_isimport")]
	public Boolean? Isimport { get; set; }
	[JsonPropertyName("is_stock_take")]
	public Boolean? IsStockTake { get; set; }
	[JsonPropertyName("item_assettype_id")]
	public Int32? ItemAssettypeId { get; set; }
	[JsonPropertyName("item_id")]
	public Int32? ItemId { get; set; }
	[JsonPropertyName("item_name")]

	public String? ItemName { get; set; }

	[JsonPropertyName("line_site_id")]
	public Int32? LineSiteId { get; set; }
	[JsonPropertyName("note")]

	public String? Note { get; set; }

	[JsonPropertyName("purchaseorder_id")]
	public Int32? PurchaseorderId { get; set; }
	[JsonPropertyName("purchaseorder_line_id")]
	public Int32? PurchaseorderLineId { get; set; }
	[JsonPropertyName("purchaseorder_ref")]

	public String? PurchaseorderRef { get; set; }

	[JsonPropertyName("quantity_in")]
	public Double? QuantityIn { get; set; }
	[JsonPropertyName("quantity_issued")]
	public Double? QuantityIssued { get; private set; }
	[JsonPropertyName("quantity_remaining")]
	public Double? QuantityRemaining { get; set; }
	[JsonPropertyName("real_quantity_in")]
	public Double? RealQuantityIn { get; set; }
	[JsonPropertyName("salesorder_id")]
	public Int32? SalesorderId { get; set; }
	[JsonPropertyName("serialised_asset_count")]
	public Int32? SerialisedAssetCount { get; set; }
	[JsonPropertyName("serialised_assets")]

	public List<Device_List>? SerialisedAssets { get; set; }

	[JsonPropertyName("serialised_assets_in_stock")]
	public Int32? SerialisedAssetsInStock { get; set; }
	[JsonPropertyName("serialise_only_one")]
	public Boolean? SerialiseOnlyOne { get; set; }
	[JsonPropertyName("stockbin_id")]
	public Int32? StockbinId { get; set; }
	[JsonPropertyName("stockbin_name")]

	public String? StockbinName { get; set; }

	[JsonPropertyName("stocklocation_id")]
	public Int32? StocklocationId { get; set; }
	[JsonPropertyName("stocklocation_name")]

	public String? StocklocationName { get; set; }

	[JsonPropertyName("supplier_id")]
	public Int32? SupplierId { get; set; }
	[JsonPropertyName("supplier_name")]

	public String? SupplierName { get; set; }

	[JsonPropertyName("ticket_id")]
	public Int32? TicketId { get; set; }
	[JsonPropertyName("_warning")]

	public String? Warning { get; set; }
}

