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

public class CreateFromAreaitem
{
	[JsonPropertyName("id")]
	public Int32 Id { get; set; }

	[JsonPropertyName("client_id")]
	public Int32 ClientId { get; set; }

	[JsonPropertyName("item_id")]
	public Int32 ItemId { get; set; }

	[JsonPropertyName("quantity")]
	public Int32 Quantity { get; set; }

	[JsonPropertyName("areaitemdesc")]
    public String Areaitemdesc { get; set; } = String.Empty;
	[JsonPropertyName("billingperiod_id")]
	public Int32 BillingperiodId { get; set; }

	[JsonPropertyName("startdate")]
	public DateTime Startdate { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("invoicenumber")]
    public String Invoicenumber { get; set; } = String.Empty;
	[JsonPropertyName("lastinvoicedate")]
	public DateTime Lastinvoicedate { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("nextinvoicedate")]
	public DateTime Nextinvoicedate { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("autorenew")]
	public Boolean Autorenew { get; set; }

	[JsonPropertyName("note")]
    public String Note { get; set; } = String.Empty;
	[JsonPropertyName("costprice")]
	public Int32 Costprice { get; set; }

	[JsonPropertyName("sellingprice")]
	public Int32 Sellingprice { get; set; }

	[JsonPropertyName("accounts_id")]
    public String AccountsId { get; set; } = String.Empty;
	[JsonPropertyName("numberdayswarning")]
	public Int32 Numberdayswarning { get; set; }

	[JsonPropertyName("dsite")]
	public Int32 Dsite { get; set; }

	[JsonPropertyName("ddevnum")]
	public Int32 Ddevnum { get; set; }

	[JsonPropertyName("technician")]
	public Int32 Technician { get; set; }

	[JsonPropertyName("billingcategory_id")]
	public Int32 BillingcategoryId { get; set; }

	[JsonPropertyName("site_id")]
	public Int32 SiteId { get; set; }

	[JsonPropertyName("dontinvoice")]
	public Boolean Dontinvoice { get; set; }

	[JsonPropertyName("enddate")]
	public DateTime Enddate { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;
}
