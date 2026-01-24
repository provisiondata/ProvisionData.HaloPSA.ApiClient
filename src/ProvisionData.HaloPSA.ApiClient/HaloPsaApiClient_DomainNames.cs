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
    public async Task<IReadOnlyCollection<DomainName>> ListDomainNamesAsync(CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Asset")
            .AppendQueryParam("assettype_id", 141)
            .ToUri();
        var json = await HttpGetAsync(uri, cancellationToken);

        try
        {
            var list = JsonSerializer.Deserialize<ListDomainNamesResult>(json, Options.JsonSerializerOptions)
                ?? throw new InvalidOperationException("Failed to deserialize ListDomainNamesResult.");

            return list.DomainNames;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Failed to list DomainNames.");
            throw;
        }
    }

    public async Task<DomainName> CreateDomainNameAsync(CreateDomainName domainname, CancellationToken cancellationToken = default)
    {
        var payload = JsonSerializer.Serialize(domainname, Options.JsonSerializerOptions);

        var json = await HttpPostAsync("Asset", $"[{payload}]", cancellationToken);

        Logger.LogDebug("Create DomainName Response: {json}", json);

        return JsonSerializer.Deserialize<DomainName>(json, Options.JsonSerializerOptions)!;
    }
}
