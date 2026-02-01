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

public static class SupplierExtensions
{
    /// <summary>
    /// Lists all suppliers from the HaloPSA API.
    /// </summary>
    /// <returns>A collection of companies representing suppliers.</returns>
    public static async Task<IReadOnlyList<Company>> ListSuppliersAsync(this ApiClient haloApiClient, CancellationToken cancellationToken = default)
    {
        var uri = "Supplier"
            .AppendQueryParam("count", 5000)
            .ToUri();

        var result = await haloApiClient.HttpGetAsync(uri, VendorJsonContext.Default.ListCompany, cancellationToken);

        return result;
    }

    /// <summary>
    /// Creates a new supplier in HaloPSA.
    /// </summary>
    /// <param name="supplier">The supplier to create.</param>
    /// <returns>The JSON response from the API.</returns>
    public static async Task<Supplier> CreateSupplierAsync(this ApiClient haloApiClient, Supplier supplier, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(supplier);

        var uri = new Uri("Supplier");

        var payload = JsonSerializer.Serialize(supplier, VendorJsonContext.Default.Supplier);

        var result = await haloApiClient.HttpPostAsync(uri, $"[{payload}]", VendorJsonContext.Default.Supplier, cancellationToken);

        return result;
    }
}
