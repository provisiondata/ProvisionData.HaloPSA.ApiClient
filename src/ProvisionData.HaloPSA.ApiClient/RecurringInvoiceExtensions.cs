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
using System.Text.Json;

namespace ProvisionData.HaloPSA;

public static class RecurringInvoiceExtensions
{
    /// <summary>
    /// Lists all recurring invoices from the HaloPSA API.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A collection of invoice headers.</returns>
    public static async Task<IReadOnlyCollection<InvoiceHeader>> ListRecurringInvoicesAsync(this ApiClient haloApiClient, CancellationToken cancellationToken = default)
    {
        var uri = "RecurringInvoice"
            .AppendQueryParam("count", 200)
            .AppendQueryParam("pageinate", false)
            .AppendQueryParam("page_size", 5000)
            .ToUri();

        var result = await haloApiClient.HttpGetAsync(uri, InvoiceJsonContext.Default.ListInvoiceHeader, cancellationToken);

        return result;
    }

    /// <summary>
    /// Gets a specific recurring invoice by ID.
    /// </summary>
    /// <param name="recurringinvoiceId">The recurring invoice ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The invoice header.</returns>
    public static async Task<InvoiceHeader> GetRecurringInvoiceAsync(this ApiClient haloApiClient, Int32 recurringinvoiceId, CancellationToken cancellationToken = default)
    {
        var uri = "RecurringInvoice"
            .AppendPathSegment(recurringinvoiceId)
            .ToUri();
        var result = await haloApiClient.HttpGetAsync(uri, InvoiceJsonContext.Default.InvoiceHeader, cancellationToken);

        return result;
    }

    /// <summary>
    /// Creates a new recurring invoice in HaloPSA.
    /// </summary>
    /// <param name="request">The invoice header to create.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The created invoice header.</returns>
    public static async Task<InvoiceHeader> CreateRecurringInvoiceAsync(this ApiClient haloApiClient, InvoiceHeader request, CancellationToken cancellationToken = default)
    {
        var uri = new Uri("RecurringInvoice");

        var payload = JsonSerializer.Serialize(request, InvoiceJsonContext.Default.InvoiceHeader);

        var result = await haloApiClient.HttpPostAsync(uri, $"[{payload}]", InvoiceJsonContext.Default.InvoiceHeader, cancellationToken);

        await CreateRecurringInvoiceScheduleAsync(haloApiClient, result, cancellationToken);

        return result;
    }

    /// <summary>
    /// Creates the schedule for a recurring invoice.
    /// </summary>
    /// <param name="invoice">The invoice header to create the schedule for.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    public static async Task CreateRecurringInvoiceScheduleAsync(this ApiClient haloApiClient, InvoiceHeader invoice, CancellationToken cancellationToken = default)
    {
        var schedule = new StdRequest()
        {
            Id = invoice.Id,
            Period = invoice.Schedule.Period,
            Lastcreated = invoice.Schedule.Lastcreated,
            NextCreationDate = invoice.Schedule.NextCreationDate,
            Startdate = invoice.Schedule.Startdate
        };

        var uri = new Uri("Template");

        var payload = JsonSerializer.Serialize(schedule, InvoiceJsonContext.Default.StdRequest);

        var result = await haloApiClient.HttpPostAsync(uri, $"[{payload}]", InvoiceJsonContext.Default.StdRequest, cancellationToken);
    }
}
