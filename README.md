# Fareast

[![main](https://github.com/ng8eke/fareast/actions/workflows/main.yml/badge.svg)](https://github.com/ng8eke/fareast/actions/workflows/main.yml)
[![travis](https://travis-ci.com/ng8eke/fareast.svg?branch=master)](https://travis-ci.com/github/ng8eke/fareast)
[![MIT License](https://img.shields.io/github/license/ng8eke/fareast.svg)](https://github.com/ng8eke/fareast/blob/master/LICENSE)
========
<!-- [![appveyor](https://ci.appveyor.com/api/projects/status/ux13ive7vhsg32el/branch/master?svg=true)](https://ci.appveyor.com/project/ng8eke/fareast/branch/master) -->

This library is a rust port of [spotify/annoy](https://github.com/spotify/annoy) , currently only index serving is supported.

It also provides [FFI bindings](https://github.com/ng8eke/fareast#ffi-support) for [jvm](https://github.com/ng8eke/fareast#kotlinjava), [dotnet](https://github.com/ng8eke/fareast#dotnet) and [dart](https://github.com/ng8eke/fareast#dart)

Metric | Serve | Build | jvm Binding | dotnet Binding | dart Binding
| :--- | :---: | ---: | -- | -- | -- |
Angular | ✅ | ❌ | ✅ | ✅ | ✅
Euclidean | ✅ | ❌ | ✅ | ✅ | ✅
Manhattan | ✅ | ❌ | ✅ | ✅ | ✅
Dot | ✅ | ❌ | ✅ | ✅ | ✅
Hamming | ❌ | ❌ | ❌ | ❌  | ❌

### Install via [crates.io](https://crates.io/crates/annoy-rs)
[![Crates.io](https://img.shields.io/crates/v/annoy-rs.svg)](https://crates.io/crates/annoy-rs)
[![codecov](https://codecov.io/gh/ng8eke/fareast/branch/master/graph/badge.svg?token=jVO7N0AVTH)](https://codecov.io/gh/ng8eke/fareast)
```toml
# Cargo.toml
[dependencies]
annoy-rs = "0"
```

### Usage
```rust
use annoy_rs::*;

let index = AnnoyIndex::load(10, "index.ann", IndexType::Angular).unwrap();
let v0 = index.get_item_vector(0);
let nearest = index.get_nearest(v0.as_ref(), 5, -1, true);
```

## FFI support

### kotlin/java

It uses JNI bindings to rust crate and is ~5-10x faster than [pure java implementation](https://github.com/spotify/annoy-java) in [benchmark scenario](https://github.com/ng8eke/fareast/tree/master/bench)
#### Install via [jitpack.io](https://jitpack.io/#ng8eke/fareast)
[![Release](https://jitpack.io/v/ng8eke/fareast.svg)](https://jitpack.io/#ng8eke/fareast)
```gradle
repositories {
  mavenCentral()
  maven { url 'https://jitpack.io' }
}
  
dependencies {
  implementation 'com.github.ng8eke:Fareast:<tag>'
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
    <PackageReference Include="Fareast" Version="*" />
    <PackageReference Include="Fareast-Batteries-Windows-x64" Version="*" />
  </ItemGroup>
```
#### Usage
```csharp
var index = AnnoyIndex.Load("index.5d.ann", 5, IndexType.Angular);
```

### dart

#### Install via [pub.dev](https://pub.dev/packages/dart_native_annoy)

```yaml
# pubspec.yaml
dependencies:
  dart_native_annoy: ^0.1.0
```
#### Usage
```dart
import 'dart:ffi';
import 'package:dart_native_annoy/annoy.dart';

/// Creat factory from DynamicLibrary
final fac = AnnoyIndexFactory(lib: DynamicLibrary.open('libannoy_rs.so'));

/// Load index
final index = indexFactory.loadIndex(
      'index.euclidean.5d.ann', 5, IndexType.Euclidean)!;

print('size: ${index.size}');

final v3 = index.getItemVector(3);

final nearest = index.getNearest(v0, 5, includeDistance: true);
```


## TODO
+ Index building support
+ CLI tool to build index from file
