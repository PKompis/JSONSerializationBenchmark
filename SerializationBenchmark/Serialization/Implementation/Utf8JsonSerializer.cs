using SerializationBenchmark.Serialization.Interface;

namespace SerializationBenchmark.Serialization.Implementation
{
    /// <summary>
    /// Utf8Json Serializer
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Utf8JsonSerializer<T> : SerializationTest<T> where T : class
    {
        /// <summary>
        /// Serializes object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>JSON value</returns>
        public override string Serialize(T obj)
        {
            return Utf8Json.JsonSerializer.ToJsonString(obj);
        }
        /// <summary>
        /// Deserialize string to a specified object
        /// </summary>
        /// <param name="json"></param>
        public override T Deserialize(string json)
        {
            return Utf8Json.JsonSerializer.Deserialize<T>(json);
        }
    }
}
