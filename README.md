# JSONSerializationBenchmark

The JSON Serialization Benchmark is a console application with a purpose (as the name describes) to test the performance of the various JSON serializers that exists out there.

##### Console Application should be run in RELEASE mode.
##### If you do not have installed R comment out [this line](https://github.com/PKompis/.NETSerializationBenchmark/blob/main/SerializationBenchmark/Program.cs#L12)


## Libaries used

- [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet)
- [Bogus](https://github.com/bchavez/Bogus)

## Serializers Tested
- [Newtonsoft](https://www.newtonsoft.com/json)
- [ServiceStack](https://github.com/ServiceStack/ServiceStack.Text)
- [System.Text.Json](https://www.nuget.org/packages/System.Text.Json)

## Results

``` ini
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i5-4670K CPU 3.40GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.1.403
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

```
|                      Method |    Mean |    Error |   StdDev |
|---------------------------- |--------:|---------:|---------:|
|     NewtonsoftSerialization | 1.274 s | 0.0249 s | 0.0233 s |
|   ServiceStackSerialization | 1.480 s | 0.0115 s | 0.0102 s |
| SystemTextJsonSerialization | 1.372 s | 0.0102 s | 0.0095 s |



![alt text](Results.png "Title")


## Source code directory layout:

<pre>
SerializationBenchmark/
├── Program.cs
├── Data/
|   ├── MockData.cs
├── Serialization/
│   ├── Base/
│   |   ├── ISerializationTest.cs
│   |   ├── SerializerTest.cs
│   ├── Implementation/
│   |   ├── NewtonsoftSerializer.cs
│   |   ├── ServiceStackSerializer.cs
│   |   ├── SystemTextJsonSerializer.cs
├── Types/
│   ├── BaseTestObject.cs
│   ├── MainTestObject.cs
│   ├── TestEnum.cs
</pre>

## Authors

- Kompis Panagiotis


## License

This project is licensed under the MIT License see the [LICENSE.md](https://github.com/PKompis/.NETSerializationBenchmark/blob/main/LICENSE) file for details.