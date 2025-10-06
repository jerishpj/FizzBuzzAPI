# .NET 8.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that an .NET 8.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 8.0 upgrade.
3. Upgrade JerishPJ.FizzBuzz.Services.Abstractions\JerishPJ.FizzBuzz.Services.Abstractions.csproj
4. Upgrade JerishPJ.FizzBuzz.Services\JerishPJ.FizzBuzz.Services.csproj
5. Upgrade JerishPJ.FizzBuzz.Services.Test\JerishPJ.FizzBuzz.Services.Test.csproj
6. Upgrade JerishPJ.FizzBuzz.WebAPI\JerishPJ.FizzBuzz.WebAPI.csproj
7. Run unit tests to validate upgrade in the projects listed below:
   - JerishPJ.FizzBuzz.Services.Test\JerishPJ.FizzBuzz.Services.Test.csproj

## Settings

This section contains settings and data used by execution steps.

### Excluded projects

| Project name | Description |
|:-------------------------------|:---------------------------:|

### Aggregate NuGet packages modifications across all projects

### Project upgrade details

#### JerishPJ.FizzBuzz.Services.Abstractions\JerishPJ.FizzBuzz.Services.Abstractions.csproj modifications

Project properties changes:
  - Target framework should be changed from `netstandard2.0` to `net8.0`

#### JerishPJ.FizzBuzz.Services\JerishPJ.FizzBuzz.Services.csproj modifications

Project properties changes:
  - Target framework should be changed from `netstandard2.0` to `net8.0`

#### JerishPJ.FizzBuzz.Services.Test\JerishPJ.FizzBuzz.Services.Test.csproj modifications

Project properties changes:
  - Target framework should be changed from `netcoreapp3.1` to `net8.0`

#### JerishPJ.FizzBuzz.WebAPI\JerishPJ.FizzBuzz.WebAPI.csproj modifications

Project properties changes:
  - Target framework should be changed from `netcoreapp3.1` to `net8.0`
