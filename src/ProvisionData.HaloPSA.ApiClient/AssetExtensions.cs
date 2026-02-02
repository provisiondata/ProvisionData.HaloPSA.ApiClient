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

public static partial class AssetExtensions
{
    /// <summary>
    /// Lists all assets from the HaloPSA API.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A collection of device assetView items.</returns>
    public static async Task<IReadOnlyCollection<Asset>?> ListAssetsAsync(this ApiClient haloApiClient, CancellationToken cancellationToken = default)
    {
        var uri = "Asset"
            .AppendQueryParam("count", 200)
            .ToUri();

        var result = await haloApiClient.HttpGetAsync(uri, ApiJsonContext.Default.AssetList, cancellationToken);

        return result.Assets;
    }

    /// <summary>
    /// Gets a specific asset by ID.
    /// </summary>
    /// <param name="assetId">The asset ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The device details.</returns>
    public static async Task<Asset> GetAssetAsync(this ApiClient haloApiClient, Int32 assetId, CancellationToken cancellationToken = default)
    {
        var uri = "Asset"
            .AppendPathSegment(assetId)
            .ToUri();

        var json = await haloApiClient.HttpGetAsync(uri, cancellationToken);

        var asset = JsonSerializer.Deserialize(json, AssetJsonContext.Default.Asset)
            ?? throw new HaloApiException("Failed to deserialize AssetsList.", json);

        return asset;
    }

    /// <summary>
    /// Creates a new asset in HaloPSA.
    /// </summary>
    /// <param name="asset">The asset to create.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The created device.</returns>
    public static async Task<Asset> CreateAssetAsync(this ApiClient haloApiClient, Asset asset, CancellationToken cancellationToken = default)
    {
        var uri = new Uri("Asset", UriKind.Relative);

        var payload = JsonSerializer.Serialize(asset, AssetJsonContext.Default.Asset);

        var result = await haloApiClient.HttpPostAsync<Asset>(uri, $"[{payload}]", AssetJsonContext.Default.Asset, cancellationToken);

        return result;
    }
}
