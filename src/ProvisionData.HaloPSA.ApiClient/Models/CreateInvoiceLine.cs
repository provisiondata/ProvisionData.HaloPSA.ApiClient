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

public class CreateInvoiceLine
{
	//[JsonPropertyName("id")]
	//public Int32 Id { get; set; }

	[JsonPropertyName("_itemid")]
	public Int32 Itemid { get; set; }

	[JsonPropertyName("productnumber")]
	public String Productnumber { get; set; } = String.Empty;

	[JsonPropertyName("item_code")]
	public required String ItemCode { get; set; } = String.Empty;

	[JsonPropertyName("comment_1")]
	public String Notes { get; set; } = String.Empty;

	[JsonPropertyName("comment_2")]
	public String Comment2 { get; set; } = String.Empty;

	// Description
	[JsonPropertyName("item_shortdescription")]
	public String ItemShortdescription { get; set; } = String.Empty;

	[JsonPropertyName("item_longdescription")]
	public String ItemLongdescription { get; set; } = String.Empty;

	// Bookkeeping
	[JsonPropertyName("nominal_code")]
	public required String NominalCode { get; set; } = String.Empty;

	// Pricing
	[JsonPropertyName("qty_order")]
	public Decimal QtyOrder { get; set; }

	[JsonPropertyName("unit_cost")]
	public Decimal UnitCost { get; set; }

	[JsonPropertyName("unit_price")]
	public Decimal UnitPrice { get; set; }

	[JsonPropertyName("net_amount")]
	public Decimal NetAmount { get; set; }

	[JsonPropertyName("item_tax_code")]
	public Int32 ItemTaxCode { get; set; }

	[JsonPropertyName("tax_code")]
	public String TaxCode { get; set; } = String.Empty;

	[JsonPropertyName("tax_amount")]
	public Decimal TaxAmount { get; set; }

	[JsonPropertyName("tax_rate")]
	public Decimal TaxRate { get; set; }

	//[JsonPropertyName("net_total")]
	//public Decimal NetTotal { get; set; }

	//[JsonPropertyName("total_tax")]
	//public Decimal TotalTax { get; set; }

	//[JsonPropertyName("total_discount")]
	//public Decimal TotalDiscount { get; set; }

	//[JsonPropertyName("total_price")]
	//public Decimal TotalPrice { get; set; }

	//// Meta
	//[JsonPropertyName("ihid")]
	//public Int32 Ihid { get; set; }

	//[JsonPropertyName("item_internal_reference")]
	//public String ItemInternalReference { get; set; } = String.Empty;

	//[JsonPropertyName("item_external_reference")]
	//public String ItemExternalReference { get; set; } = String.Empty;

	//[JsonPropertyName("itemonorder")]
	//public Boolean Itemonorder { get; set; }

	//[JsonPropertyName("dsite")]
	//public Int32 Dsite { get; set; }

	//[JsonPropertyName("ddevnum")]
	//public Int32 Ddevnum { get; set; }

	//[JsonPropertyName("did")]
	//public Int32 Did { get; set; }

	//[JsonPropertyName("chid")]
	//public Int32 Chid { get; set; }

	//[JsonPropertyName("actioncode")]
	//public Int32 Actioncode { get; set; }

	//[JsonPropertyName("site")]
	//public Int32 Site { get; set; }

	//[JsonPropertyName("dmid")]
	//public Int32 Dmid { get; set; }

	//[JsonPropertyName("faultid")]
	//public Int32 Faultid { get; set; }

	//[JsonPropertyName("lineactiondate")]
	//public DateTime Lineactiondate { get; set; } = DateTime.UnixEpoch;

	//[JsonPropertyName("labourdepartmentid")]
	//public Int32 Labourdepartmentid { get; set; }

	//[JsonPropertyName("olid")]
	//public Int32 Olid { get; set; }

	//[JsonPropertyName("olseq")]
	//public Int32 Olseq { get; set; }

	[JsonPropertyName("_warning")]
	public String Warning { get; set; } = String.Empty;
}
