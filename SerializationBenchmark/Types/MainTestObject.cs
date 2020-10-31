using System.Collections.Generic;

namespace SerializationBenchmark.Model
{
    public class MainTestObject : BaseTestObject
    {
        public IEnumerable<BaseTestObject> NestedObject { get; set; }
    }
}
