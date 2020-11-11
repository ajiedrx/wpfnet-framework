using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.localfile {
    public class MyFile{
        /// <summary>
        /// Gets or sets the full path of the file.
        /// </summary>
        public string fullPath{ get; set; }
        /// <summary>
        /// Gets or sets file name only with extension.
        /// </summary>
        public string fullFileName{ get; set; }
        /// <summary>
        /// Gets or sets file size.
        /// </summary>
        public string fileSize{ get; set; }
        /// <summary>
        /// Gets or sets the file extensions.
        /// </summary>
        public string extension{ get; set; }
        /// <summary>
        /// Gets or sets the file byte array.
        /// </summary>
        public byte[] byteArray{ get; set; }

        public string getFileName(){
            return fullFileName.Remove(fullFileName.Length - 3);
        }
    }
}
