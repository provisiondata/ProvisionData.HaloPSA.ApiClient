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
using System.Text.Json;

namespace ProvisionData.HaloPSA.ApiClient;

public partial class HaloApiClient
{
	public async Task<IEnumerable<ListClient>> ListClientsAsync(CancellationToken cancellationToken = default)
	{
		var uri = Options.ApiUrl
			.AppendPathSegment("Client")
			.AppendQueryParam("count", 5000)
			.ToUri();
		var json = await HttpGetAsync(uri, cancellationToken);
		Logger.LogTrace("ListClientsAsync Response: {JSON}", json);

		try
		{
			var list = JsonSerializer.Deserialize<ListClientsResponse>(json, Options.JsonSerializerOptions)
				?? throw new InvalidOperationException("Failed to deserialize ListClientsResponse.");

			return list.Clients;
		}
		catch (Exception ex)
		{
			Logger.LogError(ex, "Failed to list Clients.");
			throw;
		}
	}

	public async Task<Client> GetClientAsync(Int32 clientId, CancellationToken cancellationToken = default)
	{
		var clientUri = Options.ApiUrl
			.AppendPathSegment("Client")
			.AppendPathSegment(clientId)
			.ToUri();
		var clientJson = await HttpGetAsync(clientUri, cancellationToken);
		Logger.LogTrace("GetClientAsync Client Response: {JSON}", clientJson);

		var siteUri = Options.ApiUrl
			.AppendPathSegment("Site")
			.AppendQueryParam("client_id", clientId)
			.ToUri();
		var sitesJson = await HttpGetAsync(siteUri, cancellationToken);
		Logger.LogTrace("GetClientAsync Site Response: {JSON}", sitesJson);

		try
		{
			var client = JsonSerializer.Deserialize<Client>(clientJson, Options.JsonSerializerOptions)
				?? throw new InvalidOperationException($"Failed to deserialize {nameof(Client)}.");

			var sitesResponse = JsonSerializer.Deserialize<ListSitesResponse>(sitesJson, Options.JsonSerializerOptions)
				?? throw new InvalidOperationException($"Failed to deserialize {nameof(Site)}.");

			foreach (var site in sitesResponse.Sites)
			{
				var addressUri = Options.ApiUrl
					.AppendPathSegment("Address")
					.AppendQueryParam("site_id", site.Id)
					.ToUri();

				var addressesJson = await HttpGetAsync(addressUri, cancellationToken);
				Logger.LogTrace("GetClientAsync Site Address Response: {JSON}", sitesJson);

				site.Addresses = JsonSerializer.Deserialize<List<Address>>(addressesJson, Options.JsonSerializerOptions)
					?? throw new InvalidOperationException($"Failed to deserialize {nameof(Address)}.");
			}

			client.Sites = sitesResponse.Sites;

			return client;
		}
		catch (Exception ex)
		{
			Logger.LogError(ex, "Failed to get client: {ClientID}", clientId);
			throw;
		}
	}

	public async Task<Client> GetClientAsync(String name, CancellationToken cancellationToken = default)
	{
		var uri = Options.ApiUrl
			.AppendPathSegment("Client")
			.AppendQueryParam("search_name_only", name)
			.ToUri();

		var json = await HttpGetAsync(uri, cancellationToken);

		try
		{
			var client = JsonSerializer.Deserialize<Client>(json, Options.JsonSerializerOptions)
				?? throw new InvalidOperationException($"Failed to deserialize {nameof(Client)}.");

			return client;
		}
		catch (Exception ex)
		{
			Logger.LogError(ex, "Failed to get client: {Name}", name);
			throw;
		}
	}

	public Task<Int32> CreateClientAsync(CreateClient client, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();

	public Task UpdateClientAsync(Client value, CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();
}
