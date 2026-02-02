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

public static class ItemExtensions
{
    /// <summary>
    /// Lists all items from the HaloPSA API.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A collection of items.</returns>
    public static async Task<IReadOnlyCollection<Item>> ListItemsAsync(this ApiClient haloApiClient, CancellationToken cancellationToken = default)
    {
        var uri = "Item"
            .AppendQueryParam("count", 200)
            .ToUri();

        var result = await haloApiClient.HttpGetAsync(uri, ItemJsonContext.Default.ListItem, cancellationToken);

        return result;
    }

    /// <summary>
    /// Gets a specific item by ID.
    /// </summary>
    /// <param name="itemId">The item ID.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The item details.</returns>
    public static async Task<Item> GetItemAsync(this ApiClient haloApiClient, Int32 itemId, CancellationToken cancellationToken = default)
    {
        var uri = "Item"
            .AppendPathSegment(itemId)
            .ToUri();

        var result = await haloApiClient.HttpGetAsync(uri, ItemJsonContext.Default.Item, cancellationToken);

        return result;
    }

    /// <summary>
    /// Creates a new item in HaloPSA.
    /// </summary>
    /// <param name="item">The item to create.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The created item.</returns>
    public static async Task<Item> CreateItemAsync(this ApiClient haloApiClient, Item item, CancellationToken cancellationToken = default)
    {
        var uri = new Uri("Item");

        var payload = JsonSerializer.Serialize(item, ItemJsonContext.Default.Item);

        var result = await haloApiClient.HttpPostAsync(uri, $"[{payload}]", ItemJsonContext.Default.Item, cancellationToken);

        return result;
    }
}
