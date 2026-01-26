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
    public async Task<IReadOnlyCollection<Item>> ListItemsAsync(CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Item")
            .AppendQueryParam("count", 5000)
            .ToUri();
        var json = await HttpGetAsync(uri, cancellationToken);

        try
        {
            var list = JsonSerializer.Deserialize<List<Item>>(json, Options.JsonSerializerOptions)
                ?? throw new InvalidOperationException("Failed to deserialize ItemsList.");

            return list;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to list Items.");
            throw;
        }
    }

    public async Task<Item> GetItemAsync(Int32 itemId, CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Item")
            .AppendPathSegment(itemId)
            .ToUri();
        var json = await HttpGetAsync(uri, cancellationToken);

        try
        {
            var item = JsonSerializer.Deserialize<Item>(json, Options.JsonSerializerOptions)
                ?? throw new InvalidOperationException("Failed to deserialize ItemsList.");

            return item;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to get item: {ItemID}", itemId);
            throw;
        }
    }

    public async Task<Item> CreateItemAsync(Item item, CancellationToken cancellationToken = default)
    {
        var payload = JsonSerializer.Serialize(item, Options.JsonSerializerOptions);

        var json = await HttpPostAsync("Item", $"[{payload}]", cancellationToken);

        Logger.LogDebug("Create Item Response: {json}", json);

        return JsonSerializer.Deserialize<Item>(json, Options.JsonSerializerOptions)!;
    }
}
