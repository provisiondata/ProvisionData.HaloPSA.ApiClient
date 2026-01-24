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
    public async Task<IReadOnlyDictionary<Int32, AccountCode>> ListAccountCodesAsync(CancellationToken cancellationToken = default)
    {
        var uri = Options.ApiUrl
            .AppendPathSegment("Lookup")
            .AppendQueryParam("lookupid", 67)
            .AppendQueryParam("count", 5000)
            .ToUri();

        var json = await HttpGetAsync(uri, cancellationToken);

        Logger.LogTrace("List AccountCodes Response: {json}", json);

        try
        {
            var list = JsonSerializer.Deserialize<List<AccountCode>>(json, Options.JsonSerializerOptions)
                ?? throw new InvalidOperationException("Failed to deserialize AccountCodesList.");

            return list.ToDictionary(e => e.Id, f => f).AsReadOnly();
        }
        catch (Exception ex)
        {
            throw new HaloApiException("Failed to deserialize AccountCodesList.", json, ex);
        }
    }

    public async Task<String> CreateAccountCodeAsync(AccountCode accountCode, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(accountCode);

        var payload = JsonSerializer.Serialize(accountCode, Options.JsonSerializerOptions);

        var json = await HttpPostAsync("AccountCode", $"[{payload}]", cancellationToken);

        Logger.LogDebug("Create AccountCode Response: {json}", json);

        return json;
    }

    public async Task<String> UpdateAccountCodeAsync(AccountCode accountCode, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(accountCode);
        if (accountCode.Id <= 0)
            throw new ArgumentException("AccountCode.Id must be greater than zero.");

        if (accountCode.LookupId <= 0)
            throw new ArgumentException("AccountCode.LookupId must be greater than zero.");

        if (String.IsNullOrWhiteSpace(accountCode.Name))
            throw new ArgumentException("AccountCode.Name must not be null or empty.");

        if (String.IsNullOrWhiteSpace(accountCode.Code))
            throw new ArgumentException("AccountCode.Code must not be null or empty.");

        var payload = JsonSerializer.Serialize(accountCode, Options.JsonSerializerOptions);

        var json = await HttpPutAsync("AccountCode", $"[{payload}]", cancellationToken);

        Logger.LogDebug("Create AccountCode Response: {json}", json);

        return json;
    }
}
