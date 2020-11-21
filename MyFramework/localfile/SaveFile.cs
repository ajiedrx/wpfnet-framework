using System;
using System.IO;
using Microsoft.Win32;
using Velacro.Basic;

namespace Velacro.LocalFile {
    public class SaveFile{
        private MyFile fileToSave;
        private SaveFileDialog saveFileDialog;
        public SaveFile(){ }

        public SaveFile(MyFile _fileToSave) {
            saveFileDialog = new SaveFileDialog();
            fileToSave = _fileToSave;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.AddExtension = true;
        }
        /// <summary>
        /// Save the file through the SaveFileDialog, invoking this will open the SaveFileDialog.
        /// Use this method after invoking OpenFile then opening a single file.
        /// </summary>
        /// Below is an usage example.
        /// <example>
        /// Assume that single file has been opened through OpenFile, the single file instance is passed through here.
        /// Call this method to open the SaveFileDialog and save the previously opened file.
        /// <code>
        /// SaveFile saveFile = new SaveFile();
        /// saveFile.saveFile(); //this will opens the SaveFileDialog and redirect to previous opened file.
        /// </code>
        /// </example>
        /// <param name="_content">A string param.</param>
        public void saveFile(string _content) {
            saveFileDialog.InitialDirectory = Path.GetDirectoryName(fileToSave.fullPath);
            if (saveFileDialog.ShowDialog() == true) {
                saveFileDialog.FileName = fileToSave.fullPath;
                File.WriteAllText(saveFileDialog.FileName, _content);
            } else {
                Console.WriteLine("No files saved!");
            }
        }
        /// <summary>
        /// NOT TESTED YET Save the file through the SaveFileDialog, invoking this will open the SaveFileDialog.
        /// </summary>
        /// Below is an usage example.
        /// <example>
        /// Call this method to open the SaveFileDialog and save the MyFile.
        /// <code>
        /// SaveFile saveFile = new SaveFile();
        /// MyFile file = new MyFile() {
        ///     fullPath = "path/to/file",
        ///     fileName = "file1.txt",
        ///     extension ".txt"
        /// };
        /// string someString = "this is a string.";
        /// saveFile.saveFile(someString, file);
        /// </code>
        /// </example>
        /// <param name="_content">A string param.</param>
        /// <param name="_file">A MyFile param.</param>
        public void saveFile(string _content, MyFile _file){
            saveFileDialog.InitialDirectory = Path.GetDirectoryName(_file.fullPath);
            if (saveFileDialog.ShowDialog() == true) {
                saveFileDialog.FileName = fileToSave.fullPath;
                File.WriteAllText(saveFileDialog.FileName, _content);
            } else {
                Console.WriteLine("No files saved!");
            }
        }
    }
}
