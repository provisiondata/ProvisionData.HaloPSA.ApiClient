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
    /// Lists all assets from the HaloPSA API.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A collection of device list items.</returns>
    public async Task<IReadOnlyCollection<AssetView>?> ListAssetsAsync(CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Asset")
            .AppendQueryParam("count", 5000)
            .ToUri();
        var json = await HttpGetAsync(uri, cancellationToken);

        try
        {
            var list = JsonSerializer.Deserialize(json, HaloPsaAssetJsonContext.Default.AssetView)
                ?? throw new InvalidOperationException("Failed to deserialize AssetsList.");

            return list.Assets;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to list Assets.");
            throw;
        }
    }

    /// <summary>
    /// Gets a specific asset by ID.
    /// </summary>
    /// <param name="assetId">The asset ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The device details.</returns>
    public async Task<Asset> GetAssetAsync(Int32 assetId, CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Asset")
            .AppendPathSegment(assetId)
            .ToUri();

        var json = await HttpGetAsync(uri, cancellationToken);

        try
        {
            var asset = JsonSerializer.Deserialize(json, HaloPsaAssetJsonContext.Default.Asset)
                ?? throw new InvalidOperationException("Failed to deserialize AssetsList.");

            return asset;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to get asset: {AssetID}", assetId);
            throw;
        }
    }

    /// <summary>
    /// Creates a new asset in HaloPSA.
    /// </summary>
    /// <param name="asset">The asset to create.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The created device.</returns>
    public async Task<Asset> CreateAssetAsync(Asset asset, CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Asset")
            .ToUri();

        var payload = JsonSerializer.Serialize(asset, HaloPsaAssetJsonContext.Default.Asset);

        var json = await HttpPostAsync(uri, $"[{payload}]", cancellationToken);

        Logger.LogDebug("Create Asset Response: {json}", json);

        return JsonSerializer.Deserialize(json, HaloPsaAssetJsonContext.Default.Asset)!;
    }
}
