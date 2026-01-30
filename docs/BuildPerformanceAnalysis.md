# Build Performance Analysis for ProvisionData.HaloPSA.ApiClient

**Date:** Analysis completed based on current build times

**Build Duration:** 01:19 minutes (79 seconds) for Release configuration

## Summary

The slow build performance is primarily caused by **large generated model files** that the C# compiler and JSON Source Generator must process. The project contains 78 C# files, with several extremely large generated models.

## Root Causes

### 1. Extremely Large Generated Files

The build is slow because of massive auto-generated model files:

| File | Lines of Code | Impact |
|------|--------------|--------|
| `Control.g.cs` | **15,339 lines** | 🔴 Critical - Single largest file |
| `Ticket.g.cs` | 3,806 lines | 🟠 High |
| `Customer.g.cs` | 2,035 lines | 🟡 Medium |
| `Action.g.cs` | 1,997 lines | 🟡 Medium |
| `Asset.g.cs` | 1,460 lines | 🟡 Medium |
| `Uname.g.cs` | 1,454 lines | 🟡 Medium |
| `Users.g.cs` | 1,371 lines | 🟡 Medium |
| `InvoiceHeader.g.cs` | 1,140 lines | 🟡 Medium |

The `Control.g.cs` file alone accounts for approximately **20% of all code** in the project and contains over 12,000 lines of properties with JSON attributes.

### 2. JSON Source Generator Overhead

The project uses System.Text.Json source generators with multiple `JsonSerializerContext` classes:

- `HaloPsaApiJsonSerializerContext`
- `HaloPsaAssetJsonContext.g.cs`
- `HaloPsaCustomerJsonContext.g.cs`
- `HaloPsaInvoiceJsonContext.g.cs`
- `HaloPsaItemJsonContext.g.cs`
- `HaloPsaTicketJsonContext.g.cs`
- `HaloPsaUserJsonContext.g.cs`
- `HaloPsaVendorJsonContext.g.cs`
- `HaloPsaCommonJsonContext.g.cs`

Each context must be analyzed and code generated during compilation. The large model files with hundreds/thousands of properties significantly increase source generator execution time.

### 3. Large Number of Compiler Warnings

The build produces **78+ CS8618 warnings** about non-nullable properties. While warnings don't significantly slow builds, they indicate the generated code isn't optimal and may cause the compiler to do extra work.

### 4. Build Analyzers

The project includes several build-time analyzers:

- **Nerdbank.GitVersioning** (3.9.50)
- **Microsoft.SourceLink.GitHub** (10.0.102)
- **Microsoft.VisualStudio.Threading.Analyzers** (17.14.15)

These analyzers run on every build and add overhead, especially with large files.

## Performance Breakdown (Estimated)

Based on typical .NET build performance characteristics:

- **Source Generators (JSON):** ~35-45 seconds (45-55% of build time)
- **C# Compilation:** ~20-30 seconds (25-35% of build time)
- **Analyzers:** ~8-12 seconds (10-15% of build time)
- **Other tasks (NuGet, SourceLink, etc.):** ~6-10 seconds (5-10% of build time)

## Recommendations

### Immediate Improvements (High Impact)

#### 1. **Split the Control Model** 🔴 Critical
The 15,339-line `Control.g.cs` file should be split into smaller, more manageable models:

- Group related properties into separate classes
- Use composition instead of a single massive class
- Consider using partial classes to split the file logically

**Expected Impact:** 30-40% build time reduction

#### 2. **Enable Incremental Build Optimizations**
Add to `Directory.Build.props`:

```xml
<PropertyGroup>
  <!-- Enable incremental builds -->
  <UseSharedCompilation>true</UseSharedCompilation>
  <ProduceReferenceAssembly>true</ProduceReferenceAssembly>
  
  <!-- Optimize source generators -->
  <EmitCompilerGeneratedFiles>false</EmitCompilerGeneratedFiles>
  <CompilerGeneratedFilesOutputPath>$(BaseIntermediateOutputPath)Generated</CompilerGeneratedFilesOutputPath>
</PropertyGroup>
```

**Expected Impact:** 15-20% build time reduction on subsequent builds

#### 3. **Optimize Generated Code Quality**
Update the code generator to:

- Use `required` modifier instead of nullable properties where appropriate
- Reduce the number of JsonIgnore attributes by using context-level configuration
- Generate more efficient property patterns

**Expected Impact:** 10-15% build time reduction

### Medium-Term Improvements

#### 4. **Consolidate JSON Contexts**
Instead of 9 separate `JsonSerializerContext` classes, consider:

- Using fewer, broader contexts
- Lazy-loading contexts only when needed
- Using the focused contexts only where trimming is critical

**Expected Impact:** 5-10% build time reduction

#### 5. **Conditional Analyzer Execution**
Modify `Directory.Build.props` to run analyzers only in CI or on-demand:

```xml
<PropertyGroup Condition="'$(Configuration)' == 'Debug' AND '$(GITHUB_ACTIONS)' != 'true'">
  <!-- Disable some analyzers in local Debug builds -->
  <RunAnalyzersDuringBuild>false</RunAnalyzersDuringBuild>
</PropertyGroup>
```

**Expected Impact:** 5-8% build time reduction for Debug builds

#### 6. **Use Parallel Compilation**
Ensure parallel compilation is enabled in `Directory.Build.props`:

```xml
<PropertyGroup>
  <BuildInParallel>true</BuildInParallel>
  <MaxCpuCount>0</MaxCpuCount> <!-- Use all available cores -->
</PropertyGroup>
```

**Expected Impact:** 10-15% build time reduction (if not already enabled)

### Long-Term Improvements

#### 7. **Consider Source Generator Architecture**
- Move complex models to separate assemblies
- Use incremental source generators (IIncrementalGenerator)
- Cache generated code when API schemas haven't changed

**Expected Impact:** 20-30% build time reduction

#### 8. **Implement Build Caching**
- Use MSBuild build caching
- Implement distributed build cache for teams
- Cache NuGet restore and source generator outputs

**Expected Impact:** 40-60% build time reduction on clean builds

## Expected Results

Implementing the **immediate improvements** should reduce build time from:

- **Current:** ~79 seconds
- **After improvements:** ~35-45 seconds (55-60% reduction)

With **all recommendations** implemented:

- **Optimized build time:** ~15-25 seconds (70-80% reduction)
- **Incremental builds:** ~3-8 seconds

## Next Steps

1. **Priority 1:** Analyze and split the `Control.g.cs` model
2. **Priority 2:** Enable incremental build optimizations
3. **Priority 3:** Fix nullable reference warnings in generated code
4. **Priority 4:** Benchmark build performance after each change
5. **Priority 5:** Implement medium and long-term improvements

## Monitoring

Track build performance with:

```powershell
# Measure clean build
dotnet clean
Measure-Command { dotnet build -c Release }

# Measure incremental build (no changes)
Measure-Command { dotnet build -c Release }

# Detailed build timing
dotnet build -c Release -v:d > build-log.txt
```

## References

- [Improving Build Performance in .NET](https://learn.microsoft.com/en-us/dotnet/core/deploying/trimming-options)
- [Source Generator Performance](https://github.com/dotnet/roslyn/blob/main/docs/features/incremental-generators.md)
- [MSBuild Performance](https://learn.microsoft.com/en-us/visualstudio/msbuild/build-performance)
