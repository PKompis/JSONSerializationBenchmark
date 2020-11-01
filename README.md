The JSON Serialization Benchmark is a console application with a purpose (as the name describes) to test the performance of the various JSON serializers that exists out there. 

The results may vary for different datasets/test objects, thus the application purpose is NOT to conclude which one is better, as it cannot do so, it is just a simple experiment of mine. Moreover performance is not the only factor which one should consider in order to choose a serializer.


**\*** Console Application should be run in RELEASE mode.  
**\*\*** If you do not have installed R, comment out [this line](https://github.com/PKompis/.NETSerializationBenchmark/blob/main/SerializationBenchmark/Program.cs#L12)

## Libaries used

- [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet)
- [Bogus](https://github.com/bchavez/Bogus)

## Serializers tested
- [Newtonsoft](https://www.newtonsoft.com/json)
- [ServiceStack](https://github.com/ServiceStack/ServiceStack.Text)
- [System.Text.Json](https://www.nuget.org/packages/System.Text.Json)
- [Jil](https://github.com/kevin-montrose/Jil)
- [Utf8Json](https://github.com/neuecc/Utf8Json)

## Object under serialization

Custom object can be found [here](https://github.com/PKompis/JSONSerializationBenchmark/blob/main/SerializationBenchmark/Types/MainTestObject.cs).

## Results

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i5-4670K CPU 3.40GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.1.403
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

```

**NElements** refers to the number of objects that are inserted in the list that is serialized.    

|       Method | NElements |           Mean |        Error |      StdDev |         Median |
|------------- |---------- |---------------:|-------------:|------------:|---------------:|
|   **Newtonsoft** |        **10** |     **1,464.5 μs** |     **29.26 μs** |    **41.97 μs** |     **1,475.8 μs** |
| ServiceStack |        10 |     1,712.7 μs |     34.23 μs |    81.34 μs |     1,653.1 μs |
|  SysTextJson |        10 |     1,391.5 μs |      5.92 μs |     5.54 μs |     1,389.8 μs |
|     Utf8Json |        10 |       713.0 μs |      6.11 μs |     5.71 μs |       711.6 μs |
|          Jil |        10 |       777.4 μs |     15.41 μs |    27.00 μs |       785.4 μs |
|   **Newtonsoft** |       **100** |    **13,046.2 μs** |    **171.10 μs** |   **142.88 μs** |    **13,031.3 μs** |
| ServiceStack |       100 |    15,889.7 μs |    156.26 μs |   146.17 μs |    15,864.3 μs |
|  SysTextJson |       100 |    12,662.1 μs |     25.18 μs |    23.55 μs |    12,660.2 μs |
|     Utf8Json |       100 |     6,810.3 μs |     22.08 μs |    20.65 μs |     6,808.8 μs |
|          Jil |       100 |     6,715.7 μs |    131.64 μs |   161.66 μs |     6,668.2 μs |
|   **Newtonsoft** |      **1000** |   **153,129.4 μs** |  **3,019.71 μs** | **5,889.71 μs** |   **155,266.0 μs** |
| ServiceStack |      1000 |   164,569.5 μs |  1,004.47 μs |   939.58 μs |   164,393.8 μs |
|  SysTextJson |      1000 |   135,658.3 μs |    398.07 μs |   372.36 μs |   135,681.9 μs |
|     Utf8Json |      1000 |    75,579.3 μs |  1,064.30 μs |   943.48 μs |    75,734.3 μs |
|          Jil |      1000 |    63,892.1 μs |  1,086.30 μs | 1,016.13 μs |    63,829.5 μs |
|   **Newtonsoft** |     **10000** | **1,460,715.0 μs** |  **3,676.09 μs** | **3,069.70 μs** | **1,460,992.4 μs** |
| ServiceStack |     10000 | 1,678,962.9 μs |  5,128.65 μs | 4,546.41 μs | 1,678,895.9 μs |
|  SysTextJson |     10000 | 1,560,747.4 μs | 10,022.51 μs | 9,375.06 μs | 1,557,973.6 μs |
|     Utf8Json |     10000 |   838,690.7 μs |  6,651.15 μs | 6,221.49 μs |   839,498.0 μs |
|          Jil |     10000 |   683,038.8 μs |  5,818.18 μs | 5,442.33 μs |   682,807.2 μs |



![alt text](BenchmarkResults.png "Title")

## Source code layout

``` ini
SerializationBenchmark/
├── Program.cs
├── Data/
|   ├── MockData.cs
├── Serialization/
│   ├── Base/
│   |   ├── ISerializationTest.cs
│   |   ├── SerializerTest.cs
│   ├── Implementation/
│   |   ├── JilSerializer.cs
│   |   ├── NewtonsoftSerializer.cs
│   |   ├── ServiceStackSerializer.cs
│   |   ├── SystemTextJsonSerializer.cs
│   |   ├── Utf8JsonSerializer.cs
├── Types/
│   ├── BaseTestObject.cs
│   ├── MainTestObject.cs
│   ├── TestEnum.cs
```

## Authors

- Kompis Panagiotis


## License

This project is licensed under the MIT License see the [LICENSE.md](https://github.com/PKompis/.NETSerializationBenchmark/blob/main/LICENSE) file for details.