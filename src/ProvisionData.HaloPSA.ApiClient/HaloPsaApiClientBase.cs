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
using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;

namespace ProvisionData.HaloPSA.ApiClient;

public abstract class HaloPsaApiClientBase(HttpClient httpClient, HaloPsaApiClientOptions options, TimeProvider timeProvider, ILogger logger)
{
    private class Token
    {
        [JsonPropertyName("access_token")]
        public String AccessToken { get; set; } = String.Empty;

        [JsonPropertyName("token_type")]
        public String TokenType { get; set; } = String.Empty;

        [JsonPropertyName("expires_in")]
        public Int32 ExpiresIn { get; set; }

        [JsonPropertyName("refresh_token")]
        public String RefreshToken { get; set; } = String.Empty;

        public DateTimeOffset IssuedAt { get; set; }

        public Boolean IsExpired(DateTimeOffset now)
            => IssuedAt.AddSeconds(ExpiresIn) <= now;
    }

    private Token? _token;

    protected HttpClient HttpClient { get; } = httpClient;
    protected HaloPsaApiClientOptions Options { get; } = options;
    protected TimeProvider TimeProvider { get; } = timeProvider;

    public JsonSerializerOptions JsonSerializerOptions => Options.JsonSerializerOptions;
    public ILogger Logger { get; } = logger;

    private async Task EnsureAuthorizedAsync(CancellationToken cancellationToken)
    {
        if (_token?.IsExpired(TimeProvider.GetUtcNow()) != false)
        {
            await GetToken(cancellationToken);
        }
    }

    private async Task GetToken(CancellationToken cancellationToken)
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

            var url = Options.AuthUrl.AppendPathSegment("token");

            var response = await HttpClient.PostAsync(url, new FormUrlEncodedContent(form), cancellationToken);

            json = await response.Content.ReadAsStringAsync(cancellationToken);

            response.EnsureSuccessStatusCode();

            _token = JsonSerializer.Deserialize<Token>(json, Options.JsonSerializerOptions);

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

    protected async Task<T> GetAsync<T>(Uri uri, CancellationToken cancellationToken = default)
    {
        await EnsureAuthorizedAsync(cancellationToken);

        var json = await HttpGetAsync(uri, cancellationToken);

        return JsonSerializer.Deserialize<T>(json, Options.JsonSerializerOptions)
            ?? throw new HaloApiException($"Failed to deserialize {typeof(T).Name}.", json);
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

    protected async Task<String> HttpPostAsync(String api, String requestBody, CancellationToken cancellationToken = default)
    {
        Logger.LogTrace("HttpPostAsync: {api} => {requestBody}", api, requestBody);

        var response = await HttpClient.PostAsync(Options.ApiUrl + api, new StringContent(requestBody, System.Text.Encoding.UTF8, "application/json"), cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var responseBody = await response.Content.ReadAsStringAsync(cancellationToken);
            Logger.LogError("Failed to POST to {api} => {HttpStatus}: {HttpMessage}\n\tRequest: {request}\n\tResponse: {response}",
                api, response.StatusCode, response.ReasonPhrase, requestBody, responseBody);
            throw new HttpRequestException($"Failed to POST to {api} => {response.StatusCode}: {response.ReasonPhrase}");
        }

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    protected async Task<String> HttpPutAsync(String api, String requestBody, CancellationToken cancellationToken = default)
    {
        var response = await HttpClient.PutAsync(Options.ApiUrl + api, new StringContent(requestBody, System.Text.Encoding.UTF8, "application/json"), cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var responseBody = await response.Content.ReadAsStringAsync(cancellationToken);
            Logger.LogError("Failed to PUT to {api} => {HttpStatus}: {HttpMessage}\n\tRequest: {request}\n\tResponse: {response}",
                api, response.StatusCode, response.ReasonPhrase, requestBody, responseBody);
            throw new HttpRequestException($"Failed to PUT to {api} => {response.StatusCode}: {response.ReasonPhrase}");
        }

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    public async Task<String> HttpGetPage(String api, Int32 pagenumber, CancellationToken cancellationToken = default)
        => await HttpGetPage(api, pagenumber, Options.PageSize, cancellationToken);

    public async Task<String> HttpGetPage(String api, Int32 pagenumber, Int32 pageSize, CancellationToken cancellationToken = default)
    {
        var url = api.AppendQueryParam("pageinate", true)
                     .AppendQueryParam("page_no", pagenumber)
                     .AppendQueryParam("page_size", pageSize)
                     .ToUri();

        return await HttpGetAsync(url, cancellationToken);
    }
}
