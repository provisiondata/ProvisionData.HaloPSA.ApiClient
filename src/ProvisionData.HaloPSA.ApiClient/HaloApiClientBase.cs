// Provision Data Systems Inc.
// Copyright (C) 2024 Doug Wilson
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
using System.Text;
using System.Text.Json;

namespace ProvisionData.HaloPSA.ApiClient;

public abstract class HaloApiClientBase(HttpClient httpClient, HaloApiClientOptions options, TimeProvider timeProvider, ILogger<HaloApiClient> logger)
{
	private AuthToken? _accessToken;

	protected HttpClient HttpClient { get; } = httpClient;
	protected HaloApiClientOptions Options { get; } = options;
	protected TimeProvider TimeProvider { get; } = timeProvider;

	public JsonSerializerOptions JsonSerializerOptions => Options.JsonSerializerOptions;
	public ILogger<HaloApiClient> Logger { get; } = logger;

	private async Task EnsureAuthorizedAsync(CancellationToken cancellationToken)
	{
		if (_accessToken?.IsExpired(TimeProvider.GetUtcNow()) != false)
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

			_accessToken = JsonSerializer.Deserialize<AuthToken>(json, Options.JsonSerializerOptions);

			if (_accessToken is null)
			{
				throw new HaloApiClientException("Failed to get access token.") { JSON = json };
			}

			_accessToken.IssuedAt = TimeProvider.GetUtcNow();

			HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken.AccessToken);

			Logger.LogDebug("Access token acquired: {AccessToken}", _accessToken.AccessToken);

		}
		catch (Exception ex)
		{
			throw new HaloApiClientException("Failed to get access token.", ex) { JSON = json };
		}
	}

	protected async Task<T> GetAsync<T>(Uri uri, CancellationToken cancellationToken = default)
	{
		await EnsureAuthorizedAsync(cancellationToken);

		var json = await HttpGetAsync(uri, cancellationToken);

		return JsonSerializer.Deserialize<T>(json, Options.JsonSerializerOptions)
			?? throw new InvalidOperationException($"Failed to deserialize {typeof(T).Name}.");
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

		var response = await HttpClient.PostAsync(Options.ApiUrl + api, new StringContent(requestBody, Encoding.UTF8, "application/json"), cancellationToken);

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
		var response = await HttpClient.PutAsync(Options.ApiUrl + api, new StringContent(requestBody, Encoding.UTF8, "application/json"), cancellationToken);

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
