# Fareast

[![main](https://github.com/ng8eke/fareast/actions/workflows/main.yml/badge.svg)](https://github.com/ng8eke/fareast/actions/workflows/main.yml)
[![Build status](https://img.shields.io/appveyor/ci/ng8eke/fareast/master.svg)](https://ci.appveyor.com/project/ng8eke/fareast)
[![Crates.io](https://img.shields.io/crates/v/ru_annoy.svg)](https://crates.io/crates/ru_annoy)
[![Coverage Status](https://coveralls.io/repos/github/ng8eke/fareast/badge.svg?branch=master)](https://coveralls.io/github/ng8eke/fareast?branch=master)
[![MIT License](https://img.shields.io/github/license/ng8eke/fareast.svg)](https://github.com/ng8eke/fareast/blob/master/LICENSE)
========
<!-- [![Build Status](https://img.shields.io/travis/ng8eke/fareast/master.svg)](https://travis-ci.org/ng8eke/fareast) -->

This library is a rust port of https://github.com/spotify/annoy , currently only index serving part is implemented

## Usage
```rust
use ru_annoy::*;

let index = AnnoyIndex::load(10, "index.ann", IndexType::Angular).unwrap();
let v0 = index.get_item_vector(0);
let nearest = index.get_nearest(v0.as_ref(), 5, -1, true);
```

## FFI support

### kotlin/java

#### Install via [jitpack.io](https://jitpack.io/#ng8eke/fareast)
[![Release](https://jitpack.io/v/ng8eke/fareast.svg)](https://jitpack.io/#ng8eke/fareast)
```gradle
repositories {
  mavenCentral()
  maven { url 'https://jitpack.io' }
}
  
dependencies {
  implementation 'com.github.ng8eke:Fareast:0.1.2+1'
}
```
#### Usage
```kotlin
val index = AnnoyIndex.tryLoad("index.5d.ann", 5, IndexType.Angular)
```

### dotnet

| Runtimes                      | Nuget package                                                                                                                                 |
| ----------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------- |
| Fareast                       | [![NuGet version](https://buildstats.info/nuget/Fareast)](https://www.nuget.org/packages/Fareast)                                             |
| Fareast-Batteries-Windows-x64 | [![NuGet version](https://buildstats.info/nuget/Fareast-Batteries-Windows-x64)](https://www.nuget.org/packages/Fareast-Batteries-Windows-x64) |
| Fareast-Batteries-Linux-x64   | [![NuGet version](https://buildstats.info/nuget/Fareast-Batteries-Linux-x64)](https://www.nuget.org/packages/Fareast-Batteries-Linux-x64)     |
| Fareast-Batteries-Darwin-x64  | [![NuGet version](https://buildstats.info/nuget/Fareast-Batteries-Darwin-x64)](https://www.nuget.org/packages/Fareast-Batteries-Darwin-x64)   |

#### Install via nuget
```xml
  <ItemGroup>
    <PackageReference Include="Fareast" />
    <PackageReference Include="Fareast-Batteries-Windows-x64" />
  </ItemGroup>
```
#### Usage
```csharp
var index = AnnoyIndex.Load("index.5d.ann", 5, IndexType.Angular);
```
