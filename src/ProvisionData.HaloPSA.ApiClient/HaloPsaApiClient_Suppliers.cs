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
    /// Lists all suppliers from the HaloPSA API.
    /// </summary>
    /// <returns>A collection of companies representing suppliers.</returns>
    public async Task<IReadOnlyList<Company>> ListSuppliersAsync()
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Supplier")
            .AppendQueryParam("count", 5000)
            .ToUri();
        var json = await HttpGetAsync(uri);

        try
        {
            var list = JsonSerializer.Deserialize(json, HaloPsaApiJsonSerializerContext.Default.ListCompany)
                ?? throw new InvalidOperationException("Failed to deserialize SuppliersList.");

            return list;
        }
        catch (Exception ex)
        {
            throw new HaloApiException("Failed to deserialize AssetRoot.", json, ex);
        }
    }

    /// <summary>
    /// Creates a new supplier in HaloPSA.
    /// </summary>
    /// <param name="supplier">The supplier to create.</param>
    /// <returns>The JSON response from the API.</returns>
    public async Task<String> CreateSupplierAsync(Supplier supplier)
    {
        ArgumentNullException.ThrowIfNull(supplier);

        var payload = JsonSerializer.Serialize(supplier, HaloPsaApiJsonSerializerContext.Default.Supplier);

        var json = await HttpPostAsync("Supplier", $"[{payload}]");

        Logger.LogDebug("Create Supplier Response: {json}", json);

        return json;
    }
}
