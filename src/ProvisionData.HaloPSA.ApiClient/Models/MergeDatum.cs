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

public class MergeDatum
{
	[JsonPropertyName("id")]
	public Int32 Id { get; set; }

	[JsonPropertyName("invoice_id")]
	public Int32 InvoiceId { get; set; }

	[JsonPropertyName("recurring_invoice_id")]
	public Int32 RecurringInvoiceId { get; set; }

	[JsonPropertyName("schedule_id")]
	public Int32 ScheduleId { get; set; }

	[JsonPropertyName("schedule_date")]
	public DateTime ScheduleDate { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("contract_id")]
	public Int32 ContractId { get; set; }

	[JsonPropertyName("contract_ref")]
    public String ContractRef { get; set; } = String.Empty;
	[JsonPropertyName("salesorder_id")]
	public Int32 SalesorderId { get; set; }

	[JsonPropertyName("percent")]
	public Int32 Percent { get; set; }

	[JsonPropertyName("due_date")]
	public DateTime DueDate { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;
}
