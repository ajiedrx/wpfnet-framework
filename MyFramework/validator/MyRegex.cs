using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Velacro.Validator {
    public class MyRegex : Regex
    {
        public MyRegex(string pattern) : base(pattern) { }
        public MyRegex(string pattern, RegexOptions options) : base(pattern, options) { }
        public MyRegex(string pattern, RegexOptions options, TimeSpan matchTimeout) : base(pattern, options, matchTimeout) { }
        protected MyRegex() { }
        protected MyRegex(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
