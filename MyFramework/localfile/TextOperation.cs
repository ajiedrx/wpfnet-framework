using System.IO;
using MyFramework.datastructures;

namespace MyFramework.localfile {
    public class TextOperation{

        private static string FILE_PATH;
        private static StreamReader reader;
        private static StreamWriter writer;
        /// <summary>
        /// Fully read text-based file and return as string.
        /// Doesn't support reading platform dependent text file such as .docx, .pptx, .xls and .etc 
        /// </summary>
        /// <param name="_path">
        /// A string of file path param.
        /// </param>
        /// <returns>string</returns>
        public static string readFileAsString(string _path){
            reader = new StreamReader(_path);
            return reader.ReadToEnd();
        }
        /// <summary>
        /// Read text-based file line by line and return as collection of line strings.
        /// </summary>
        /// <param name="_path">
        /// A string of file path param.
        /// </param>
        /// <returns>MyList<string></returns>
        public static MyList<string> readFileByLines(string _path){
            MyList<string> lines = new MyList<string>();
            string line;
            reader = new StreamReader(_path);
            while ((line = reader.ReadLine()) != null){
                lines.Add(line);
            }
            reader.Dispose();
            return lines;
        }
        /// <summary>
        /// Write string to file.
        /// It will <b>overwrite</b> the existing content on the file.
        /// </summary>
        /// <param name="_path">A string of file path param. </param>
        /// <param name="_text">A string of content param.</param>
        public static void writeToFile(string _path, string _text){
            File.WriteAllText(_path, _text);
        }
        /// <summary>
        /// Write string to file.
        /// It will <b>overwrite</b> the existing content on the file.
        /// </summary>
        /// <param name="_path">A string of file path param. </param>
        /// <param name="_text">An array of string of content param.</param>
        public static void writeToFile(string _path, string[] _text) {
            writer = new StreamWriter(_path);
            foreach (string line in _text){
                writer.WriteLine(line);
            }
            writer.Dispose();
        }
        /// <summary>
        /// Write string to file.
        /// It will <b>overwrite</b> the existing content on the file.
        /// </summary>
        /// <param name="_path">A string of file path param.</param>
        /// <param name="_text">A MyList of string of content param.</param>
        public static void writeToFile(string _path, MyList<string> _text) {
            writer = new StreamWriter(_path);
            foreach (string line in _text) {
                writer.WriteLine(line);
            }
            writer.Dispose();
        }
        /// <summary>
        /// Reads the file and return as StreamReader.
        /// This method is needed for CSVOperation class and can be used for other purpose.
        /// </summary>
        /// <param name="_path">A string of file path param. </param>
        /// <returns>StreamReader</returns>
        public static StreamReader getStreamReaderFile(string _path) {
            reader = new StreamReader(_path);
            return reader;
        }
        /// <summary>
        /// Reads the file and return as StreamWriter.
        /// This method is needed for CSVOperation class and can be used for other purpose.
        /// </summary>
        /// <param name="_path">A string of file path param. </param>
        /// <returns>StreamWriter</returns>
        public static StreamWriter getStreamWriterFile(string _path){
            writer = new StreamWriter(_path);
            return writer;
        }
        /// <summary>
        /// Reads the file and return as StreamWriter for appending to file.
        /// This method is needed for CSVOperation class and can be used for other purpose.
        /// </summary>
        /// <param name="_path">A string of file path param. </param>
        /// <returns>StreamWriter</returns>
        public static StreamWriter getStreamAppendFile(string _path){
            FileStream fileStream = File.Open(_path, FileMode.Append);
            writer = new StreamWriter(fileStream);
            return writer;
        }
    }
}
