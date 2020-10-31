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

        public SerializationTest()
        {
            _data = MockData.Create(NElements, NNestedElements);
            _newtonsoftSerializer = new NewtonsoftSerializer<IEnumerable<MainTestObject>>();
            _serviceStackSerializer = new ServiceStackSerializer<IEnumerable<MainTestObject>>();
        }

        [Benchmark]
        public void NewtonsoftSerialization() => _newtonsoftSerializer.Test(_data).Consume(consumer);

        [Benchmark]
        public void ServiceStackSerialization() => _newtonsoftSerializer.Test(_data).Consume(consumer);
    }


    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SerializationTest>();
        }
    }
}
