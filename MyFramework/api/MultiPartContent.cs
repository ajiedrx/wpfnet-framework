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

        public MultiPartContent(MultipartFormDataContent _content){
            multiPartForm = _content;
        }
        
        public MyList<MyFile> getFiles() {
            if (files != null) {
                return files;
            }
            throw new Exception("Files is null");
        }

        public MultipartFormDataContent getMultiPartFormDataContent() {
            return multiPartForm;
        }
    }
}
