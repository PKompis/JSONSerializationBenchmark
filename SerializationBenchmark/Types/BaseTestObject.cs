using System;
using System.Collections.Generic;

namespace SerializationBenchmark.Model
{
    public class BaseTestObject
    {
        public int IntProperty { get; set; }

        public long LongProperty { get; set; }

        public string StringProperty { get; set; }

        public decimal DecimalProperty { get; set; }

        public float FloatProperty { get; set; }

        public double DoubleProperty { get; set; }

        public DateTime DateTimeProperty { get; set; }

        public byte ByteProperty { get; set; }

        public char CharProperty { get; set; }

        public bool BoolProperty { get; set; }

        public Dictionary<string, string> DictionaryProperty { get; set; }

        public TestEnum TestEnum { get; set; }
    }
}
