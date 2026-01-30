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
    /// <returns>A collection of <see cref="CustomerView"/> representing clients.</returns>
    public async Task<IEnumerable<CustomerView>?> ListCustomersAsync(CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Client")
            .AppendQueryParam("count", 5000)
            .ToUri();
        var json = await HttpGetAsync(uri, cancellationToken);
        Logger.LogTrace("ListCustomersAsync Response: {JSON}", json);

        try
        {
            var list = JsonSerializer.Deserialize(json, HaloPsaCustomerJsonContext.Default.CustomerView)
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
    /// <returns>The customer representing the customer.</returns>
    public async Task<Customer> GetCustomerAsync(Int32 customerId, Boolean includeDetails = false, CancellationToken cancellationToken = default)
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
            var customer = JsonSerializer.Deserialize(json, HaloPsaCustomerJsonContext.Default.Customer)
                ?? throw new HaloPsaApiClientException($"Failed to deserialize {nameof(Customer)}.", json);

            return customer;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to get customer: {ClientID}", customerId);
            throw;
        }
    }

    /// <summary>
    /// Gets a client by name.
    /// </summary>
    /// <param name="name">The client name to search for.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The customer representing the client.</returns>
    public async Task<Customer> GetCustomerAsync(String name, CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Client")
            .AppendQueryParam("search_name_only", name)
            .ToUri();

        var json = await HttpGetAsync(uri, cancellationToken);

        try
        {
            var client = JsonSerializer.Deserialize(json, HaloPsaCustomerJsonContext.Default.Customer)
                ?? throw new HaloPsaApiClientException($"Failed to deserialize {nameof(Customer)}.", json);

            return client;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to get customer: {Name}", name);
            throw;
        }
    }
}
