using System.IO;
using System.Xml.Serialization;

namespace Velacro.DataStructures {
    /// <summary>
    /// Main class for XML operation.
    /// </summary>
    public class XMLOperation{
        private static XmlSerializer serializer;
        /// <summary>
        /// Parse the XML string into class object.
        /// </summary>
        /// Below is an usage example
        /// <example>
        /// <code>
        /// [XmlRoot(ElementName = "TestModel")]
        /// public class TestModel {
        ///    [XmlElement(ElementName = "name")]
        ///    public string name { get; set; }
        ///    [XmlElement(ElementName = "email")]
        ///    public string email { get; set; }
        ///    [XmlElement(ElementName = "address")]
        ///    public string address { get; set; }
        /// }
        /// string xmlfile =
        ///     TextOperation.openFile("C:\\Users\\users\\source\\repos\\MyFramework\\MyFramework\\XMLParseTest.xml");
        /// TestModel XMLModel = XMLOperation.parseXML<TestModel>(xmlfile);
        /// Console.WriteLine(XMLModel.name);
        /// Console.WriteLine(XMLModel.email);
        /// Console.WriteLine(XMLModel.name);
        /// </code>
        /// </example>
        /// Output
        /// <code>
        /// someName
        /// someName@email.com
        /// someAddress
        /// </code>
        /// <typeparam name="T"></typeparam>
        /// <param name="_xml"></param>
        /// <returns>T</returns>
        public static T parseXML<T>(string _xml){
            serializer = new XmlSerializer(typeof(T));
            StringReader reader = new StringReader(_xml);
            T obj = (T)serializer.Deserialize(reader);
            return obj;
        }
        /// <summary>
        /// Convert the model object into XML String
        /// </summary>
        /// Below is an usage example
        /// <example>
        /// <code>
        /// [XmlRoot(ElementName = "TestModel")]
        /// public class TestModel {
        ///    [XmlElement(ElementName = "name")]
        ///    public string name { get; set; }
        ///    [XmlElement(ElementName = "email")]
        ///    public string email { get; set; }
        ///    [XmlElement(ElementName = "address")]
        ///    public string address { get; set; }
        /// }
        /// TestModel testModel = new TestModel(){
        ///     name = someName,
        ///     email = someEmail,
        ///     address = someAddress
        /// };
        /// string xmlString = XMLOperation.convertObjectToXMLString<TestModel>(testModel);
        /// Console.WriteLine(xmlString);
        /// </code>
        /// </example>
        /// Output
        /// <code>
        /// <TestModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
        ///     <name>
        ///         someName
        ///     </name>
        ///     <email>
        ///         someEmail@email.com
        ///     </email>
        ///     <address>
        ///         someadress
        ///     </address>
        /// </TestModel>
        /// </code>
        /// <typeparam name="T"></typeparam>
        /// <param name="_object"></param>
        /// <returns>string</returns>
        public static string convertObjectToXMLString<T>(T _object){
            StringWriter stringWriter = new StringWriter();
            serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(stringWriter, _object);
            return stringWriter.ToString();
        }
    }
}
