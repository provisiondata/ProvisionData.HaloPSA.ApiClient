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

namespace ProvisionData.HaloPSA.ApiClient;

/// <summary>
/// Base class for HaloPSA API clients providing HTTP operations and authentication.
/// </summary>
public abstract class HaloPsaApiClientBase(
    HttpClient httpClient,
    HaloPsaApiClientOptions options,
    IAuthTokenProvider tokenRepository,
    TimeProvider timeProvider,
    ILogger logger,
    IFieldMappingProvider fieldMappingProvider)
{
    // private AuthToken? _token;
    private readonly IAuthTokenProvider _tokenRepository = tokenRepository;
    private readonly IFieldMappingProvider _fieldMappingProvider = fieldMappingProvider;

    protected HttpClient HttpClient { get; } = httpClient;
    protected HaloPsaApiClientOptions Options { get; } = options;
    protected TimeProvider TimeProvider { get; } = timeProvider;
    public ILogger Logger { get; } = logger;

    protected T EnsureAssetFieldsMapped<T>(T dto)
        where T : IHasCustomFields
    {
        if (!dto.FieldsAreMapped)
        {
            dto.ApplyFieldMap(_fieldMappingProvider);
        }

        return dto;
    }

    private async Task EnsureAuthorizedAsync(CancellationToken cancellationToken)
    {
        var token = await _tokenRepository.GetTokenAsync(cancellationToken)
            ?? throw new HaloPsaApiClientException("Failed to obtain authentication token.");

        HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
    }

    protected async Task<String> HttpGetAsync(Uri uri, CancellationToken cancellationToken = default)
    {
        await EnsureAuthorizedAsync(cancellationToken);

        var retryCount = 0;
        while (true)
        {
            try
            {
                if (retryCount >= Options.MaxRetries)
                {
                    throw new HaloPsaApiClientException($"Maximum retry attempts reached for API call: {uri}");
                }

                retryCount++;
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
                throw new HaloPsaApiClientException($"API call failed: {uri}", ex);
            }
        }
    }

    protected async Task<String> HttpPostAsync(Uri uri, String payload, CancellationToken cancellationToken = default)
    {
        await EnsureAuthorizedAsync(cancellationToken);

        Logger.LogTrace("HttpPostAsync: {api} => {payload}", uri, payload);

        var response = await HttpClient.PostAsync(uri, new StringContent(payload, System.Text.Encoding.UTF8, "application/json"), cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var errorResponse = await response.Content.ReadAsStringAsync(cancellationToken);

            Logger.LogError("Failed to POST to {uri} => {HttpStatus}: {HttpMessage}\n\tRequest: {request}\n\tResponse: {response}",
                uri, response.StatusCode, response.ReasonPhrase, payload, errorResponse);

            throw new HaloPsaApiClientException($"Failed to POST to {uri} => {response.StatusCode}: {response.ReasonPhrase}", payload);
        }

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    protected async Task<String> HttpPutAsync(Uri uri, String payload, CancellationToken cancellationToken = default)
    {
        await EnsureAuthorizedAsync(cancellationToken);

        var response = await HttpClient.PutAsync(uri, new StringContent(payload, System.Text.Encoding.UTF8, "application/json"), cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var errorResponse = await response.Content.ReadAsStringAsync(cancellationToken);

            Logger.LogError("Failed to PUT to {uri} => {HttpStatus}: {HttpMessage}\n\tRequest: {request}\n\tResponse: {response}",
                uri, response.StatusCode, response.ReasonPhrase, payload, errorResponse);

            throw new HaloPsaApiClientException($"Failed to PUT to {uri} => {response.StatusCode}: {response.ReasonPhrase}", payload);
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
