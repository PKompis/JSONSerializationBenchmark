using Newtonsoft.Json;
using SerializationBenchmark.Serialization.Interface;

namespace SerializationBenchmark.Serialization.Implementation
{
    public class NewtonsoftSerializer<T> : SerializationTest<T> where T : class
    {
        /// <summary>
        /// Serializes object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>JSON value</returns>
        public override string Serialize(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        /// <summary>
        /// Deserialize string to a specified object
        /// </summary>
        /// <param name="json"></param>
        public override T Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
