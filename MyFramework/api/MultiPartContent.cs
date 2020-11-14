using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MyFramework.datastructures;
using MyFramework.localfile;

namespace MyFramework.api {
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
