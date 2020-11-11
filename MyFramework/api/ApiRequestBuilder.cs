using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MyFramework.datastructures;
using MyFramework.localfile;

namespace MyFramework.api {
    public class ApiRequestBuilder{
        private ApiRequestBundle apiRequestBundle;
        public ApiRequestBuilder(){
        }

        public ApiRequestBundle getApiRequestBundle(){
            return apiRequestBundle;
        }

        public ApiRequestBuilder buildHttpRequest() {
            apiRequestBundle = new ApiRequestBundle();
            apiRequestBundle.setIsMultipart(false);
            return this;
        }

        public ApiRequestBuilder buildMultipartRequest(MultiPartContent _multiPartContent){
            apiRequestBundle = new ApiRequestBundle();
            apiRequestBundle.setIsMultipart(true);
            apiRequestBundle.setMultiPartContent(_multiPartContent);
            return this;
        }
        
        public ApiRequestBuilder addParameters(string _name, string _value) {
            apiRequestBundle.addParameters(_name,_value);
            return this;
        }

        public ApiRequestBuilder addHeaders(string _name, string _value) {
            apiRequestBundle.addParameters(_name,_value);
            return this;
        }

        public ApiRequestBuilder setEndpoint(string _endpoint) {
            apiRequestBundle.setEndpoint(_endpoint);
            return this;
        }

        public ApiRequestBuilder setRequestMethod(HttpMethod _httpMethod) {
            apiRequestBundle.setRequestMethod(_httpMethod);
            return this;
        }
    }
}
