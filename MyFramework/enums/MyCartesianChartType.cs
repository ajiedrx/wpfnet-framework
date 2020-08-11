using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.enums {
    public class MyCartesianChartType {
        private string type;
        public static MyCartesianChartType LINE = new MyCartesianChartType("LINE");
        public static MyCartesianChartType BAR = new MyCartesianChartType("BAR");
        private MyCartesianChartType(string _type) { 
            type = _type;
        }
        public string getCartesianChartType() {
            return this.type;
        }
    }
}
