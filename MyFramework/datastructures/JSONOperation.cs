using Newtonsoft.Json;

namespace MyFramework.datastructures {
    /// <summary>
    /// Main class of JSONConverter
    /// </summary>
    public class JSONOperation{
        /// <summary>
        /// Parse the JSON string into the class object. 
        /// </summary>
        /// <example>
        /// <code>
        /// public class TestModel {
        ///    [JsonProperty(PropertyName = "name")]
        ///    public string name { get; set; }
        ///    [JsonProperty(PropertyName = "email")]
        ///    public string email { get; set; }
        ///    [JsonProperty(PropertyName = "address")]
        ///    public string address { get; set; }
        /// }
        /// string testJson = @"{
        ///                         ""name"":""someName"",
        ///                         ""email"":""some@some.com"",
        ///                         ""address"":""somewhere""
        ///                   }";
        ///         
        /// TestModel testModel = JSONOperation.convertFromJSONString<TestModel>(testJson);
        /// </code>
        /// </example>
        /// <typeparam name="T"></typeparam>
        /// <param name="_json">A JSON string param.</param>
        /// <returns>T</returns>
        public static T parseJSON<T>(string _json){
            T obj = (T)JsonConvert.DeserializeObject<T>(_json);
            return obj;
        }
        /// <summary>
        /// Parse the object into JSON string. 
        /// </summary>
        /// <example>
        /// <code>
        /// public class TestModel {
        ///    [JsonProperty(PropertyName = "name")]
        ///    public string name { get; set; }
        ///    [JsonProperty(PropertyName = "email")]
        ///    public string email { get; set; }
        ///    [JsonProperty(PropertyName = "address")]
        ///    public string address { get; set; }
        /// }
        /// TestModel testModel = new TestModel() {
        ///     name    = "Some",
        ///     email   = "some@some.com",
        ///     address = "somewhere"
        /// };
        ///         
        /// string jsonString = JSONOperation.convertToJSONString<TestModel>(testModel);
        /// </code>
        /// </example>
        /// Output
        /// <code>
        /// {
        ///     "name":"someName",
        ///     "email":some@some.com",
        ///     "address"":"somewhere"
        /// }
        /// </code>
        /// <typeparam name="T"></typeparam>
        /// <param name="_json">A JSON string param.</param>
        /// <returns>T</returns>
        public static string convertToJSONString<T>(T _object){
            string JSONString = JsonConvert.SerializeObject(_object, Formatting.Indented);
            return JSONString;
        }
    }
}
