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
using ProvisionData.HaloPSA.Contexts;
using ProvisionData.HaloPSA.DTO;

namespace ProvisionData.HaloPSA;

public static class InvoiceExtensions
{
    /// <summary>
    /// Lists all  invoices from the HaloPSA API.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A collection of invoice headers.</returns>
    public static async Task<IReadOnlyCollection<InvoiceHeader>> ListInvoicesAsync(this ApiClient haloApiClient, CancellationToken cancellationToken = default)
    {
        var uri = "Invoice"
            .AppendQueryParam("count", 200)
            .AppendQueryParam("pageinate", false)
            .AppendQueryParam("page_size", 5000)
            .ToUri();

        var result = await haloApiClient.HttpGetAsync(uri, InvoiceJsonContext.Default.ListInvoiceHeader, cancellationToken);

        return result;
    }

    /// <summary>
    /// Gets a specific  invoice by ID.
    /// </summary>
    /// <param name="invoiceId">The  invoice ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The invoice header.</returns>
    public static async Task<InvoiceHeader> GetInvoiceAsync(this ApiClient haloApiClient, Int32 invoiceId, Boolean includedetails = true, CancellationToken cancellationToken = default)
    {
        var uri = "Invoice"
            .AppendPathSegment(invoiceId)
            .AppendQueryParam("includedetails", includedetails)
            .ToUri();

        var result = await haloApiClient.HttpGetAsync(uri, InvoiceJsonContext.Default.InvoiceHeader, cancellationToken);

        return result;
    }
}
