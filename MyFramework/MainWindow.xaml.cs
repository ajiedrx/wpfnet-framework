using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Velacro.Api;
using Velacro.Basic;
using Velacro.LocalFile;
using Velacro.UIElements.Basic;
using Velacro.UIElements.TextBlock;
using Velacro.UIElements.TextBox;
using ApiClient = Velacro.Api;

namespace Velacro {
    public partial class MainWindow : MyWindow{
        private BuilderTextBlock builderTextBlock;
        private IMyTextBlock textBlock;

        private BuilderTextBox builderTextBox;
        private IMyTextBox emailTextBox;
        public MainWindow() {
            InitializeComponent();
            builderTextBlock = new BuilderTextBlock();
            textBlock = builderTextBlock.activate(this, "txt_txt");
            string token = "";
            builderTextBox = new BuilderTextBox();
            emailTextBox = builderTextBox.activate(this, "email_txt");
            emailTextBox.addPlaceholderText("insertemailhere");
        }

        public async void execute(){
            var client = new ApiClient.ApiClient("http://127.0.0.1:8000/");
            var request = new ApiRequestBuilder();
            string token;

            var req = request
                .buildHttpRequest()
                .addParameters("email", "john@me.com")
                .addParameters("password", "password")
                .setEndpoint("api/login/")
                .setRequestMethod(HttpMethod.Post);
            var response = await client.sendRequest(request.getApiRequestBundle());
            token = response.getJObject()["access_token"].ToString();

            client.setAuthorizationToken(token);
            MyList<MyFile> files = new OpenFile().openFile(false);
            MyList<string> fileKey = new MyList<string>() { "file" };

            var formContent = new MultipartFormDataContent();
            formContent.Add(new StringContent("restapis.png"), "title"); //parameters request, "value","key"
            formContent.Add(new StreamContent(new MemoryStream(files[0].byteArray)), fileKey[0], files[0].fullFileName); //file yang diupload

             req = new ApiRequestBuilder().buildMultipartRequest(new MultiPartContent(formContent))
                .setRequestMethod(HttpMethod.Post)
                .setEndpoint("api/store-file");
            response = await client.sendRequest(req.getApiRequestBundle());

            Console.WriteLine(response.getHttpResponseMessage().ToString());
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e){
            execute();
        }
    }
}
