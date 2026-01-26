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
    public async Task<IReadOnlyCollection<InvoiceHeader>> ListRecurringInvoicesAsync(CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("RecurringInvoice")
            .AppendQueryParam("count", 5000)
            .AppendQueryParam("pageinate", false)
            .AppendQueryParam("page_size", 5000)
            .ToUri();
        var json = await HttpGetAsync(uri, cancellationToken);

        Logger.LogDebug("ListRecurringInvoicesAsync Response: {JSON}", json);

        try
        {
            var invoiceHeaders = JsonSerializer.Deserialize<List<InvoiceHeader>>(json, Options.JsonSerializerOptions)
                ?? throw new InvalidOperationException("Failed to deserialize GetRecurringInvoicesResult.");

            return invoiceHeaders;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "GetRecurringInvoicesResult failed.");
            throw;
        }
    }

    public async Task<InvoiceHeader> GetRecurringInvoiceAsync(Int32 recurringinvoiceId, CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("RecurringInvoice")
            .AppendPathSegment(recurringinvoiceId)
            .ToUri();
        var json = await HttpGetAsync(uri, cancellationToken);

        try
        {
            var recurringinvoice = JsonSerializer.Deserialize<InvoiceHeader>(json, Options.JsonSerializerOptions)
                ?? throw new InvalidOperationException("Failed to deserialize RecurringInvoice.");

            return recurringinvoice;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to get recurring invoice: {RecurringInvoiceID}", recurringinvoiceId);
            throw;
        }
    }

    public async Task<InvoiceHeader> CreateRecurringInvoiceAsync(InvoiceHeader request, CancellationToken cancellationToken = default)
    {
        var payload = JsonSerializer.Serialize(request, Options.JsonSerializerOptions);

        var invoiceResponse = await HttpPostAsync("RecurringInvoice", $"[{payload}]", cancellationToken);

        Logger.LogTrace("CreateRecurringInvoiceAsync Response: {json}", invoiceResponse);

        var response = JsonSerializer.Deserialize<InvoiceHeader>(invoiceResponse, Options.JsonSerializerOptions)!;

        await CreateRecurringInvoiceSchedule(response, cancellationToken);

        return response;
    }

    public async Task CreateRecurringInvoiceSchedule(InvoiceHeader invoice, CancellationToken cancellationToken = default)
    {
        var schedule = new StdRequest()
        {
            Id = invoice.Id,
            Period = invoice.Schedule.Period,
            Lastcreated = invoice.Schedule.Lastcreated,
            NextCreationDate = invoice.Schedule.NextCreationDate,
            Startdate = invoice.Schedule.Startdate
        };

        try
        {
            var payload = JsonSerializer.Serialize(schedule, Options.JsonSerializerOptions);
            // STDREQUEST
            var json = await HttpPostAsync("Template", $"[{payload}]", cancellationToken);

            var scheduleResponse = JsonSerializer.Deserialize<StdRequest>(json, Options.JsonSerializerOptions)
                ?? throw new InvalidOperationException($"Failed to deserialize {nameof(StdRequest)}.");

            var poco = new UpdateRecurringScheduleRequest()
            {
                Id = scheduleResponse.Id,
                NextCreationDate = invoice.Schedule.NextCreationDate.Value
            };

            Logger.LogTrace("CreateRecurringInvoiceSchedule Response: {json}", json);
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "CreateRecurringInvoiceSchedule failed.");
            throw;
        }
    }

    public class UpdateRecurringScheduleRequest
    {
        public required Int32 Id { get; init; }

        public required DateTimeOffset NextCreationDate { get; init; }
    }
}
