namespace SerializationBenchmark.Serialization.Interface
{
    /// <summary>
    /// Serialization test base interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISerializationTest<T> where T : class
    {
        /// <summary>
        /// Serializes object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>JSON value</returns>
        string Serialize(T obj);

        /// <summary>
        /// Deserialize string to a specified object
        /// </summary>
        /// <param name="json"></param>
        /// <returns>Deserialzed value</returns>
        T Deserialize(string json);

        /// <summary>
        /// Method responsible for serialization/deserialization
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        T Test(T obj);
    }
}
