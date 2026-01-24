# ProvisionData.HaloPSA.ApiClient.Tests

XUnit test project for the HaloPSA API Client library.

## Testing Stack

- **XUnit** - Testing framework
- **Moq** - Mocking framework for creating test doubles
- **Shouldly** - Assertion library with readable syntax

## Running Tests

```bash
# Run all tests
dotnet test

# Run tests with detailed output
dotnet test --verbosity detailed

# Run tests with code coverage
dotnet test --collect:"XPlat Code Coverage"
```

## Test Structure

Tests are organized by the partial class structure of `HaloPsaApiClient`:

- `HaloPsaApiClientTests.cs` - Core client initialization and configuration tests
- `HaloPsaApiClient_AssetsTests.cs` - Asset management endpoint tests
- Additional test files should follow the naming pattern: `HaloPsaApiClient_{Feature}Tests.cs`

## Writing Tests

### Example: Testing with Moq and Shouldly

```csharp
[Fact]
public async Task GetAssetAsync_ShouldReturnAsset_WhenAssetExists()
{
    // Arrange
    var expectedAsset = new Asset { Id = 123, Name = "Test Asset" };
    var mockHandler = new MockHttpMessageHandler(
        JsonSerializer.Serialize(expectedAsset)
    );
    var httpClient = new HttpClient(mockHandler);
    var client = new HaloPsaApiClient(httpClient, _optionsMock.Object, _timeProviderMock.Object, _loggerMock.Object);

    // Act
    var result = await client.GetAssetAsync(123);

    // Assert
    result.ShouldNotBeNull();
    result.Id.ShouldBe(123);
    result.Name.ShouldBe("Test Asset");
}
```

### Global Usings

The following namespaces are globally imported in `GlobalUsings.cs`:
- `Xunit`
- `Moq`
- `Shouldly`
- `System`
- `System.Collections.Generic`
- `System.Threading`
- `System.Threading.Tasks`

## Test Coverage Goals

- Unit test all public methods
- Mock HTTP dependencies
- Test error handling and edge cases
- Verify proper logging behavior
- Validate authentication token management
