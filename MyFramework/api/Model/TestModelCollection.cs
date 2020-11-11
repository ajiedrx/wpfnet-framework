using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFramework.datastructures;
using Newtonsoft.Json;

namespace MyFramework.api.Model {
    public class TestModelCollection{
        [JsonProperty]
        public MyList<TestModel> collection{ get; set; }

    }
}
