using System;
using System.Net.Http;
using Velacro.Api;
using Velacro.Basic;
using Velacro.UIElements.Basic;
using ApiClient = Velacro.Api;

namespace Velacro {
    public partial class MainWindow : MyWindow{
        public MainWindow() {
            InitializeComponent();
            string token = "";
            
        }

        public async void execute(){
            var client = new ApiClient.ApiClient("http://127.0.0.1:8000/");
            var request = new ApiRequestBuilder();
            MyList<string> fileKey = new MyList<string>() { "photo" };
            

            string token = "";
            var req = request
                .buildHttpRequest()
                .addParameters("email", "john@me.com")
                .addParameters("password", "password")
                .setEndpoint("api/login/")
                .setRequestMethod(HttpMethod.Post);
            var response = await client.sendRequest(request.getApiRequestBundle());
            token = response.getJObject()["access_token"].ToString();
            client.setAuthorizationToken(token);
            req = request
                .buildHttpRequest()
                .setEndpoint("api/ceo")
                .setRequestMethod(HttpMethod.Get);
            response = await client.sendRequest(req.getApiRequestBundle());
            Console.WriteLine(response.getHttpResponseMessage().Content.ReadAsStringAsync().Result);
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e){
            execute();
        }
    }
}
