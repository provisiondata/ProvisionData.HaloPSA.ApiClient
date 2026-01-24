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

public class CreateInvoiceLine
{
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

    [JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;
}
