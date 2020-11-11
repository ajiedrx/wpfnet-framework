using MyFramework.basic;
using System;

namespace MyFramework.chart.barchart
{
    /// <summary>
    /// BarChart builder class.
    /// </summary>
    /// <remarks>
    /// Below is an usage example.
    /// </remarks>
    /// <example>
    /// <code>
    /// BuilderBarChart builderBarChart;
    /// IMyBarChart barChart;
    /// 
    /// MyList<double> chartDataExample = new MyList<double>() { 10, 20, 30, 40 };
    /// MyList<double> chartDataExample2 = new MyList<double>() { 40, 30, 20, 10 };
    /// builderBarChart = new BuilderBarChart();
    /// barChart = builderBarChart
    ///     .activate(this, "barChart_bc")
    ///     .addSeries("Series1", chartDataExample)
    ///     .addSeries("Series2", chartDataExample2)
    ///     .changeSeriesFillColor("Series1", "#FFFF00");
    /// </code>
    /// </example>
    /// <remarks>Output :</remarks>
    /// @image html BarChartExample.png
    /// <remarks>For more detailed documentations please refer to MyBarChart</remarks>
    public class BuilderBarChart
    {
        public BuilderBarChart() { }
        /// <summary>
        /// Get the instance of the BarChart from XAML.
        /// </summary>
        /// <param name="_parent">An IMyContainer param.</param>
        /// <param name="_componentName">A string param.</param>
        /// <returns>IMyBarChart</returns>
        public IMyBarChart activate(IMyContainer _parent, string _componentName) {
            Object obj = _parent.getComponentByName(_componentName);
            IMyBarChart barChart = new MyBarChart(((IMyContainer)obj).getComponentByName("barChart_chr"));
            return barChart;
        }
    }
}
