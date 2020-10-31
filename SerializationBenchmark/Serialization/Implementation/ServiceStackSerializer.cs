using SerializationBenchmark.Serialization.Interface;
using ServiceStack.Text;

namespace SerializationBenchmark.Serialization.Implementation
{
    public class ServiceStackSerializer<T> : SerializationTest<T> where T : class
    {
        /// <summary>
        /// Serializes object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>JSON value</returns>
        public override string Serialize(T obj)
        {
            return JsonSerializer.SerializeToString<T>(obj);
        }
        /// <summary>
        /// Deserialize string to a specified object
        /// </summary>
        /// <param name="json"></param>
        public override T Deserialize(string json)
        {
            return JsonSerializer.DeserializeFromString<T>(json);
        }
    }
}
