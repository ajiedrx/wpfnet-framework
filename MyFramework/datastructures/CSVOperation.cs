using System;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace MyFramework.datastructures {
    /// <summary>
    /// CSV File operation class.
    /// </summary>
    /// Below is an example of the model class.
    /// <example>
    /// <code>
    /// public class TestModel {
    ///     public string name { get; set; }
    ///     public string email { get; set; }
    ///     public string address { get; set; }
    /// }
    /// </code>
    /// </example>
    /// If the property name matches the CSV header, it will automatically mapped with the model object.
    /// If not, you can map the CSV header with Name property tag.
    /// Example
    /// <example>
    /// <code>
    /// public class TestModel {
    ///     [Name("name")]
    ///     public string name { get; set; }
    ///     [Name("email")]
    ///     public string email { get; set; }
    ///     [Name("address")]
    ///     public string address { get; set; }
    /// }
    /// </code>
    /// </example>
    /// If the CSV file doesn't have headers, map the property with index tag.
    /// Example
    /// <example>
    /// <code>
    /// public class TestModel {
    ///     [Index(0)]
    ///     public string name { get; set; }
    ///     [Index(1)]
    ///     public string email { get; set; }
    ///     [Index(2)]
    ///     public string address { get; set; }
    /// }
    /// </code>
    /// </example>
    public class CSVOperation{
        private static CsvReader reader;
        private static CsvWriter writer;

        public CSVOperation(){ }
        /// <summary>
        /// Parse the CSV file into the class object.
        /// </summary>
        /// Below is an usage example.
        /// <example>
        /// <code>
        /// Assume that the file is named file.csv
        ///
        /// MyList<TestModel> collection = CSVOperation.parseCSV<TestModel>
        ///     (TextOperation
        ///         .getStreamReaderFile("C:\\Users\\ajied\\source\\repos\\MyFramework\\MyFramework\\file.csv"));
        /// </code>
        /// </example>
        /// <typeparam name="T"></typeparam>
        /// <param name="_reader">A StreamReader param.</param>
        /// <returns>MyList<T></returns>
        public static MyList<T> parseCSV<T>(StreamReader _reader){
            reader = new CsvReader(_reader, CultureInfo.InvariantCulture);
            return new MyList<T>(reader.GetRecords<T>().ToList());
        }
        /// <summary>
        /// Parse the CSV file into the class object with delimiter option.
        /// </summary>
        /// Below is an usage example.
        /// <example>
        /// <code>
        /// Assume that the file is named file.csv
        ///
        /// MyList<TestModel> collection = CSVOperation.parseCSV<TestModel>
        ///     (TextOperation
        ///         .getStreamReaderFile("DRIVELETTER:\\path\\to\\file.csv"), ",");
        /// </code>
        /// </example>
        /// <typeparam name="T"></typeparam>
        /// <param name="_reader">A StreamReader param.</param>
        /// <returns>MyList<T></returns>
        public static MyList<T> parseCSV<T>(StreamReader _reader, string _delimiter) {
            reader = new CsvReader(_reader, CultureInfo.InvariantCulture);
            reader.Configuration.Delimiter = _delimiter;
            return new MyList<T>(reader.GetRecords<T>().ToList());
        }
        /// <summary>
        /// Write one item into CSV file.
        /// If file doesn't exist, it will automatically create new one.
        /// </summary>
        /// Below is an usage example.
        /// <example>
        /// <code>
        /// TestModel anObject = new TestModel(){
        ///     name = someName,
        ///     email = someEmail,
        ///     address= someAddress
        /// };
        /// 
        /// CSVOperation.writeToFile<TestModel>(TextOperation.getStreamWriterFile("DRIVELETTER:\\path\\to\\file.csv"), anObject)
        /// </code>
        /// </example>
        /// <typeparam name="T"></typeparam>
        /// <param name="_streamWriter">A StreamWriter param.</param>
        /// <param name="_item">An model object param.</param>
        public static void writeToFile<T>(StreamWriter _streamWriter, T _item){
            writer = new CsvWriter(_streamWriter, CultureInfo.InvariantCulture);
            writer.WriteRecord(_item);
            writer.Dispose();
        }
        /// <summary>
        /// Write many items into CSV file.
        /// If file doesn't exist, it will automatically create new one.
        /// </summary>
        /// Below is an usage example.
        /// <example>
        /// <code>
        /// MyList<TestModel> collection = new MyList<TestModel>(){
        ///     new TestModel() {
        ///         name = someName1,
        ///         email = someEmail1,
        ///         address = someAddress1
        ///     },
        ///     new TestModel() {
        ///         name = someName2,
        ///         email = someEmail2,
        ///         address = someAddress2
        ///     },
        /// };
        /// 
        /// CSVOperation.writeToFile<TestModel>(TextOperation.getStreamWriterFile("C:\\path\\to\\file.csv"), collection);
        /// </code>
        /// </example>
        /// Output (inside file).
        /// <code>
        /// name,email,address
        /// someName1,someEmail1,someAddress1
        /// someName2,someEmail2,someAddress2
        /// </code>
        /// <typeparam name="T"></typeparam>
        /// <param name="_streamWriter">A StreamWriter param.</param>
        /// <param name="_item">An MyList of model object param.</param>
        public static void writeToFile<T>(StreamWriter _streamWriter, MyList<T> _collection) {
            writer = new CsvWriter(_streamWriter, CultureInfo.InvariantCulture);
            writer.WriteRecords(_collection);
            writer.Dispose();
        }
        /// <summary>
        /// Append collection to available CSV file.
        /// </summary>
        /// Below is an usage example.
        /// <example>
        /// <code>
        /// Inside the file before appended :
        /// name,email,address
        /// someName1,someEmail1,someAddress1
        /// 
        /// MyList<TestModel> collection = new MyList<TestModel>(){
        ///     new TestModel() {
        ///         name = someName2,
        ///         email = someEmail2,
        ///         address = someAddress2
        ///     },
        ///     new TestModel() {
        ///         name = someName3,
        ///         email = someEmail3,
        ///         address = someAddress3
        ///     }
        /// };
        /// 
        /// CSVOperation.appendToFile<TestModel>(TextOperation.getStreamWriterFile("C:\\path\\to\\file.csv"), collection);
        /// </code>
        /// </example>
        /// Output (inside file).
        /// <code>
        /// name,email,address
        /// someName1,someEmail1,someAddress1
        /// someName2,someEmail2,someAddress2
        /// someName3,someEmail3,someAddress3
        /// </code>
        /// <typeparam name="T"></typeparam>
        /// <param name="_appendWriter"></param>
        /// <param name="_collection"></param>
        public static void appendToFile<T>(StreamWriter _appendWriter, MyList<T> _collection){
            writer = new CsvWriter(_appendWriter, CultureInfo.InvariantCulture);
            writer.Configuration.HasHeaderRecord = false;
            writer.WriteRecords(_collection);
            writer.Dispose();
        }
        /// <summary>
        /// Append collection to available CSV file.
        /// </summary>
        /// Below is an usage example.
        /// <example>
        /// <code>
        /// Inside the file before appended :
        /// name,email,address
        /// someName1,someEmail1,someAddress1
        /// 
        /// 
        /// TestModel anObject = new TestModel() {
        ///     name = someName3,
        ///     email = someEmail3,
        ///     address = someAddress3
        /// };
        /// 
        /// CSVOperation.appendToFile<TestModel>(TextOperation.getStreamWriterFile("C:\\path\\to\\file.csv"), collection);
        /// </code>
        /// </example>
        /// Output (inside file).
        /// <code>
        /// name,email,address
        /// someName1,someEmail1,someAddress1
        /// someName3,someEmail3,someAddress3
        /// </code>
        /// <typeparam name="T"></typeparam>
        /// <param name="_appendWriter"></param>
        /// <param name="_collection"></param>
        public static void appendToFile<T>(StreamWriter _appendWriter, T _item) {
            writer = new CsvWriter(_appendWriter, CultureInfo.InvariantCulture);
            writer.Configuration.HasHeaderRecord = false;
            writer.WriteRecord(_item);
            writer.Dispose();
        }
        /// <summary>
        /// Write headers to CSV file that doesn't have headers.
        /// </summary>
        /// <typeparam name="T">Model class param.</typeparam>
        /// <param name="_streamWriter">A StreamWriter param.</param>
        public static void addHeaderToCSVFile<T>(StreamWriter _streamWriter){
            writer = new CsvWriter(_streamWriter, CultureInfo.InvariantCulture);
            writer.WriteHeader<T>();
            writer.NextRecord();
            writer.Dispose();
        }
    }
}
