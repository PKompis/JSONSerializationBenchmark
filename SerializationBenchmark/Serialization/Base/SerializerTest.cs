namespace SerializationBenchmark.Serialization.Interface
{
    /// <summary>
    /// Serialization Test
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class SerializationTest<T> : ISerializationTest<T> where T : class
    {
        /// <summary>
        /// Serializes object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>JSON value</returns>
        public abstract string Serialize(T obj);

        /// <summary>
        /// Deserialize string to a specified object
        /// </summary>
        /// <param name="json"></param>
        /// <returns>Deserialzed value</returns>
        public abstract T Deserialize(string json);

        /// <summary>
        /// Method responsible for serialization/deserialization
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Deserialzed value</returns>
        public T Test(T obj)
        {
            var jsonValue = Serialize(obj);

            return Deserialize(jsonValue);
        }
    }
}
