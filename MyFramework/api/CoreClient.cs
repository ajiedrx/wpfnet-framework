using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.api {
    public class CoreClient{
        private static HttpClient client;
        private static CoreClient instance;
        private CoreClient(){ }

        internal static CoreClient getInstance(){
            if (instance == null && client == null){
                client = new HttpClient();
                instance = new CoreClient();
            }

            return instance;
        }
        internal HttpClient getClient(){
            return client;
        }
    }
}
