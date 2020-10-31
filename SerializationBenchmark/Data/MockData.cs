using Bogus;
using SerializationBenchmark.Model;
using System;
using System.Collections.Generic;

namespace SerializationBenchmark.Data
{
    public static class MockData
    {
        public static IEnumerable<MainTestObject> Create(int elements, int nestedElements)
        {
            //Set the randomizer seed if you wish to generate repeatable data sets.
            Randomizer.Seed = new Random(8675309);

            var baseObject = new Faker<MainTestObject>();
            var mainTestObject = new Faker<MainTestObject>();

            SetRules(baseObject);
            SetRules(mainTestObject)
                .RuleFor(o => o.NestedObject, f => baseObject.Generate(nestedElements));


            return mainTestObject.Generate(elements);

        }

        private static Faker<MainTestObject> SetRules(Faker<MainTestObject> obj)
        {
            obj.RuleFor(o => o.BoolProperty, f => f.Random.Bool())
                .RuleFor(o => o.ByteProperty, f => f.Random.Byte())
                .RuleFor(o => o.CharProperty, f => f.Random.Char())
                .RuleFor(o => o.DateTimeProperty, f => new DateTime(2, 2, 2))
                .RuleFor(o => o.DecimalProperty, f => f.Random.Decimal())
                .RuleFor(o => o.DoubleProperty, f => f.Random.Double())
                .RuleFor(o => o.FloatProperty, f => f.Random.Float())
                .RuleFor(o => o.IntProperty, f => f.Random.Int())
                .RuleFor(o => o.LongProperty, f => f.Random.Long())
                .RuleFor(o => o.StringProperty, f => f.Random.String());

            return obj;
        }
    }
}
