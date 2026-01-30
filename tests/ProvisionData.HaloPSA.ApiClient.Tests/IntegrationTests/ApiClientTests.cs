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

using Microsoft.Extensions.DependencyInjection;
using ProvisionData.HaloPSA.ApiClient.Models;

namespace ProvisionData.HaloPSA.ApiClient.IntegrationTests;

public class ApiClientTests(ApiClientTestFixture fixture)
    : ApiClientTestBase(fixture)
{
    [Fact]
    public async Task Client_ShouldAuthenticate()
    {
        // Arrange
        var client = Services.GetRequiredService<HaloPsaApiClient>();

        // Act
        var info = await client.GetInstanceInfoAsync(CancellationToken.None);

        // Assert
        info.Should().NotBeNull();
        info.AppName.Should().Be("Halo PSA");
    }

    [Fact]
    public async Task ShouldGet_Client()
    {
        // Arrange

        // Act
        var client = await SUT.GetCustomerAsync(TestData.TestCustomerId, cancellationToken: CancellationToken);

        // Assert
        client.Should().NotBeNull();
        client.Id.Should().Be(TestData.TestCustomerId);
    }

    [Fact]
    public async Task Should_CreateAsset()
    {
        // Arrange
        var id = Guid.NewGuid().ToString().Replace("-", String.Empty)[..8];
        var serialNumber = Bogus.Commerce.Ean13();

        var asset = Asset.Create(TestData.TestCustomerId, TestData.TestAssetTypeId, TestData.TestSiteId, TestData.TestTechnicalOwnerId,
            assetNumber: $"ASSET-{id}", name: $"Test Asset {id}", Bogus.Person.FullName, Bogus.Commerce.ProductName(), serialNumber, DateTime.UtcNow.AddDays(-1));

        // Act
        var result = await SUT.CreateAssetAsync(asset, cancellationToken: CancellationToken);

        // Assert
        result.Should().NotBeNull();
        result.Id.Should().BeGreaterThan(0);
        result.Fields.SingleOrDefault(f => f.Id == 117)?.Value.Should().Be(serialNumber);
    }
}
