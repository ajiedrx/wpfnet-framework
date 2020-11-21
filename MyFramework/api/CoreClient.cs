using System.Net.Http;

namespace Velacro.Api {
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
