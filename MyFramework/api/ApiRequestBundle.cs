using System.Net.Http;
using Velacro.DataStructures;

namespace Velacro.Api {
    public class ApiRequestBundle {
        private string endpoint;
        private MyDictionary<string, string> parameters;
        private MyDictionary<string, string> headers;
        private HttpMethod requestMethod;
        private bool multipart;
        private MultiPartContent multiPartContent;
        
        public ApiRequestBundle() {
            parameters = new MyDictionary<string, string>();
            headers = new MyDictionary<string, string>();
        }

        public void addParameters(string _name, string _value) {
            parameters.Add(_name, _value);
        }

        public void addHeaders(string _name, string _value) {
            if (headers.ContainsKey("_name")){
                headers.Remove("_name");
            }
            headers.Add(_name, _value);
        }

        public void setEndpoint(string _endpoint) {
            endpoint = _endpoint;
        }

        public void setRequestMethod(HttpMethod _httpMethod) {
            requestMethod = _httpMethod;
        }

        public HttpMethod getHttpMethod(){
            return requestMethod;
        }

        public string getEndpoint(){
            return endpoint;
        }
        public MyDictionary<string, string> getHeaders(){
            return headers;
        }

        public MyDictionary<string, string> getParameters(){
            return parameters;
        }

        public void setIsMultipart(bool _multipart){
            multipart = _multipart;
        }

        public bool isMultipart(){
            return multipart;
        }

        public void setMultiPartContent(MultiPartContent _content){
            multiPartContent = _content;
        }

        public MultiPartContent getMultiPartContent(){
            return multiPartContent;
        }
    }
}
