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

using Flurl;
using Microsoft.Extensions.Logging;
using ProvisionData.HaloPSA.ApiClient.Models;
using System.Text.Json;

namespace ProvisionData.HaloPSA.ApiClient;

public partial class HaloPsaApiClient
{
    /// <summary>
    /// Lists all  invoices from the HaloPSA API.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A collection of invoice headers.</returns>
    public async Task<IReadOnlyCollection<InvoiceHeader>> ListInvoicesAsync(CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Invoice")
            .AppendQueryParam("count", 5000)
            .AppendQueryParam("pageinate", false)
            .AppendQueryParam("page_size", 5000)
            .ToUri();
        var json = await HttpGetAsync(uri, cancellationToken);

        Logger.LogDebug("ListInvoicesAsync Response: {JSON}", json);

        try
        {
            var invoiceHeaders = JsonSerializer.Deserialize(json, HaloPsaInvoiceJsonContext.Default.ListInvoiceHeader)
                ?? throw new HaloPsaApiClientException("Failed to deserialize GetInvoicesResult.", json);

            return invoiceHeaders;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "GetInvoicesResult failed.");
            throw;
        }
    }

    /// <summary>
    /// Gets a specific  invoice by ID.
    /// </summary>
    /// <param name="invoiceId">The  invoice ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The invoice header.</returns>
    public async Task<InvoiceHeader> GetInvoiceAsync(Int32 invoiceId, Boolean includedetails = true, CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Invoice")
            .AppendPathSegment(invoiceId)
            .AppendQueryParam("includedetails", includedetails)
            .ToUri();

        var json = await HttpGetAsync(uri, cancellationToken);

        try
        {
            var invoice = JsonSerializer.Deserialize(json, HaloPsaInvoiceJsonContext.Default.InvoiceHeader)
                ?? throw new HaloPsaApiClientException("Failed to deserialize Invoice.", json);

            return invoice;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to get  invoice: {InvoiceID}", invoiceId);
            throw;
        }
    }
}
