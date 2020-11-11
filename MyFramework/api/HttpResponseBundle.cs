using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MyFramework.datastructures;
using Newtonsoft.Json.Linq;

namespace MyFramework.api {
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

        public T getParsedObject<T>(){
            return JSONOperation.parseJSON<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }

        public JObject getJObject(){
            return JObject.Parse(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }
    }
}
