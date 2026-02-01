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

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using ProvisionData.HaloPSA.DTO;
using System.Diagnostics.CodeAnalysis;

namespace ProvisionData.HaloPSA;

public static class ConfigurationExtensions
{
    /// <summary>
    /// Adds the HaloPSA API client to the service collection.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="configuration">The configuration instance.</param>
    /// <param name="configurationSectionName">The configuration section name. Defaults to "ApiClient".</param>
    /// <returns>An <see cref="IHttpClientBuilder"/> for further configuration.</returns>
    [UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "HaloPsaApiClientOptions properties are simple types")]
    [UnconditionalSuppressMessage("AOT", "IL3050", Justification = "HaloPsaApiClientOptions properties are simple types")]
    public static IHttpClientBuilder AddHaloPsaApiClient(this IServiceCollection services, IConfiguration configuration)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configuration);

        // Configure ReaderOptions from configuration
        services.Configure<HaloPsaApiClientOptions>(configuration.GetSection(HaloPsaApiClientOptions.SectionName));

        // Register singleton services if not already registered
        services.TryAddSingleton(TimeProvider.System);
        services.TryAddSingleton<IAuthTokenProvider, AuthTokenProvider>();
        services.TryAddSingleton<IFieldMappingProvider, ConfigurationBasedFieldMappingProvider>();

        // Register HttpClient with factory pattern
        return services.AddHttpClient<ApiClient>((sp, httpClient) =>
        {
            // Additional HttpClient configuration can be done here if needed
            var options = sp.GetRequiredService<IOptions<HaloPsaApiClientOptions>>().Value;
            httpClient.BaseAddress = new Uri(options.ApiUrl);
            httpClient.Timeout = TimeSpan.FromMinutes(5);
        });
    }

    public static IServiceProvider EnsureCustomFieldsHaveBeenMapped(this IServiceProvider serviceProvider)
    {
        ArgumentNullException.ThrowIfNull(serviceProvider);

        var mapper = serviceProvider.GetRequiredService<IFieldMappingProvider>();

        // Apply field mappings for models that implement IHasCustomFields
        Asset.ApplyFieldMappings(mapper);

        return serviceProvider;
    }

    /// <summary>
    /// Adds the HaloPSA API client to the service collection with manual configuration.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="configureOptions">Action to configure the ReaderOptions.</param>
    /// <returns>An <see cref="IHttpClientBuilder"/> for further configuration.</returns>
    public static IHttpClientBuilder AddHaloPsaApiClient(
        this IServiceCollection services,
        Action<HaloPsaApiClientOptions> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configureOptions);

        services.AddOptions();

        // Configure ReaderOptions using action
        services.Configure(configureOptions);

        // Register singleton services if not already registered
        services.TryAddSingleton(TimeProvider.System);
        services.TryAddSingleton<IAuthTokenProvider, AuthTokenProvider>();
        services.TryAddSingleton<IFieldMappingProvider, ConfigurationBasedFieldMappingProvider>();

        // Register HttpClient with factory pattern
        return services.AddHttpClient<ApiClient>((sp, httpClient) =>
        {
            var options = sp.GetRequiredService<IOptions<HaloPsaApiClientOptions>>().Value;
            httpClient.BaseAddress = new Uri(options.ApiUrl);
            httpClient.Timeout = TimeSpan.FromMinutes(5);
        });
    }
}
