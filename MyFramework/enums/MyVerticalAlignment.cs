using System.Windows;

namespace Velacro.Enums {
    public class MyVerticalAlignment 
    {
        VerticalAlignment verticalAlignment;

        public static MyVerticalAlignment TOP = new MyVerticalAlignment(VerticalAlignment.Top);
        public static MyVerticalAlignment CENTER = new MyVerticalAlignment(VerticalAlignment.Center);
        public static MyVerticalAlignment BOTTOM = new MyVerticalAlignment(VerticalAlignment.Bottom);
        public static MyVerticalAlignment STRETCH = new MyVerticalAlignment(VerticalAlignment.Stretch);

        private MyVerticalAlignment(VerticalAlignment _verticalAlignment) {
            verticalAlignment = _verticalAlignment;
        }

        internal VerticalAlignment getVerticalAlignment() {
            return verticalAlignment;
        }
    }
}
