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

using Dapper;
using Flurl;
using Microsoft.Extensions.Logging;
using ProvisionData.HaloPSA.ApiClient.Models;
using System.Text.Json;

namespace ProvisionData.HaloPSA.ApiClient;

public partial class HaloApiClient
{
	public async Task<IReadOnlyCollection<RecurringInvoice>> ListRecurringInvoicesAsync(CancellationToken cancellationToken = default)
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
			var result = JsonSerializer.Deserialize<GetRecurringInvoicesResult>(json, Options.JsonSerializerOptions)
				?? throw new InvalidOperationException("Failed to deserialize GetRecurringInvoicesResult.");

			return result.Invoices;
		}
		catch (Exception ex)
		{
			Logger.LogError(ex, "GetRecurringInvoicesResult failed.");
			throw;
		}
	}

	public async Task<RecurringInvoice> GetRecurringInvoiceAsync(Int32 recurringinvoiceId, CancellationToken cancellationToken = default)
	{
		var uri = Options.ApiUrl
			.AppendPathSegment("RecurringInvoice")
			.AppendPathSegment(recurringinvoiceId)
			.ToUri();
		var json = await HttpGetAsync(uri, cancellationToken);

		try
		{
			var recurringinvoice = JsonSerializer.Deserialize<RecurringInvoice>(json, Options.JsonSerializerOptions)
				?? throw new InvalidOperationException("Failed to deserialize RecurringInvoice.");

			return recurringinvoice;
		}
		catch (Exception ex)
		{
			Logger.LogError(ex, "Failed to get recurring invoice: {RecurringInvoiceID}", recurringinvoiceId);
			throw;
		}
	}

	public async Task<RecurringInvoice> CreateRecurringInvoiceAsync(CreateRecurringInvoice request, CancellationToken cancellationToken = default)
	{
		var payload = JsonSerializer.Serialize(request, Options.JsonSerializerOptions);

		var invoiceResponse = await HttpPostAsync("RecurringInvoice", $"[{payload}]", cancellationToken);

		Logger.LogTrace("CreateRecurringInvoiceAsync Response: {json}", invoiceResponse);

		var response = JsonSerializer.Deserialize<RecurringInvoice>(invoiceResponse, Options.JsonSerializerOptions)!;

		await CreateRecurringInvoiceSchedule(response, cancellationToken);

		return response;
	}

	public Task UpdateRecurringInvoiceAsync(RecurringInvoice value, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	const String UpdateRecurringScheduleSql = "UPDATE HaloPSA.dbo.STDREQUEST SET STDNextCreationDate=@NextCreationDate WHERE stdid=@Id;";

	public async Task CreateRecurringInvoiceSchedule(RecurringInvoice invoice, CancellationToken cancellationToken = default)
	{
		var schedule = new CreateRecurringInvoiceSchedule(invoice.Id)
		{
			Period = invoice.Schedule.Period,
			LastCreated = invoice.Schedule.LastCreated,
			NextCreationDate = invoice.Schedule.NextCreationDate,
			StartDate = invoice.Schedule.StartDate
		};

		try
		{
			var payload = JsonSerializer.Serialize(schedule, Options.JsonSerializerOptions);
			// STDREQUEST
			var json = await HttpPostAsync("Template", $"[{payload}]", cancellationToken);

			var scheduleResponse = JsonSerializer.Deserialize<CreateRecurringScheduleResponse>(json, Options.JsonSerializerOptions)
				?? throw new InvalidOperationException("Failed to deserialize CreateRecurringScheduleResponse.");

			var poco = new UpdateRecurringScheduleRequest() { Id = scheduleResponse.Id, NextCreationDate = invoice.Schedule.NextCreationDate };
			Logger.LogDebug("CreateRecurringInvoiceSchedule Response: {json}", json);

			var result = await GetDbConnection().ExecuteAsync(UpdateRecurringScheduleSql, new { scheduleResponse.Id, invoice.Schedule.NextCreationDate });
			if (result == 1)
			{
				Logger.LogInformation("Recurring Schedule Updated: {InvoiceID} {ScheduleId}", invoice.Id, scheduleResponse.Id);
			}
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

		public required DateTime NextCreationDate { get; init; }
	}
}
