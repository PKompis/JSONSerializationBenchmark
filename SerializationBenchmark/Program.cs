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
        [Params(10, 100, 1000, 10000)]
        public int NElements; //Params are public (SerializationBenchmark requirement).

        private const int NNestedElements = 10;

        private readonly Consumer consumer = new Consumer();

        private IEnumerable<MainTestObject> _data;
        private ISerializationTest<IEnumerable<MainTestObject>> _newtonsoftSerializer;
        private ISerializationTest<IEnumerable<MainTestObject>> _serviceStackSerializer;
        private ISerializationTest<IEnumerable<MainTestObject>> _systemTextJsonSerializer;
        private ISerializationTest<IEnumerable<MainTestObject>> _utf8JsonSerializer;
        private ISerializationTest<IEnumerable<MainTestObject>> _jilSerializer;

        [GlobalSetup]
        public void Setup()
        {
            _data = MockData.Create(NElements, NNestedElements);
            _newtonsoftSerializer = new NewtonsoftSerializer<IEnumerable<MainTestObject>>();
            _serviceStackSerializer = new ServiceStackSerializer<IEnumerable<MainTestObject>>();
            _systemTextJsonSerializer = new SystemTextJsonSerializer<IEnumerable<MainTestObject>>();
            _utf8JsonSerializer = new Utf8JsonSerializer<IEnumerable<MainTestObject>>();
            _jilSerializer = new JilSerializer<IEnumerable<MainTestObject>>();
        }

        [Benchmark]
        public void Newtonsoft() => _newtonsoftSerializer.Test(_data).Consume(consumer);

        [Benchmark]
        public void ServiceStack() => _serviceStackSerializer.Test(_data).Consume(consumer);

        [Benchmark]
        public void SysTextJson() => _systemTextJsonSerializer.Test(_data).Consume(consumer);

        [Benchmark]
        public void Utf8Json() => _utf8JsonSerializer.Test(_data).Consume(consumer);


        [Benchmark]
        public void Jil() => _jilSerializer.Test(_data).Consume(consumer);
    }


    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SerializationTest>();
        }
    }
}
