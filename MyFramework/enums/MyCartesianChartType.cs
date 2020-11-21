namespace Velacro.Enums {
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
