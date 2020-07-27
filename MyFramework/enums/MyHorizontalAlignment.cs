using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyFramework.enums {
    public class MyHorizontalAlignment
    {
        private HorizontalAlignment horizontalAlignment;
        public static MyHorizontalAlignment LEFT = new MyHorizontalAlignment(HorizontalAlignment.Left);
        public static MyHorizontalAlignment RIGHT = new MyHorizontalAlignment(HorizontalAlignment.Right);
        public static MyHorizontalAlignment CENTER = new MyHorizontalAlignment(HorizontalAlignment.Center);
        public static MyHorizontalAlignment STRETCH = new MyHorizontalAlignment(HorizontalAlignment.Stretch);

        private MyHorizontalAlignment(HorizontalAlignment _horizontalAlignment) {
            horizontalAlignment = _horizontalAlignment;
        }

        internal HorizontalAlignment getHorizontalAlignment() {
            return horizontalAlignment;
        }
    }
}
