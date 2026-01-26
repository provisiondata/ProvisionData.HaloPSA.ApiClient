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
            var list = JsonSerializer.Deserialize<AreaView>(json, Options.JsonSerializerOptions)
                ?? throw new InvalidOperationException("Failed to deserialize ListClientsResponse.");

            return list.Clients;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to list Clients.");
            throw;
        }
    }

    public async Task<Area> GetCustomer(Int32 customerId, Boolean includeDetails = false, CancellationToken cancellationToken = default)
    {
        // https://halo.pdsint.net/api/Client/172?includedetails=true
        var clientUri = Options.ApiUrl
            .AppendPathSegment("Client")
            .AppendPathSegment(customerId)
            .AppendQueryParam("includedetails", includeDetails)
            .ToUri();

        var json = await HttpGetAsync(clientUri, cancellationToken);
        Logger.LogTrace("GetCustomer Response: {JSON}", json);

        try
        {
            var area = JsonSerializer.Deserialize<Area>(json, Options.JsonSerializerOptions)
                ?? throw new HaloPsaApiClientException($"Failed to deserialize {nameof(Area)}.", json);

            return area;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to get area: {ClientID}", customerId);
            throw;
        }
    }

    public async Task<Area> GetClientAsync(String name, CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Client")
            .AppendQueryParam("search_name_only", name)
            .ToUri();

        var json = await HttpGetAsync(uri, cancellationToken);

        try
        {
            var client = JsonSerializer.Deserialize<Area>(json, Options.JsonSerializerOptions)
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
