using System.Collections.Generic;

namespace MyFramework.basic {
    public class MyList<T> : List<T>
    {
        public MyList() { }

        public MyList(int capacity) : base(capacity) { }

        public MyList(IEnumerable<T> collection) : base(collection) { }
    }
}
