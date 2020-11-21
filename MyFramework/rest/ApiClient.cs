using RestSharp;
using RestSharp.Authenticators;

namespace Velacro.rest {
    public class ApiClient{
        private RestClient client;

        public ApiClient(){ }

        public ApiClient(string _baseUrl){
            client = new RestClient(_baseUrl);
        }

        public void setAuthenticator(IAuthenticator _authenticator){
            client.Authenticator = _authenticator;
            
        }

        public IRestResponse sendRequest(IRestRequest _request){
            var response = client.Execute(_request);
            return response;
        }
    }
}
