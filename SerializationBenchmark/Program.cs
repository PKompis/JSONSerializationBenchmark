using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Running;
using SerializationBenchmark.Data;
using SerializationBenchmark.Model;
using SerializationBenchmark.Serialization.Implementation;
using SerializationBenchmark.Serialization.Interface;
using System.Collections.Generic;

namespace SerializationBenchmark
{
    [RPlotExporter]
    public class SerializationTest
    {
        private const int NElements = 10000;
        private const int NNestedElements = 10;

        private readonly Consumer consumer = new Consumer();

        private readonly IEnumerable<MainTestObject> _data;
        private readonly ISerializationTest<IEnumerable<MainTestObject>> _newtonsoftSerializer;
        private readonly ISerializationTest<IEnumerable<MainTestObject>> _serviceStackSerializer;
        private readonly ISerializationTest<IEnumerable<MainTestObject>> _systemTextJsonSerializer;
        private readonly ISerializationTest<IEnumerable<MainTestObject>> _utf8JsonSerializer;
        private readonly ISerializationTest<IEnumerable<MainTestObject>> _jilSerializer;

        public SerializationTest()
        {
            _data = MockData.Create(NElements, NNestedElements);
            _newtonsoftSerializer = new NewtonsoftSerializer<IEnumerable<MainTestObject>>();
            _serviceStackSerializer = new ServiceStackSerializer<IEnumerable<MainTestObject>>();
            _systemTextJsonSerializer = new SystemTextJsonSerializer<IEnumerable<MainTestObject>>();
            _utf8JsonSerializer = new Utf8JsonSerializer<IEnumerable<MainTestObject>>();
            _jilSerializer = new JilSerializer<IEnumerable<MainTestObject>>();
        }

        [Benchmark]
        public void NewtonsoftSerialization() => _newtonsoftSerializer.Test(_data).Consume(consumer);

        [Benchmark]
        public void ServiceStackSerialization() => _serviceStackSerializer.Test(_data).Consume(consumer);

        [Benchmark]
        public void SystemTextJsonSerialization() => _systemTextJsonSerializer.Test(_data).Consume(consumer);

        [Benchmark]
        public void Utf8JsonSerialization() => _utf8JsonSerializer.Test(_data).Consume(consumer);


        [Benchmark]
        public void JilSerialization() => _jilSerializer.Test(_data).Consume(consumer);
    }


    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SerializationTest>();
        }
    }
}
