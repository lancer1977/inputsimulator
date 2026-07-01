# Project Atlas

`inputsimulator` is a Windows input simulation library wrapping the Win32
`SendInput` API.

## Primary Surfaces

- Modern package/build surface: `WindowsInput/WindowsInput.DotNet.csproj`
- Legacy solution: `WindowsInput.sln`
- Classic .NET Framework library: `WindowsInput/WindowsInput.csproj`
- WPF sample client: `WindowsInput.SampleClient.Wpf/`
- Legacy NUnit tests: `WindowsInput.Tests/`

## Validation

- Standard repo validation: `bash scripts/validate.sh`
- Windows-only legacy validation: open/build `WindowsInput.sln` in Visual
  Studio or MSBuild on Windows when changing the classic projects.

## Artifact

- `artifacts/packages/WindowsInput.DotNet.1.0.0.nupkg`
