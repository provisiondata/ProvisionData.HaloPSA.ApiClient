# NuGet Publishing Instructions (RC and Release)

This repository uses GitHub Actions and Nerdbank.GitVersioning (NB.GV) for semantic versioning and publishing.

## Prerequisites:

- Ensure `NUGET_USER` and `NUGET_API_KEY` are configured in GitHub repository secrets.
- Main branch is protected and green.

## Release Candidate (RC):

1. Choose the target version (e.g., 1.2.0-rc.1).
2. Create a git tag and push:
   - `git tag v1.2.0-rc.1`
   - `git push origin v1.2.0-rc.1`
3. GitHub Actions will build and pack. The publish job runs on tags and pushes the package to NuGet.
4. If another RC is needed, bump the suffix: `v1.2.0-rc.2`.

## Stable Release:

1. Merge changes to `main` and ensure CI passes.
2. Create and push a version tag without prerelease label:
   - `git tag v1.2.0`
   - `git push origin v1.2.0`
3. GitHub Actions will build, pack, and publish to NuGet.

## Notes:

- NB.GV derives the package version from `version.json` and git tags.
- For non-publishing CI (pull requests, pushes to `main`), the workflow runs build/test/pack but does not push to NuGet.
- Use `dotnet pack -c Release /p:ContinuousIntegrationBuild=true` locally to verify packages before tagging.
