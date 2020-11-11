using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using MyFramework.api;
using MyFramework.datastructures;
using MyFramework.localfile;

namespace MyFramework {
    public class DeleteSoon {
        public DeleteSoon(){ }

        public async Task execute() {
            var client = new api.ApiClient("http://127.0.0.1:8000/");
            var request = new ApiRequestBuilder();
            MyList<string> fileKey = new MyList<string>() { "photo" };
            var files = new OpenFile().openFile(false);
            if (files.Count != 0 && files[0] != null){
                var multiPartContent = new MultiPartContent(files, fileKey);
                request.buildMultipartRequest(multiPartContent).setRequestMethod(HttpMethod.Post).setEndpoint("api/file/country_list");
                var response = await client.sendRequest(request.getApiRequestBundle());
                Console.WriteLine(response.getHttpResponseMessage().ToString());
            }
            else{
                Console.WriteLine("FILE KSOONGG");
            }
        }
    }
}
