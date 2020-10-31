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

|         Method | NElements |           Mean |        Error |       StdDev |
|--------------- |---------- |---------------:|-------------:|-------------:|
|     **Newtonsoft** |        **10** |     **1,450.7 μs** |     **15.71 μs** |     **14.69 μs** |
|   ServiceStack |        10 |     1,589.0 μs |      2.45 μs |      2.05 μs |
| SystemTextJson |        10 |     1,402.7 μs |      4.43 μs |      4.15 μs |
|       Utf8Json |        10 |       704.5 μs |      6.39 μs |      5.67 μs |
|            Jil |        10 |       771.1 μs |     14.30 μs |     18.59 μs |
|     **Newtonsoft** |       **100** |    **13,178.6 μs** |    **187.20 μs** |    **175.10 μs** |
|   ServiceStack |       100 |    16,080.3 μs |    198.66 μs |    176.11 μs |
| SystemTextJson |       100 |    12,937.8 μs |    157.57 μs |    147.40 μs |
|       Utf8Json |       100 |     6,866.0 μs |     34.42 μs |     32.19 μs |
|            Jil |       100 |     6,512.5 μs |    129.85 μs |    121.46 μs |
|     **Newtonsoft** |      **1000** |   **154,234.5 μs** |  **2,998.82 μs** |  **4,203.92 μs** |
|   ServiceStack |      1000 |   162,711.8 μs |  1,111.54 μs |  1,039.73 μs |
| SystemTextJson |      1000 |   140,517.9 μs |    968.19 μs |    905.64 μs |
|       Utf8Json |      1000 |    75,343.0 μs |  1,020.36 μs |    904.52 μs |
|            Jil |      1000 |    63,998.6 μs |    904.10 μs |    845.70 μs |
|     **Newtonsoft** |     **10000** | **1,498,441.2 μs** | **18,720.83 μs** | **16,595.53 μs** |
|   ServiceStack |     10000 | 1,653,251.8 μs |  4,527.61 μs |  4,235.13 μs |
| SystemTextJson |     10000 | 1,514,409.9 μs | 11,924.56 μs | 11,154.24 μs |
|       Utf8Json |     10000 |   844,954.6 μs |  8,255.92 μs |  7,722.59 μs |
|            Jil |     10000 |   687,010.1 μs |  6,562.35 μs |  6,138.43 μs |


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