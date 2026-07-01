#!/usr/bin/env bash
set -euo pipefail

repo_root="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
cd "$repo_root"

package_dir="$repo_root/artifacts/packages"
rm -rf "$package_dir"
mkdir -p "$package_dir"

dotnet restore WindowsInput/WindowsInput.DotNet.csproj
dotnet build WindowsInput/WindowsInput.DotNet.csproj --configuration Release --no-restore
dotnet pack WindowsInput/WindowsInput.DotNet.csproj --configuration Release --no-build --output "$package_dir"
dotnet list WindowsInput/WindowsInput.DotNet.csproj package --vulnerable --include-transitive

package_path="$package_dir/WindowsInput.DotNet.1.0.0.nupkg"
if [[ ! -s "$package_path" ]]; then
  echo "Missing package artifact: ${package_path#$repo_root/}" >&2
  exit 1
fi

if command -v devstudio >/dev/null 2>&1; then
  devstudio validate --repo "$repo_root"
else
  echo "devstudio not available; skipped DevStudio validation"
fi
