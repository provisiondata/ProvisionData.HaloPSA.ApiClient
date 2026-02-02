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

public static class CustomerExtensions
{
    /// <summary>
    /// Lists all clients from the HaloPSA API.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A collection of <see cref="CustomerView"/> representing clients.</returns>
    public static async Task<CustomerList?> ListCustomersAsync(this ApiClient haloApiClient, CancellationToken cancellationToken = default)
    {
        var uri = "Client"
            .AppendQueryParam("count", 200)
            .ToUri();

        var json = await haloApiClient.HttpGetAsync(uri, cancellationToken);

        var list = JsonSerializer.Deserialize(json, CustomerJsonContext.Default.CustomerList)
            ?? throw new InvalidOperationException("Failed to deserialize ListClientsResponse.");

        return list;
    }

    /// <summary>
    /// Gets a customer by ID.
    /// </summary>
    /// <param name="customerId">The customer ID.</param>
    /// <param name="includeDetails">Whether to include detailed information.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The customer representing the customer.</returns>
    public static async Task<Customer> GetCustomerAsync(this ApiClient haloApiClient, Int32 customerId, Boolean includeDetails = false, CancellationToken cancellationToken = default)
    {
        // https://halo.pdsint.net/api/Client/172?includedetails=true
        var clientUri = "Client"
            .AppendPathSegment(customerId)
            .AppendQueryParam("includedetails", includeDetails)
            .ToUri();

        var customer = await haloApiClient.HttpGetAsync(clientUri, CustomerJsonContext.Default.Customer, cancellationToken);

        return customer;
    }

    /// <summary>
    /// Gets a client by name.
    /// </summary>
    /// <param name="name">The client name to search for.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The customer representing the client.</returns>
    public static async Task<Customer?> GetCustomerAsync(this ApiClient haloApiClient, String name, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(haloApiClient);
        ArgumentNullException.ThrowIfNull(name);

        var uri = "Client"
            .AppendQueryParam("search_name_only", name)
            .ToUri();

        var customer = await haloApiClient.HttpGetAsync(uri, CustomerJsonContext.Default.Customer, cancellationToken);

        return customer;
    }
}
