using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace MyFramework.rest {
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
