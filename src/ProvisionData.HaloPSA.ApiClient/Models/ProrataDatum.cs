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

public class ProrataDatum
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("invoicedetailid")]
    public Int32 Invoicedetailid { get; set; }

    [JsonPropertyName("date")]
    public DateTime Date { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("quantity")]
    public Int32 Quantity { get; set; }

    [JsonPropertyName("unitprice")]
    public Int32 Unitprice { get; set; }

    [JsonPropertyName("unitcost")]
    public Int32 Unitcost { get; set; }

    [JsonPropertyName("shortdescription")]
    public String Shortdescription { get; set; } = String.Empty;

    [JsonPropertyName("longdescription")]
    public String Longdescription { get; set; } = String.Empty;

    [JsonPropertyName("quantity_id")]
    public Int32 QuantityId { get; set; }

    [JsonPropertyName("user_id")]
    public Int32 UserId { get; set; }

    [JsonPropertyName("device_id")]
    public Int32 DeviceId { get; set; }

    [JsonPropertyName("prorata_next_invoice")]
    public Boolean ProrataNextInvoice { get; set; }

    [JsonPropertyName("invoiceheaderid")]
    public Int32 Invoiceheaderid { get; set; }

    [JsonPropertyName("dont_auto_calculate")]
    public Boolean DontAutoCalculate { get; set; }

    [JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;

    [JsonPropertyName("isinvoiced")]
    public Boolean Isinvoiced { get; set; }

    [JsonPropertyName("isfuturepr")]
    public Boolean Isfuturepr { get; set; }

    [JsonPropertyName("inv_manual_pr_immediately")]
    public Boolean InvManualPrImmediately { get; set; }

    [JsonPropertyName("change_id")]
    public Int32 ChangeId { get; set; }

    [JsonPropertyName("istempprorata")]
    public Boolean Istempprorata { get; set; }
}
