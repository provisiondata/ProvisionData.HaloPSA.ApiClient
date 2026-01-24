using Flurl;
using Microsoft.Extensions.Logging;
using ProvisionData.HaloPSA.ApiClient.Models;
using System.Text.Json;

namespace ProvisionData.HaloPSA.ApiClient;

public partial class HaloApiClient
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
