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
    /// Lists all faults/tickets from the HaloPSA API.
    /// </summary>
    /// <returns>A collection of tickets.</returns>
    public async Task<IReadOnlyList<Ticket>> ListTicketsAsync()
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Tickets")
            .AppendQueryParam("count", 5000)
            .ToUri();

        var json = await HttpGetAsync(uri);

        try
        {
            var list = JsonSerializer.Deserialize(json, HaloPsaTicketJsonContext.Default.ListTicket)
                ?? throw new HaloPsaApiClientException("Failed to deserialize FaultsList.", json);

            return list;
        }
        catch (Exception ex)
        {
            throw new HaloApiException("Failed to deserialize FaultsList.", json, ex);
        }
    }

    /// <summary>
    /// Creates a new fault/ticket in HaloPSA.
    /// </summary>
    /// <param name="fault">The ticket to create.</param>
    /// <returns>The JSON response from the API.</returns>
    public async Task<String> CreateTicketAsync(Ticket fault)
    {
        ArgumentNullException.ThrowIfNull(fault);

        var uri = Options.ApiUrl
            .AppendPathSegment("Tickets")
            .ToUri();

        var payload = JsonSerializer.Serialize(fault, HaloPsaTicketJsonContext.Default.Ticket);

        var json = await HttpPostAsync(uri, $"[{payload}]");

        Logger.LogDebug("Create Fault Response: {json}", json);

        return json;
    }
}
