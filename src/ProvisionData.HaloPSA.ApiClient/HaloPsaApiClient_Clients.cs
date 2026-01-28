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
    /// Lists all clients from the HaloPSA API.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A collection of area list items representing clients.</returns>
    public async Task<IEnumerable<AreaList>?> ListClientsAsync(CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Client")
            .AppendQueryParam("count", 5000)
            .ToUri();
        var json = await HttpGetAsync(uri, cancellationToken);
        Logger.LogTrace("ListClientsAsync Response: {JSON}", json);

        try
        {
            var list = JsonSerializer.Deserialize(json, HaloPsaApiJsonSerializerContext.Default.AreaView)
                ?? throw new InvalidOperationException("Failed to deserialize ListClientsResponse.");

            return list.Clients;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to list Clients.");
            throw;
        }
    }

    /// <summary>
    /// Gets a customer by ID.
    /// </summary>
    /// <param name="customerId">The customer ID.</param>
    /// <param name="includeDetails">Whether to include detailed information.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The area representing the customer.</returns>
    public async Task<Area> GetCustomerAsync(Int32 customerId, Boolean includeDetails = false, CancellationToken cancellationToken = default)
    {
        // https://halo.pdsint.net/api/Client/172?includedetails=true
        var clientUri = Options.ApiUrl
            .AppendPathSegment("Client")
            .AppendPathSegment(customerId)
            .AppendQueryParam("includedetails", includeDetails)
            .ToUri();

        var json = await HttpGetAsync(clientUri, cancellationToken);
        Logger.LogTrace("GetCustomerAsync Response: {JSON}", json);

        try
        {
            var area = JsonSerializer.Deserialize(json, HaloPsaApiJsonSerializerContext.Default.Area)
                ?? throw new HaloPsaApiClientException($"Failed to deserialize {nameof(Area)}.", json);

            return area;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to get area: {ClientID}", customerId);
            throw;
        }
    }

    /// <summary>
    /// Gets a client by name.
    /// </summary>
    /// <param name="name">The client name to search for.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The area representing the client.</returns>
    public async Task<Area> GetClientAsync(String name, CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Client")
            .AppendQueryParam("search_name_only", name)
            .ToUri();

        var json = await HttpGetAsync(uri, cancellationToken);

        try
        {
            var client = JsonSerializer.Deserialize(json, HaloPsaApiJsonSerializerContext.Default.Area)
                ?? throw new InvalidOperationException($"Failed to deserialize {nameof(Area)}.");

            return client;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to get area: {Name}", name);
            throw;
        }
    }
}
