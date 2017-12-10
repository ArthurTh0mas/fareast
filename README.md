# Fareast

[![Build Status](https://img.shields.io/travis/ng8eke/fareast/master.svg)](https://travis-ci.org/ng8eke/fareast)
[![Build status](https://img.shields.io/appveyor/ci/ng8eke/fareast/master.svg)](https://ci.appveyor.com/project/ng8eke/fareast)
![Crates.io](https://img.shields.io/crates/v/ru_annoy.svg)
[![MIT License](https://img.shields.io/github/license/ng8eke/fareast.svg)](https://github.com/ng8eke/fareast/blob/master/LICENSE)
========

This library is a rust port of https://github.com/spotify/annoy , currently only index serving part is implemented

## FFI support
### dotnet nuget packages

| Runtimes                      | Nuget package                                                                                                                                 |
| ----------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------- |
| Fareast                       | [![NuGet version](https://buildstats.info/nuget/Fareast)](https://www.nuget.org/packages/Fareast)                                             |
| Fareast-Batteries-Windows-x64 | [![NuGet version](https://buildstats.info/nuget/Fareast-Batteries-Windows-x64)](https://www.nuget.org/packages/Fareast-Batteries-Windows-x64) |
| Fareast-Batteries-Linux-x64   | [![NuGet version](https://buildstats.info/nuget/Fareast-Batteries-Linux-x64)](https://www.nuget.org/packages/Fareast-Batteries-Linux-x64)     |
| Fareast-Batteries-Darwin-x64  | TODO                                                                                                                                          |

#### Installation
```xml
  <ItemGroup>
    <PackageReference Include="Fareast" />
    <PackageReference Include="Fareast-Batteries-Windows-x64" />
  </ItemGroup>
```
