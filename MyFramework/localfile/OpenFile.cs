using System;
using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using Velacro.Basic;

namespace Velacro.LocalFile {
    public class OpenFile {
        private OpenFileDialog fileDialog;
        private SaveFile saveFile;
        
        public OpenFile() {
            fileDialog = new OpenFileDialog();
            fileDialog.RestoreDirectory = true;
            fileDialog.CheckFileExists = true;
        }

        private MyFile openSingleFileDialog(){
            if (fileDialog.ShowDialog() == true){
                string file = fileDialog.FileName;
                MyFile fileObject = new MyFile() {
                    fullPath = file,
                    fullFileName = Path.GetFileName(file),
                    fileSize = formatFileSize(new FileInfo(file).Length),
                    extension = Path.GetExtension(file),
                    byteArray = File.ReadAllBytes(file)
                };
                saveFile = new SaveFile(fileObject);
                return fileObject;
            }
            else{
                return null;
            }
        }

        private MyList<MyFile> openMultiFileDialog(){
            MyList<MyFile> multiFiles = new MyList<MyFile>();
            if (fileDialog.ShowDialog() == true){
                foreach (var file in fileDialog.FileNames){
                    multiFiles.Add(new MyFile(){
                            fullPath = file,
                            fullFileName = Path.GetFileName(file),
                            fileSize = formatFileSize(new FileInfo(file).Length),
                            extension = Path.GetExtension(file),
                            byteArray = File.ReadAllBytes(file)
                        });
                }
            }
            return multiFiles;
        }

        private MyList<MyFile> getFiles(bool _multifile) {
            MyList<MyFile> files = new MyList<MyFile>();
            fileDialog.Multiselect = _multifile;
            if (_multifile) {
                files = openMultiFileDialog();
            } else {
                files.Add(openSingleFileDialog());
            }

            return files;
        }
        /// <summary>
        /// Open the Open File Dialog.
        /// If the file is platform dependent (eg. .docx .pdf .xls .etc) or other than text-based files, user can only get the file as byte array (property available in MyFile class).
        /// </summary>
        /// Below is an example usage.
        /// <example>
        /// <code>
        /// OpenFile openFile = new OpenFile();
        /// MyFile files = openFile.openFile(false)[0];
        /// Console.WriteLine(file.fullPath);
        /// </code>
        /// </example>
        /// Output
        /// @image html OpenFileExample.png
        ///
        /// 
        /// <code>
        /// "D:\package.json"
        /// </code>
        /// This also can be used for classes that needs file's path instead of defining file's path manually.
        /// <param name="_multifile">
        /// A boolean param
        /// Set true for enabling multi selection for the file.
        /// Set false for single selection of the file.
        /// </param>
        /// <returns>
        /// MyList of MyFile,
        /// Access the first index ([0]) of the collection for getting the single-file.
        /// </returns>
        public MyList<MyFile> openFile(bool _multifile){
            fileDialog.Filter = "All files (*.*)|*.*";
            fileDialog.Title = "Select File";
            MyList<MyFile> files;
            files = getFiles(_multifile);
            return files;
        }
        /// <summary>
        /// Method for Opening OpenFileDialog. Then user can select an image then return as collection of BitmapImage format.
        /// It could be used as Source of UI controls.
        /// </summary>
        /// Below is an usage example.
        /// <example>
        /// <code>
        /// OpenFile openFile = new OpenFile();
        /// imageBox_img.Source = openFile.openImageFile()[0]; //imageBox_img is a Image WPF UI Control
        /// </code>
        /// </example>
        /// Output
        /// @image html OpenImageExample.png
        /// @image html ImageControlExample.png
        /// <param name="_multifile">
        /// A boolean param
        /// Set true for enabling multi selection for the file.
        /// Set false for single selection of the file.
        /// </param>
        /// <returns>
        /// MyList of BitmapImage,
        /// Access the first index ([0]) of the collection for getting the single-file.
        /// </returns>
        public MyList<BitmapImage> openImageFile(bool _multifile){
            fileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                                "All files (*.*)|*.*";
            fileDialog.Title = "Select Images";
            MyList<BitmapImage> imageFiles = new MyList<BitmapImage>();
            foreach (MyFile imageFile in getFiles(_multifile)){
                imageFiles.Add(convertBitmapImage(new Bitmap(imageFile.fullPath)));
            }
            return imageFiles;
        }

        private string formatFileSize(long _size){
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = _size;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1){
                order++;
                len = len / 1024;
            }
            string result = String.Format("{0:0.##} {1}", len, sizes[order]);
            return result;
        }

        private BitmapImage convertBitmapImage(Image src) {
            MemoryStream ms = new MemoryStream();
            ((System.Drawing.Bitmap)src).Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }

    }
}
