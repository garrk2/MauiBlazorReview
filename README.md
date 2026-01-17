
# DoublesMatch2 – .NET MAUI Blazor Hybrid Skeleton (NET 9)

This variant targets **.NET 9** and MAUI 9 to avoid out-of-support workload warnings for net8.0. It includes the same UI as the original skeleton.

## Run (Windows first)
1. Install Visual Studio 2022 17.13+ with **.NET MAUI (9)** workload.
2. Open `DoublesMatch2.csproj`.
3. Select **Windows Machine** and press **F5**.

## Android
- Install **Android 14 (API 34)** in the Android SDK Manager.
- The manifest targets 34; you can adjust min/target in `Platforms/Android/AndroidManifest.xml`.

## Notes
- We pin SDK to **9.0.101** via `global.json`. Change or remove if you want to use the latest.
