using Jil;
using SerializationBenchmark.Serialization.Interface;

namespace SerializationBenchmark.Serialization.Implementation
{
    /// <summary>
    /// Jil Serializer
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JilSerializer<T> : SerializationTest<T> where T : class
    {
        /// <summary>
        /// Serializes object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>JSON value</returns>
        public override string Serialize(T obj)
        {
            return JSON.Serialize(obj);
        }
        /// <summary>
        /// Deserialize string to a specified object
        /// </summary>
        /// <param name="json"></param>
        public override T Deserialize(string json)
        {
            return JSON.Deserialize<T>(json);
        }
    }
}
