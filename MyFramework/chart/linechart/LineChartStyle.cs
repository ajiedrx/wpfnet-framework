

namespace Velacro.Chart.LineChart
{
    public class LineChartStyle
    {
        public static LineChartStyle SMOOTH = new LineChartStyle(1);
        public static LineChartStyle SHARP = new LineChartStyle(0);

        private int lineChartStyle;
        private LineChartStyle(int _lineChartStyle) {
            lineChartStyle = _lineChartStyle;
        }

        internal int getLineChartStyle() {
            return lineChartStyle;
        }
    }
}
