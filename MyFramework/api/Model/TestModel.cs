using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyFramework.api.Model {
    // [XmlRoot(ElementName = "TestModel")]
    public class TestModel {
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string email { get; set; }
        [JsonProperty(PropertyName = "address")]
        public string address { get; set; }
    }
}
