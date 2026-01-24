# **TODO**

## **✅ Strengths**

- Clean architecture with proper separation of concerns
- Good use of dependency injection
- Comprehensive OAuth 2.0 authentication with token management
- Rate limiting handling (HTTP 429)
- Strong typing with JSON serialization
- Good test coverage setup with xUnit, Moq, and Shouldly

---

## **🔧 Recommended Improvements**

### **1. Code Quality & Standards**

**Issue**: Inconsistent naming - `Customfield` should be `CustomField`

- **File**: `src\ProvisionData.HaloPSA.ApiClient\Models\Customfield.cs`
- **Impact**: Violates .NET naming conventions
- **Fix**: Rename class to match the property naming in other files

**Issue**: Mixed use of class vs record for model types

- **Example**: `Client.cs` uses `record`, most models use `class`
- **Impact**: Inconsistent immutability semantics
- **Recommendation**: Standardize on `record` for DTOs/models (they're immutable data transfer objects)

**Issue**: Comments are disabled in many model files (e.g., allowed categories)

```csharp
//[JsonPropertyName("allowed_category1")]
//public List<UntypedNode>? AllowedCategory1 { get; set; }
```

- **Impact**: Dead code clutter
- **Fix**: Remove commented code or implement with proper types

### **2. Architecture & Design**

**Issue**: Direct use of `List<UntypedNode>` in models

```csharp
public List<UntypedNode> AllowedOrganisations { get; } = [];
public List<UntypedNode> Faqlists { get; } = [];
```

- **Impact**: Loss of type safety, violates your "avoid null" principle
- **Fix**: Create proper typed models (e.g., `AllowedOrganisation`, `FaqList`)

**Issue**: `HaloPsaApiClient` has database connection method

```csharp
protected IDbConnection GetDbConnection()
```

- **Impact**: Violates single responsibility - API client shouldn't manage DB connections
- **Recommendation**: Move to separate repository/data access layer if needed

**Issue**: Hardcoded retry delay

```csharp
const Int32 retryAfterSeconds = 60;
```

- **Impact**: Not respecting `Retry-After` header from API
- **Fix**: Read and use the actual `Retry-After` header value

#### **3. Error Handling**

**Issue**: Generic exception handling loses context

```csharp
catch (Exception ex)
{
    Logger.LogError(ex, "Something went wrong.");
    throw;
}
```

- **Impact**: Unhelpful error messages
- **Fix**: Provide specific, actionable error messages

**Issue**: Custom exception with JSON property

```csharp
throw new HaloPsaApiClientException("Failed to get access token.") { JSON = json };
```

- **Impact**: Exposing sensitive data in exceptions (client secrets might be in JSON)
- **Fix**: Sanitize or remove sensitive data before including in exceptions

#### **4. Testing**

**Issue**: No actual API integration tests found

- **Impact**: Can't verify real API behavior
- **Recommendation**: Add integration tests (can be marked `[Fact(Skip = "Integration")]` for CI/CD)

**Issue**: Missing test coverage for:

- Rate limiting retry logic
- Token expiration and refresh
- Error scenarios and exception handling
- Pagination logic

#### **5. Documentation**

**Issue**: XML documentation comments missing

```csharp
public partial class HaloPsaApiClient
```

- **Impact**: IntelliSense won't show method descriptions
- **Fix**: Enable `GenerateDocumentationFile` and add XML comments to public APIs

**Issue**: README has incomplete "Advanced Configuration" section

- **Fix**: Complete the truncated section

#### **6. Configuration & Security**

**Issue**: Default URLs in `HaloPsaApiClientOptions`

```csharp
public String AuthUrl { get; set; } = "https://halo.pdsint.net/auth/";
```

- **Impact**: Internal URLs exposed as defaults
- **Fix**: Remove defaults or use placeholder values like `String.Empty`

**Issue**: `ConnectionString` property marked as `default!`

- **Impact**: Null reference if not configured
- **Fix**: Either make nullable or validate in options validation

#### **7. Performance & Best Practices**

**Issue**: Infinite retry loop on rate limiting

```csharp
while (true) { ... }
```

- **Impact**: Could retry forever if API is down
- **Fix**: Add max retry count with exponential backoff

**Issue**: No cancellation token in some HTTP methods

- **Impact**: Can't cancel long-running operations
- **Fix**: Ensure all async methods accept `CancellationToken`

**Issue**: String concatenation for URLs

```csharp
Options.ApiUrl + api
```

- **Impact**: Already using Flurl elsewhere - inconsistent
- **Fix**: Use Flurl consistently for URL building

#### **8. Code Style (Per Your Instructions)**

**Issue**: Using intrinsic types in some places

- Your copilot instructions prefer `String` over `string`, `Int32` over `int`
- **Status**: ✅ Already followed throughout the codebase

**Issue**: Some properties could use init-only setters

```csharp
public String Name { get; set; } = String.Empty;
```

- **Fix**: Use `{ get; init; }` for immutable DTOs

---

### **📋 Priority Action Items**

1. **High Priority**:
   - [ ] Fix rate limiting to respect `Retry-After` header
   - [x] Remove database connection logic from API client or justify its presence
   - [x] Type all `List<UntypedNode>` properties
   - [ ] Add max retry limits to prevent infinite loops
   - [x] Remove default internal URLs from options

2. **Medium Priority**:
   - [ ] Standardize model types (class vs record, record recommended)
   - [ ] Add XML documentation comments
   - [ ] Complete integration test suite
   - [ ] Add options validation

3. **Low Priority**:
   - [x] Clean up commented code
   - [x] Rename `Customfield` to `CustomField`
   - [ ] Complete README documentation
   - [ ] Add more specific error messages
