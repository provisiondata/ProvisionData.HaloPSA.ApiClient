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

public record InvoiceBase
{
	[JsonPropertyName("id")]
	public Int32 Id { get; set; }

	[JsonPropertyName("client_id")]
	public Int32 ClientId { get; set; }

	[JsonPropertyName("sitenumber")]
	public Int32 Sitenumber { get; set; }

	[JsonPropertyName("uid")]
	public Int32 Uid { get; set; }

	[JsonPropertyName("invoicenumber")]
	public String InvoiceNumber { get; set; } = String.Empty;

	[JsonPropertyName("thirdpartyinvoicenumber")]
	public String ThirdPartyInvoiceNumber { get; set; } = String.Empty;

	[JsonPropertyName("posted")]
	public Boolean Posted { get; set; }

	[JsonPropertyName("name")]
	public String Name { get; set; } = String.Empty;

	[JsonPropertyName("address1")]
	public String Address1 { get; set; } = String.Empty;

	[JsonPropertyName("address2")]
	public String Address2 { get; set; } = String.Empty;

	[JsonPropertyName("address3")]
	public String Address3 { get; set; } = String.Empty;

	[JsonPropertyName("address4")]
	public String Address4 { get; set; } = String.Empty;

	[JsonPropertyName("address5")]
	public String Address5 { get; set; } = String.Empty;

	[JsonPropertyName("deladdress1")]
	public String Deladdress1 { get; set; } = String.Empty;

	[JsonPropertyName("deladdress2")]
	public String Deladdress2 { get; set; } = String.Empty;

	[JsonPropertyName("deladdress3")]
	public String Deladdress3 { get; set; } = String.Empty;

	[JsonPropertyName("deladdress4")]
	public String Deladdress4 { get; set; } = String.Empty;

	[JsonPropertyName("deladdress5")]
	public String Deladdress5 { get; set; } = String.Empty;

	[JsonPropertyName("tel_number")]
	public String TelNumber { get; set; } = String.Empty;

	[JsonPropertyName("contactname")]
	public String Contactname { get; set; } = String.Empty;

	[JsonPropertyName("global_tax_code")]
	public String GlobalTaxCode { get; set; } = String.Empty;

	[JsonPropertyName("invoice_date")]
	public DateTime? InvoiceDate { get; set; }

	[JsonPropertyName("dateposted")]
	public DateTime? Dateposted { get; set; }

	[JsonPropertyName("last_synced")]
	public DateTime? LastSynced { get; set; }

	[JsonPropertyName("last_modified")]
	public DateTime? LastModified { get; set; }

	/// <summary>
	/// This is the note under PO Number
	/// </summary>
	[JsonPropertyName("notes_1")]
	public String Notes1 { get; set; } = String.Empty;

	[JsonPropertyName("notes_2")]
	public String Notes2 { get; set; } = String.Empty;

	[JsonPropertyName("notes_3")]
	public String Notes3 { get; set; } = String.Empty;

	[JsonPropertyName("taken_by")]
	public String TakenBy { get; set; } = String.Empty;

	[JsonPropertyName("order_number")]
	public String OrderNumber { get; set; } = String.Empty;

	/// <summary>
	/// PO Number
	/// </summary>
	[JsonPropertyName("cust_order_number")]
	public String CustOrderNumber { get; set; } = String.Empty;

	[JsonPropertyName("payment_ref")]
	public String PaymentRef { get; set; } = String.Empty;

	[JsonPropertyName("global_nom_code")]
	public String GlobalNomCode { get; set; } = String.Empty;

	[JsonPropertyName("global_details")]
	public String GlobalDetails { get; set; } = String.Empty;

	[JsonPropertyName("invoice_type_code")]
	public String InvoiceTypeCode { get; set; } = String.Empty;

	[JsonPropertyName("ohid")]
	public Int32 Ohid { get; set; }

	[JsonPropertyName("datetype")]
	public Int32 Datetype { get; set; }

	[JsonPropertyName("percent")]
	public Decimal Percent { get; set; }

	[JsonPropertyName("type")]
	public Int32 Type { get; set; }

	[JsonPropertyName("chid")]
	public Int32 Chid { get; set; }

	[JsonPropertyName("datesent")]
	public DateTime? Datesent { get; set; }

	[JsonPropertyName("currency")]
	public String Currency { get; set; } = String.Empty;

	[JsonPropertyName("paymentterms")]
	public Int32 PaymentTerms { get; set; }

	[JsonPropertyName("hideinvoice")]
	public Boolean Hideinvoice { get; set; }

	[JsonPropertyName("faultid")]
	public Int32 Faultid { get; set; }

	[JsonPropertyName("invoicetype")]
	public Int32 Invoicetype { get; set; }

	[JsonPropertyName("datepaid")]
	public DateTime? Datepaid { get; set; }

	[JsonPropertyName("paymentstatus")]
	public Int32 PaymentStatus { get; set; }

	[JsonPropertyName("xeroid")]
	public String Xeroid { get; set; } = String.Empty;

	[JsonPropertyName("amountpaid")]
	public Decimal Amountpaid { get; set; }

	[JsonPropertyName("amountdue")]
	public Decimal Amountdue { get; set; }

	[JsonPropertyName("emailstatus")]
	public Int32 Emailstatus { get; set; }

	[JsonPropertyName("address")]
	public Address Address { get; set; } = new Address();

	[JsonPropertyName("lines")]
	public List<CreateInvoiceLine> Lines { get; set; } = [];

	[JsonPropertyName("invoicevalue")]
	public String Invoicevalue { get; set; } = String.Empty;

	[JsonPropertyName("client")]
	public Client Client { get; set; } = new();

	[JsonPropertyName("_warning")]
	public String Warning { get; set; } = String.Empty;
}
