using Flurl;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ProvisionData.HaloPSA.ApiClient.Models;
using System.Data;

namespace ProvisionData.HaloPSA.ApiClient;

public partial class HaloApiClient(HttpClient httpClient, IOptions<HaloApiClientOptions> options, TimeProvider timeProvider, ILogger<HaloApiClient> logger)
    : HaloApiClientBase(httpClient, options.Value, timeProvider, logger)
{
    protected IDbConnection GetDbConnection()
    {
        var connectionString = Options.ConnectionString;
        var connection = new SqlConnection(connectionString);
        connection.Open();
        return connection;
    }

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
