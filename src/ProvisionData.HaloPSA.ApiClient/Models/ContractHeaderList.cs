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

public class ContractHeaderList
{
	[JsonPropertyName("accounts_override_mailbox")]
	public Int32? AccountsOverrideMailbox { get; set; }
	[JsonPropertyName("active")]
	public Boolean? Active { get; set; }
	[JsonPropertyName("asset_end_date")]
	public DateTimeOffset? AssetEndDate { get; set; }
	[JsonPropertyName("asset_sequence")]
	public Int32? AssetSequence { get; set; }
	[JsonPropertyName("asset_value")]
	public Double? AssetValue { get; set; }
	[JsonPropertyName("billingcategory")]
	public Int32? Billingcategory { get; set; }
	[JsonPropertyName("billingdescription")]
	public Int32? Billingdescription { get; set; }
	[JsonPropertyName("billingperiod")]
	public Int32? Billingperiod { get; set; }
	[JsonPropertyName("client_id")]
	public Int32? ClientId { get; set; }
	[JsonPropertyName("client_name")]
	public String? ClientName { get; set; }
	[JsonPropertyName("contract_status")]
	public String? ContractStatus { get; set; }
	[JsonPropertyName("contracttype")]
	public Int32? Contracttype { get; set; }
	[JsonPropertyName("contracttype_name")]
	public String? ContracttypeName { get; set; }
	[JsonPropertyName("cost_calculation")]
	public String? CostCalculation { get; set; }
	[JsonPropertyName("createdby_id")]
	public Int32? CreatedbyId { get; set; }
	[JsonPropertyName("createdby_name")]
	public String? CreatedbyName { get; set; }
	[JsonPropertyName("customfields")]
	public List<CustomField>? Customfields { get; set; }
	[JsonPropertyName("end_date")]
	public DateTimeOffset? EndDate { get; set; }
	[JsonPropertyName("expired")]
	public Boolean? Expired { get; set; }
	[JsonPropertyName("force_recalculation")]
	public Boolean? ForceRecalculation { get; set; }
	[JsonPropertyName("id")]
	public Int32? Id { get; set; }
	[JsonPropertyName("import_details_id")]
	public Int32? ImportDetailsId { get; set; }
	[JsonPropertyName("_importthirdpartyid")]
	public String? Importthirdpartyid { get; set; }
	[JsonPropertyName("_importtype")]
	public String? Importtype { get; set; }
	[JsonPropertyName("_importtypeid")]
	public Int32? Importtypeid { get; set; }
	[JsonPropertyName("_isupdateimport")]
	public Boolean? Isupdateimport { get; set; }
	[JsonPropertyName("key")]
	public Int32? Key { get; set; }
	[JsonPropertyName("last_modified")]
	public DateTimeOffset? LastModified { get; set; }
	[JsonPropertyName("new_external_link")]
	public ExternalLinkList? NewExternalLink { get; set; }
	[JsonPropertyName("next_call_date")]
	public DateTimeOffset? NextCallDate { get; set; }
	[JsonPropertyName("next_invoice_date")]
	public DateTimeOffset? NextInvoiceDate { get; set; }
	[JsonPropertyName("note")]
	public String? Note { get; set; }
	[JsonPropertyName("numberofunitsfree")]
	public Double? Numberofunitsfree { get; set; }
	[JsonPropertyName("periodchargeamount")]
	public Double? Periodchargeamount { get; set; }
	[JsonPropertyName("periodicinvoicenextdate")]
	public DateTimeOffset? Periodicinvoicenextdate { get; set; }
	[JsonPropertyName("prepayrecurringchargebp")]
	public Int32? Prepayrecurringchargebp { get; set; }
	[JsonPropertyName("ref")]
	public String? Ref { get; set; }
	[JsonPropertyName("refextra")]
	public String? Refextra { get; set; }
	[JsonPropertyName("refextra2")]
	public String? Refextra2 { get; set; }
	[JsonPropertyName("sent_to_oracle")]
	public Boolean? SentToOracle { get; set; }
	[JsonPropertyName("site_id")]
	public Int32? SiteId { get; set; }
	[JsonPropertyName("site_name")]
	public String? SiteName { get; set; }
	[JsonPropertyName("sla_id")]
	public Int32? SlaId { get; set; }
	[JsonPropertyName("start_date")]
	public DateTimeOffset? StartDate { get; set; }
	[JsonPropertyName("started")]
	public Boolean? Started { get; set; }
	[JsonPropertyName("status")]
	public Int32? Status { get; set; }
	[JsonPropertyName("subtype")]
	public Int32? Subtype { get; set; }

	//[JsonPropertyName("table")]
	//public UntypedNode? Table { get; set; }

	[JsonPropertyName("use")]
	public String? Use { get; set; }
	[JsonPropertyName("user_id")]
	public Int32? UserId { get; set; }
	[JsonPropertyName("user_name")]
	public String? UserName { get; set; }
}
