﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Velacro.DataStructures;

namespace Velacro.Api {
    /// <summary>
    /// ApiClient main class.
    /// </summary>
    /// Below is an usage example for sending regular http request.
    /// <example>
    /// <code>
    /// var client = new ApiClient("http://127.0.0.1:8000/");
    /// var requestBuilder = new ApiRequestBuilder();
    /// string token = "";
    /// var httpRequest = requestBuilder
    /// .buildHttpRequest()
    /// .addParameters("email", "john@me.com")
    /// .addParameters("password", "password")
    /// .setEndpoint("api/login/")
    /// .setRequestMethod(HttpMethod.Post);
    /// var response = await client.sendRequest(httpRequest.getApiRequestBundle());
    /// </code>
    /// </example>
    public class ApiClient {
        private string BASE_URL = "";
        private CoreClient client;
        
        /// <summary>
        /// ApiClient constructor.
        /// </summary>
        /// <param name="_baseUrl">A string base URL param.</param>
        public ApiClient(string _baseUrl){
            client = CoreClient.getInstance();
            BASE_URL = _baseUrl;
            //client.getClient().BaseAddress = new Uri(BASE_URL);
        }
        public ApiClient() {
            client = CoreClient.getInstance();
        }

        private AuthToken token;
        /// <summary>
        /// Set authorization token once. Any request executed with authorization token (Bearer).
        /// </summary>
        /// <param name="_token">A string token param without Bearer.</param>
        public void setAuthorizationToken(string _token){
            token = new AuthToken(_token);
        }

        public void clearAuthorizationToken(){
            token = null;
        }

        public string getAuthorizationToken(){
            if (token != null){
                return token.getToken();
            }
            return "";
        }

        /// <summary>
        /// Get the base URL.
        /// </summary>
        /// <returns>string</returns>
        public string getBaseURL(){
            return BASE_URL; 
        }

        public void setBaseURL(string _baseURL){
            BASE_URL = _baseURL;
        }

        private Action onStartRequest;
        private Action<HttpResponseBundle> onSuccessRequest;
        private Action<HttpResponseBundle> onFailedRequest;
        /// <summary>
        /// Set which method executed when http request is done.
        /// </summary>
        /// <param name="_method">An Action (Method) with HttpResponseBundle param, param. </param>
        public void setOnSuccessRequest(Action<HttpResponseBundle> _method){
            onSuccessRequest = _method;
        }
        /// <summary>
        /// Set which method executed before http request executed.
        /// </summary>
        /// <param name="_method">An Action (Method) param. </param>
        public void setOnStartRequest(Action _method){
            onStartRequest = _method;
        }
        /// <summary>
        /// Set which method executed after http request failed.
        /// </summary>
        /// <param name="_method">An Action (Method) with HttpResponseBundle param, param. </param>
        public void setOnFailedRequest(Action<HttpResponseBundle> _method){
            onFailedRequest = _method;
        }
        /// <summary>
        /// Send http request.
        /// </summary>
        /// <param name="_httpRequestBundle">An ApiRequestBundle param.</param>
        /// <returns>HttpResponseBundle</returns>
        public async Task<HttpResponseBundle> sendRequest(ApiRequestBundle _httpRequestBundle) {
            HttpRequestMessage httpRequestMessage = getHttpRequestMessage(_httpRequestBundle);
            if (token != null) {
                if (token.isAuthenticated()) {
                    token.addAuthToken(httpRequestMessage);
                }
            }
            onStartRequest?.Invoke();
            var response = new HttpResponseBundle(await client.getClient().SendAsync(httpRequestMessage).ConfigureAwait(false));
            if (response.getHttpResponseMessage().IsSuccessStatusCode) {
                onSuccessRequest?.Invoke(response);
                Console.WriteLine(response.getHttpResponseMessage().Content.ReadAsStringAsync());
                return response;
            }
            onFailedRequest?.Invoke(response);
            return new HttpResponseBundle(new HttpResponseMessage(response.getHttpResponseMessage().StatusCode));
        }


        internal HttpRequestMessage getHttpRequestMessage(ApiRequestBundle _apiRequestBundle) {
            if (_apiRequestBundle != null && _apiRequestBundle.isMultipart()) {
                return createMultipartRequest(_apiRequestBundle);
            }
            return createHttpRequest(_apiRequestBundle);
        }
        //sementara NEED REFACTOR
        internal HttpRequestMessage createHttpRequest(ApiRequestBundle _apiRequestBundle) {
            HttpRequestMessage requestMessage = createRequest(_apiRequestBundle);
            if (_apiRequestBundle.getParameters().Count != 0) {
                requestMessage.Content = new StringContent(_apiRequestBundle.getParameters().convertToJSON(), Encoding.UTF8,
                     "application/json");
            }
            if (!String.IsNullOrEmpty(_apiRequestBundle.getJSON())){
                requestMessage.Content = new StringContent(_apiRequestBundle.getJSON(), Encoding.UTF8, "application/json");
            }
            if (_apiRequestBundle.getStringContent() != null){
                requestMessage.Content = _apiRequestBundle.getStringContent();
            }

            return requestMessage;
        }

        internal HttpRequestMessage createMultipartRequest(ApiRequestBundle _apiRequestBundle){
            HttpRequestMessage requestMessage = createRequest(_apiRequestBundle);
            if (_apiRequestBundle.getMultiPartContent() != null){
                 requestMessage.Content = _apiRequestBundle.getMultiPartContent().getMultiPartFormDataContent();
            }
            return requestMessage;
        }

        private HttpRequestMessage createRequest(ApiRequestBundle _apiRequestBundle){
            HttpRequestMessage requestMessage = new HttpRequestMessage();
            MyDictionary<string, string> headers = _apiRequestBundle.getHeaders();
            MyDictionary<string, string> parameters = _apiRequestBundle.getParameters();
            string endpoint = _apiRequestBundle.getEndpoint();
            requestMessage.RequestUri = new Uri(getBaseURL() + endpoint);
            requestMessage.Method = _apiRequestBundle.getHttpMethod();
            if (_apiRequestBundle.getHeaders().Count != 0) {
                foreach (KeyValuePair<string, string> aHeader in headers) {
                    requestMessage.Headers.Add(aHeader.Key, aHeader.Value);
                }
            }
            return requestMessage;
        }
    }
}
