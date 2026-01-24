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

public class Payment
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("invoice_id")]
    public Int32 InvoiceId { get; set; }

    [JsonPropertyName("date")]
    public DateTime Date { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("amount")]
    public Int32 Amount { get; set; }

    [JsonPropertyName("method")]
    public Int32 Method { get; set; }

    [JsonPropertyName("status")]
    public Int32 Status { get; set; }

    [JsonPropertyName("module_id")]
    public Int32 ModuleId { get; set; }

    [JsonPropertyName("intent_id")]
    public String IntentId { get; set; } = String.Empty;

    [JsonPropertyName("intent_date")]
    public DateTime IntentDate { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("intent_response")]
    public String IntentResponse { get; set; } = String.Empty;

    [JsonPropertyName("webhook_payload")]
    public String WebhookPayload { get; set; } = String.Empty;

    [JsonPropertyName("webhook_received_date")]
    public DateTime WebhookReceivedDate { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("sage50_reference")]
    public String Sage50Reference { get; set; } = String.Empty;

    [JsonPropertyName("thirdpartyid")]
    public String Thirdpartyid { get; set; } = String.Empty;

    [JsonPropertyName("client_id")]
    public Int32 ClientId { get; set; }

    [JsonPropertyName("client_name")]
    public String ClientName { get; set; } = String.Empty;

    [JsonPropertyName("_statuswarning")]
    public String Statuswarning { get; set; } = String.Empty;

    [JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;

    [JsonPropertyName("qbo_id")]
    public Int32 QboId { get; set; }

    [JsonPropertyName("xero_id")]
    public String XeroId { get; set; } = String.Empty;

    [JsonPropertyName("_isimport")]
    public Boolean Isimport { get; set; }

    [JsonPropertyName("_importtype")]
    public String Importtype { get; set; } = String.Empty;

    [JsonPropertyName("sqlimport_id")]
    public Int32 SqlimportId { get; set; }

    [JsonPropertyName("invoice_match_id")]
    public String InvoiceMatchId { get; set; } = String.Empty;
}
