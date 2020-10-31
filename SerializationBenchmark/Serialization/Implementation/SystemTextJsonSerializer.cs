using SerializationBenchmark.Serialization.Interface;
using System.Text.Json;

namespace SerializationBenchmark.Serialization.Implementation
{
    /// <summary>
    /// System.Text.Json Serializer
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SystemTextJsonSerializer<T> : SerializationTest<T> where T : class
    {
        /// <summary>
        /// Serializes object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>JSON value</returns>
        public override string Serialize(T obj)
        {
            return JsonSerializer.Serialize(obj);
        }
        /// <summary>
        /// Deserialize string to a specified object
        /// </summary>
        /// <param name="json"></param>
        public override T Deserialize(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
