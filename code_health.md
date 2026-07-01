# Code Health

## Current Validation

- `bash scripts/validate.sh`

The validation script restores, builds, and packs the SDK-style
`WindowsInput/WindowsInput.DotNet.csproj`, checks for vulnerable NuGet packages,
verifies the generated `.nupkg`, and runs DevStudio validation when available.

## CI and Artifacts

- GitHub Actions runs `bash scripts/validate.sh`.
- The generated NuGet package is uploaded as the `windowsinput-dotnet-nuget`
  workflow artifact.

## Platform Boundary

- The SDK-style `WindowsInput.DotNet.csproj` can build and pack on Linux.
- The classic `.NET Framework` and WPF projects in `WindowsInput.sln` remain
  Windows/Visual Studio oriented.
- Runtime input simulation depends on Win32 `SendInput`; Linux validation is
  compile/package validation, not an interactive desktop smoke test.
