namespace Velacro.Chart.Basic {
    public class MyCharts {
        private IMyCharts chart;
        public void changeBackgroundColor(string _hexColor) {
            chart.changeBackgroundColor(_hexColor);
        }

        public void changeForegroundColor(string _hexColor) {
            chart.changeForegroundColor(_hexColor);
        }
    }
}
