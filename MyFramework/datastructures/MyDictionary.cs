using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace MyFramework.datastructures {
    /// <summary>
    /// Main class of MyDictionary.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class MyDictionary<TKey,TValue> : Dictionary<TKey, TValue> {
        public MyDictionary(){ }
        /// <summary>
        /// Convert dictionary to JSON string.
        /// </summary>
        /// <returns>string</returns>
        public string convertToJSON(){
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
