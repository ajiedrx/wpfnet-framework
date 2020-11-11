//
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Net.Http;
// using System.Text;
// using System.Threading.Tasks;
// using MyFramework.api;
//
// namespace MyFramework {
//     public class AnotherRequest {
//         public AnotherRequest(){
//
//         }
//
//         public void execute(){
//             api.ApiClient client = MainWindow.getApiClient();
//             client.setOnSuccessRequest(anotherMethod);
//             ApiRequestBuilder requestBuilder = new ApiRequestBuilder();
//             requestBuilder.build()
//                 .setEndpoint("/contacts")
//                 .setRequestMethod(HttpMethod.Get);
//             client.setOnSuccessRequest(anotherMethod);
//             client.sendRequest(requestBuilder);
//         }
//
//         public void anotherMethod(HttpResponseMessage _msg){
//             Console.WriteLine(_msg.Content.ReadAsStringAsync().Result);
//         }
//     }
// }
