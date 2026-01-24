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

public partial class CreateRecurringInvoiceSchedule(Int64 invoiceId)
{
    [JsonPropertyName("intent")]
    public String Intent { get; set; } = "ADD";

    [JsonPropertyName("invoice_id")]
    public Int64 InvoiceId { get; set; } = invoiceId;

    [JsonPropertyName("period")]
    public required Int64 Period { get; set; }

    [JsonPropertyName("nextcreationdate")]
    public required DateTime NextCreationDate { get; set; }

    [JsonPropertyName("startdate")]
    public required DateTime StartDate { get; set; }

    [JsonPropertyName("lastcreated")]
    public required DateTime LastCreated { get; set; }

    // Properties with Default Values

    [JsonPropertyName("daysplus")]
    public Int64 Daysplus { get; set; }

    [JsonPropertyName("end_date")]
    public DateTime EndDate { get; set; } = new DateTime(2099, 12, 31);

    [JsonPropertyName("type")]
    public Int64 Type { get; set; } = 54;

    [JsonPropertyName("time")]
    public DateTime Time { get; set; } = DateTime.Now.Date.AddHours(9);

    [JsonPropertyName("status_id")]
    public Int64 StatusId { get; set; } = 0;

    [JsonPropertyName("create_on_nonworkdays")]
    public Boolean CreateOnNonWorkDays { get; set; } = true;

    // Optional Properties

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public Int64? Id { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public String? Name { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nextcreationdate_after_end")]
    public DateTime? NextCreationDateAfterEnd { get; set; }

    [JsonPropertyName("pdf")]
    public Boolean Pdf { get; set; }
}
