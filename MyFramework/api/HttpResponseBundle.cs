using System.Net.Http;
using Newtonsoft.Json.Linq;
using Velacro.DataStructures;

namespace Velacro.Api {
    /// <summary>
    /// HttpResponseBundle main class.
    /// This class is returned from ApiClient send request response.
    /// </summary>
    public class HttpResponseBundle{
       
        public HttpResponseBundle(HttpResponseMessage _message){
            httpResponseMessage = _message;
        }

        private HttpResponseMessage httpResponseMessage;

        public HttpResponseMessage getHttpResponseMessage(){
            return httpResponseMessage;
        }

        internal void setHttpResponseMessage(HttpResponseMessage _httpResponseMessage){
            httpResponseMessage = _httpResponseMessage;
        }
        /// <summary>
        /// Get the parsed object from the response JSON string.
        /// </summary>
        /// <example>
        /// <code>
        /// class Model {
        ///     public int id { get; set; }
        ///     public string name { get; set; }
        /// }
        ///  
        /// var response = await client.sendRequest(httpRequest.getApiRequestBundle());
        /// Model model = response.getParsedObject<Model>();
        /// </code>
        /// </example>
        /// <typeparam name="T">A generic param. Adjust with your needs</typeparam>
        /// <returns>T</returns>
        public T getParsedObject<T>(){
            return JSONOperation.parseJSON<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }
        /// <summary>
        /// Get JOBject from the response JSON string.
        /// This function returns value from assigned JSON Key where the JSON is the server http response.
        /// </summary>
        /// <example>
        /// {
        ///     "id":"1"
        ///     "name":"John"
        /// }
        /// <code>
        /// var response = await client.sendRequest(httpRequest.getApiRequestBundle());
        /// string value = response.getJObject()["name"];
        /// Console.WriteLine(value);
        /// </code>
        /// </example>
        /// Output :
        /// John
        /// <returns>JObject</returns>
        public JObject getJObject(){
            return JObject.Parse(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }
    }
}
