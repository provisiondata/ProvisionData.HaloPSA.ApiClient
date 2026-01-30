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
using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;

namespace ProvisionData.HaloPSA.ApiClient;

/// <summary>
/// Base class for HaloPSA API clients providing HTTP operations and authentication.
/// </summary>
public abstract class HaloPsaApiClientBase(HttpClient httpClient, HaloPsaApiClientOptions options, TimeProvider timeProvider, ILogger logger)
{
    private AuthToken? _token;

    protected HttpClient HttpClient { get; } = httpClient;
    protected HaloPsaApiClientOptions Options { get; } = options;
    protected TimeProvider TimeProvider { get; } = timeProvider;
    public ILogger Logger { get; } = logger;

    private async Task EnsureAuthorizedAsync(CancellationToken cancellationToken)
    {
        if (_token?.IsExpired(TimeProvider.GetUtcNow()) != false)
        {
            await GetTokenAsync(cancellationToken);
        }
    }

    private async Task GetTokenAsync(CancellationToken cancellationToken)
    {
        var json = String.Empty;
        try
        {
            var form = new Dictionary<String, String>
                {
                    {"client_id", Options.ClientId},
                    {"client_secret", Options.ClientSecret},
                    {"grant_type", "client_credentials"},
                    {"scope", "all"},
                };

            var uri = Options.AuthUrl
                .AppendPathSegment("token")
                .ToUri();

            var response = await HttpClient.PostAsync(uri, new FormUrlEncodedContent(form), cancellationToken);

            json = await response.Content.ReadAsStringAsync(cancellationToken);

            response.EnsureSuccessStatusCode();

            _token = JsonSerializer.Deserialize(json, AuthJsonSerializerContext.Default.AuthToken);

            if (_token is null)
            {
                throw new HaloPsaApiClientException("Failed to get access token.", json);
            }

            _token.IssuedAt = TimeProvider.GetUtcNow();

            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token.AccessToken);

            Logger.LogDebug("Access token acquired: {AccessToken}", _token.AccessToken);

        }
        catch (Exception ex)
        {
            throw new HaloPsaApiClientException("Failed to get access token.", json, ex);
        }
    }

    protected async Task<String> HttpGetAsync(Uri uri, CancellationToken cancellationToken = default)
    {
        await EnsureAuthorizedAsync(cancellationToken);

        while (true)
        {
            try
            {
                var response = await HttpClient.GetAsync(uri, cancellationToken);
                if (response.StatusCode == HttpStatusCode.TooManyRequests)
                {
                    // Retry after the specified number of seconds
                    const Int32 retryAfterSeconds = 60;

                    await Task.Delay(retryAfterSeconds * 1000, cancellationToken);

                    continue;
                }

                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "An error occured while calling: {URI}", uri);
                throw;
            }
        }
    }

    protected async Task<String> HttpPostAsync(Uri uri, String payload, CancellationToken cancellationToken = default)
    {
        await EnsureAuthorizedAsync(cancellationToken);

        Logger.LogTrace("HttpPostAsync: {api} => {payload}", uri, payload);
        Console.WriteLine(payload);
        var response = await HttpClient.PostAsync(uri, new StringContent(payload, System.Text.Encoding.UTF8, "application/json"), cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var responseBody = await response.Content.ReadAsStringAsync(cancellationToken);
            Logger.LogError("Failed to POST to {uri} => {HttpStatus}: {HttpMessage}\n\tRequest: {request}\n\tResponse: {response}",
                uri, response.StatusCode, response.ReasonPhrase, payload, responseBody);
            throw new HttpRequestException($"Failed to POST to {uri} => {response.StatusCode}: {response.ReasonPhrase}");
        }

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    protected async Task<String> HttpPutAsync(Uri uri, String requestBody, CancellationToken cancellationToken = default)
    {
        await EnsureAuthorizedAsync(cancellationToken);

        var response = await HttpClient.PutAsync(uri, new StringContent(requestBody, System.Text.Encoding.UTF8, "application/json"), cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var responseBody = await response.Content.ReadAsStringAsync(cancellationToken);
            Logger.LogError("Failed to PUT to {uri} => {HttpStatus}: {HttpMessage}\n\tRequest: {request}\n\tResponse: {response}",
                uri, response.StatusCode, response.ReasonPhrase, requestBody, responseBody);
            throw new HttpRequestException($"Failed to PUT to {uri} => {response.StatusCode}: {response.ReasonPhrase}");
        }

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    public async Task<String> HttpGetPagedAsync(Uri uri, Int32 pagenumber, CancellationToken cancellationToken = default)
        => await HttpGetPagedAsync(uri, pagenumber, Options.PageSize, cancellationToken);

    public async Task<String> HttpGetPagedAsync(Uri uri, Int32 pagenumber, Int32 pageSize, CancellationToken cancellationToken = default)
    {
        await EnsureAuthorizedAsync(cancellationToken);

        var url = uri.AppendQueryParam("pageinate", true)
                     .AppendQueryParam("page_no", pagenumber)
                     .AppendQueryParam("page_size", pageSize)
                     .ToUri();

        return await HttpGetAsync(url, cancellationToken);
    }
}
