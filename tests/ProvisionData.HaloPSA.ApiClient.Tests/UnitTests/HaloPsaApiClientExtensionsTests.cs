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
using Microsoft.Extensions.Options;

namespace ProvisionData.HaloPSA.ApiClient.UnitTests;

public class HaloPsaApiClientExtensionsTests
{
    [Fact]
    public void AddHaloPsaApiClient_WithConfiguration_ShouldRegisterServices()
    {
        // Arrange
        var services = new ServiceCollection();
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<String, String>
            {
                [$"{HaloPsaApiClientOptions.SectionName}:AuthUrl"] = "https://test.halo.local/auth/",
                [$"{HaloPsaApiClientOptions.SectionName}:ApiUrl"] = "https://test.halo.local/api/",
                [$"{HaloPsaApiClientOptions.SectionName}:ClientId"] = "test-client",
                [$"{HaloPsaApiClientOptions.SectionName}:ClientSecret"] = "test-secret",
                [$"{HaloPsaApiClientOptions.SectionName}:PageSize"] = "100"
            }!)
            .Build();

        // Act
        var httpClientBuilder = services.AddHaloPsaApiClient(configuration);

        // Assert
        httpClientBuilder.ShouldNotBeNull();

        var serviceProvider = services.BuildServiceProvider();
        var options = serviceProvider.GetRequiredService<IOptions<HaloPsaApiClientOptions>>();
        var timeProvider = serviceProvider.GetRequiredService<TimeProvider>();
        var client = serviceProvider.GetRequiredService<HaloPsaApiClient>();

        options.Value.AuthUrl.ShouldBe("https://test.halo.local/auth/");
        options.Value.ApiUrl.ShouldBe("https://test.halo.local/api/");
        options.Value.ClientId.ShouldBe("test-client");
        options.Value.ClientSecret.ShouldBe("test-secret");
        options.Value.PageSize.ShouldBe(100);
        timeProvider.ShouldNotBeNull();
        client.ShouldNotBeNull();
    }

    [Fact]
    public void AddHaloPsaApiClient_WithCustomConfigurationSection_ShouldRegisterServices()
    {
        // Arrange
        var services = new ServiceCollection();
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<String, String>
            {
                ["CustomSection:AuthUrl"] = "https://custom.halo.local/auth/",
                ["CustomSection:ApiUrl"] = "https://custom.halo.local/api/",
                ["CustomSection:ClientId"] = "custom-client",
                ["CustomSection:ClientSecret"] = "custom-secret"
            }!)
            .Build();

        // Act
        HaloPsaApiClientOptions.SectionName = "CustomSection";
        var httpClientBuilder = services.AddHaloPsaApiClient(configuration);

        // Assert
        httpClientBuilder.ShouldNotBeNull();

        var serviceProvider = services.BuildServiceProvider();
        var options = serviceProvider.GetRequiredService<IOptions<HaloPsaApiClientOptions>>();

        options.Value.AuthUrl.ShouldBe("https://custom.halo.local/auth/");
        options.Value.ApiUrl.ShouldBe("https://custom.halo.local/api/");
        options.Value.ClientId.ShouldBe("custom-client");
        options.Value.ClientSecret.ShouldBe("custom-secret");
    }

    [Fact]
    public void AddHaloPsaApiClient_WithAction_ShouldRegisterServices()
    {
        // Arrange
        var services = new ServiceCollection();

        // Act
        var httpClientBuilder = services.AddHaloPsaApiClient(options =>
        {
            options.AuthUrl = "https://action.halo.local/auth/";
            options.ApiUrl = "https://action.halo.local/api/";
            options.ClientId = "action-client";
            options.ClientSecret = "action-secret";
            options.PageSize = 200;
        });

        // Assert
        httpClientBuilder.ShouldNotBeNull();

        var serviceProvider = services.BuildServiceProvider();
        var options = serviceProvider.GetRequiredService<IOptions<HaloPsaApiClientOptions>>();
        var client = serviceProvider.GetRequiredService<HaloPsaApiClient>();

        options.Value.AuthUrl.ShouldBe("https://action.halo.local/auth/");
        options.Value.ApiUrl.ShouldBe("https://action.halo.local/api/");
        options.Value.ClientId.ShouldBe("action-client");
        options.Value.ClientSecret.ShouldBe("action-secret");
        options.Value.PageSize.ShouldBe(200);
        client.ShouldNotBeNull();
    }

    [Fact]
    public void AddHaloPsaApiClient_WithConfiguration_ShouldThrowArgumentNullException_WhenServicesIsNull()
    {
        // Arrange
        IServiceCollection services = null!;
        var configuration = new ConfigurationBuilder().Build();

        // Act & Assert
        Should.Throw<ArgumentNullException>(() => services.AddHaloPsaApiClient(configuration));
    }

    [Fact]
    public void AddHaloPsaApiClient_WithConfiguration_ShouldThrowArgumentNullException_WhenConfigurationIsNull()
    {
        // Arrange
        var services = new ServiceCollection();
        IConfiguration configuration = null!;

        // Act & Assert
        Should.Throw<ArgumentNullException>(() => services.AddHaloPsaApiClient(configuration));
    }

    [Fact]
    public void AddHaloPsaApiClient_WithAction_ShouldThrowArgumentNullException_WhenServicesIsNull()
    {
        // Arrange
        IServiceCollection services = null!;

        // Act & Assert
        Should.Throw<ArgumentNullException>(() => services.AddHaloPsaApiClient(configureOptions));

        static void configureOptions(HaloPsaApiClientOptions options)
        {
        }
    }

    [Fact]
    public void AddHaloPsaApiClient_WithAction_ShouldThrowArgumentNullException_WhenConfigureOptionsIsNull()
    {
        // Arrange
        var services = new ServiceCollection();
        Action<HaloPsaApiClientOptions> configureOptions = null!;

        // Act & Assert
        Should.Throw<ArgumentNullException>(() => services.AddHaloPsaApiClient(configureOptions));
    }

    [Fact]
    public void AddHaloPsaApiClient_ShouldRegisterTimeProviderOnlyOnce()
    {
        // Arrange
        var services = new ServiceCollection();
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<String, String>
            {
                ["HaloPsaApiClient:ClientId"] = "test"
            }!)
            .Build();

        // Act
        services.AddHaloPsaApiClient(configuration);
        services.AddHaloPsaApiClient(configuration); // Add twice

        // Assert
        var serviceProvider = services.BuildServiceProvider();
        var timeProviders = serviceProvider.GetServices<TimeProvider>().ToList();

        // Should only have one TimeProvider registered despite adding twice
        timeProviders.Count.ShouldBe(1);
    }
}
