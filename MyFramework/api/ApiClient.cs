using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MyFramework.datastructures;

namespace MyFramework.api {
    public class ApiClient {
        private string BASE_URL = "";
        private static HttpClient client;
        private ApiClient(string _baseUrl){
            
        }

        public static HttpClient getClient(){
            if (client != null){
                client = new HttpClient();
            }
            return client;
        }

        public void setBaseURL(string _baseUrl){
            BASE_URL = _baseUrl;
            client.BaseAddress = new Uri(BASE_URL);
        }
        private AuthToken token;

        public void setAuthorizationToken(string _token){
            token = new AuthToken(_token);
        }

        public string getBaseURL(){
            return BASE_URL; 
        }

        private Action onStartRequest;
        private Action<HttpResponseBundle> onSuccessRequest;
        private Action<HttpResponseBundle> onFailedRequest;
        
        public void setOnSuccessRequest(Action<HttpResponseBundle> _method){
            onSuccessRequest = _method;
        }

        public void setOnStartRequest(Action _method){
            onStartRequest = _method;
        }

        public void setOnFailedRequest(Action<HttpResponseBundle> _method){
            onFailedRequest = _method;
        }

        public async Task<HttpResponseBundle> sendRequest(ApiRequestBundle _httpRequestBundle) {
            HttpRequestMessage httpRequestMessage = getHttpRequestMessage(_httpRequestBundle);
            if (token != null) {
                if (token.isAuthenticated()) {
                    token.addAuthToken(httpRequestMessage);
                }
            }
            onStartRequest?.Invoke();
            var response = new HttpResponseBundle(await client.SendAsync(httpRequestMessage).ConfigureAwait(false));
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

        internal HttpRequestMessage createHttpRequest(ApiRequestBundle _apiRequestBundle) {
            HttpRequestMessage requestMessage = createRequest(_apiRequestBundle);
            if (_apiRequestBundle.getParameters().Count != 0) {
                requestMessage.Content = new StringContent(_apiRequestBundle.getParameters().convertToJSON(), Encoding.UTF8,
                     "application/json");
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
