# .NETSerializationBenchmark

The .NET Serialization Benchmark is a console application with a purpose (as the name describes) to test the performance of the various serializers that exists out there.

##### Console Application should be run in RELEASE mode.

## Libaries used

- [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet)
- [Bogus](https://github.com/bchavez/Bogus)

## Serializers Tested
- [Newtonsoft](https://www.newtonsoft.com/json)

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
├── Types/
│   ├── BaseTestObject.cs
│   ├── MainTestObject.cs
│   ├── TestEnum.cs
</pre>

## Authors

- Kompis Panagiotis


## License

This project is licensed under the MIT License see the [LICENSE.md](https://github.com/PKompis/.NETSerializationBenchmark/blob/main/LICENSE) file for details.