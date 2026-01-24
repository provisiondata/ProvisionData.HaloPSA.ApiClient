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
using Microsoft.Extensions.Options;
using ProvisionData.HaloPSA.ApiClient.Models;

namespace ProvisionData.HaloPSA.ApiClient;

public partial class HaloPsaApiClient(HttpClient httpClient, IOptions<HaloPsaApiClientOptions> options, TimeProvider timeProvider, ILogger<HaloPsaApiClient> logger)
    : HaloPsaApiClientBase(httpClient, options.Value, timeProvider, logger)
{
    public async Task<InstanceInfo> GetInstanceInfo(CancellationToken cancellationToken = default)
    {
        try
        {
            var uri = Options.ApiUrl.AppendPathSegment("InstanceInfo").ToUri();
            var info = await GetAsync<InstanceInfo>(uri, cancellationToken);
            Logger.LogInformation("{Instance}", info);

            return info;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Something went wrong.");
            throw;
        }
    }
}
