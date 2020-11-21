using System;
using System.IO;
using System.Net.Http;
using Velacro.Basic;

namespace Velacro.Api {
    /// <summary>
    /// MultiPartContent main class.
    /// This class used for creating MultiPartContent object for MultiPart request type.
    /// </summary>
    /// <example>
    /// <code>
    /// MyList<string> fileKey = new MyList<string>(){ "photo" }; 
    /// var files = new OpenFile().openFile(false);
    /// var multiPartContent = new MultiPartContent(files, fileKey);
    /// var multiPartRequest = request
    /// .buildMultipartRequest(multiPartContent)
    /// .setRequestMethod(HttpMethod.Post)
    /// .setEndpoint("api/upload");
    /// </code>
    /// </example>
    public class MultiPartContent {
        private MyList<MyFile> files;
        private MyList<string> filesKey;
        private MultipartFormDataContent multiPartForm;
        /// <summary>
        /// MultiPartContent constructor.
        /// </summary>
        /// <param name="_files">A MyList<MyFile> param</param>
        /// <param name="_filesKey">A MyList<string> param</param>
        public MultiPartContent(MyList<MyFile> _files, MyList<string> _filesKey) {
            multiPartForm = new MultipartFormDataContent();
            files = _files;
            filesKey = _filesKey;
            parseFiles();
        }

        private void parseFiles(){ 
            for (int i = 0; i < files.Count; i++) {
                multiPartForm.Add(new StreamContent(new MemoryStream(files[i].byteArray)), filesKey[i], files[i].fullFileName);
            }
        }
        /// <summary>
        /// MultiPartContent constructor.
        /// </summary>
        /// <param name="_content">A MultipartFormDataContent param. (Instantiate)</param>
        public MultiPartContent(MultipartFormDataContent _content){
            multiPartForm = _content;
        }
        /// <summary>
        /// Get the assigned files.
        /// </summary>
        /// <returns>MyList<MyFile></returns>
        public MyList<MyFile> getFiles() {
            if (files != null) {
                return files;
            }
            throw new Exception("Files is null");
        }

        internal MultipartFormDataContent getMultiPartFormDataContent() {
            return multiPartForm;
        }
    }
}
