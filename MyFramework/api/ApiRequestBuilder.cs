using System.Net.Http;

namespace Velacro.Api {
    /// <summary>
    /// ApiRequestBuilder main class.
    /// This class is used for building http request that sent through ApiClient.
    /// Below is an usage example.
    /// </summary>
    /// <example>
    /// <code>
    /// var requestBuilder = new ApiRequestBuilder();
    /// var request = requestBuilder
    /// .buildHttpRequest()
    /// .addParameters("email", "john@me.com")
    /// .addParameters("password", "password")
    /// .setEndpoint("api/login/")
    /// .setRequestMethod(HttpMethod.Post);
    /// </code>
    /// </example>
    public class ApiRequestBuilder{
        private ApiRequestBundle apiRequestBundle;
        public ApiRequestBuilder(){
        }
        /// <summary>
        /// Get ApiRequestBundle. Invoke this method to get the built ApiRequestBundle.
        /// </summary>
        /// <returns>ApiRequestBundle</returns>
        public ApiRequestBundle getApiRequestBundle(){
            return apiRequestBundle;
        }
        /// <summary>
        /// Build the regular JSON http request.
        /// </summary>
        /// <returns>ApiRequestBuilder</returns>
        public ApiRequestBuilder buildHttpRequest() {
            apiRequestBundle = new ApiRequestBundle();
            apiRequestBundle.setIsMultipart(false);
            return this;
        }
        /// <summary>
        /// Build the MultiPart http request.
        /// </summary>
        /// <param name="_multiPartContent">A MultiPartContent param. (Instantiate)</param>
        /// <returns>ApiRequestBuilder</returns>
        public ApiRequestBuilder buildMultipartRequest(MultiPartContent _multiPartContent){
            apiRequestBundle = new ApiRequestBundle();
            apiRequestBundle.setIsMultipart(true);
            apiRequestBundle.setMultiPartContent(_multiPartContent);
            return this;
        }
        /// <summary>
        /// Add parameters for request.
        /// </summary>
        /// <param name="_name">A string param</param>
        /// <param name="_value">A string param</param>
        /// <returns>ApiRequestBuilder</returns>
        public ApiRequestBuilder addParameters(string _name, string _value) {
            apiRequestBundle.addParameters(_name,_value);
            return this;
        }
        /// <summary>
        /// Add headers for request.
        /// </summary>
        /// <param name="_name">A string param</param>
        /// <param name="_value">A string param</param>
        /// <returns>ApiRequestBuilder</returns>
        public ApiRequestBuilder addHeaders(string _name, string _value) {
            apiRequestBundle.addHeaders(_name,_value);
            return this;
        }

        public ApiRequestBuilder addJSON<T>(T _object){
            apiRequestBundle.addJSON<T>(_object);
            return this;
        }

        public ApiRequestBuilder addStringContent(StringContent _content) {
            apiRequestBundle.addStringContent(_content);            
            return this;
        }

        /// <summary>
        /// Set endpoint for the request.
        /// </summary>
        /// <param name="_endpoint">A string param.</param>
        /// <returns>ApiRequestBuilder</returns>
        public ApiRequestBuilder setEndpoint(string _endpoint) {
            apiRequestBundle.setEndpoint(_endpoint);
            return this;
        }
        /// <summary>
        /// Set the request method.
        /// </summary>
        /// <param name="_httpMethod">A HttpMethod param.</param>
        /// <returns>ApiRequestBuilder</returns>
        public ApiRequestBuilder setRequestMethod(HttpMethod _httpMethod) {
            apiRequestBundle.setRequestMethod(_httpMethod);
            return this;
        }
    }
}
