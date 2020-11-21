using System;
using Velacro.UIElements.Basic;

namespace Velacro.Chart.LineChart
{
    /// <summary>
    /// LineChart builder class.
    /// </summary>
    /// <remarks>
    /// Below is an usage example.
    /// </remarks>
    /// <example>
    /// <code>
    /// BuilderLineChart builderLineChart;
    /// IMyLineChart lineChart;
    /// 
    /// MyList<double> chartDataExample = new MyList<double>() { 10, 20, 30, 40 };
    /// MyList<double> chartDataExample2 = new MyList<double>() { 40, 30, 20, 10 };
    /// builderLineChart = new BuilderLineChart();
    /// lineChart = builderLineChart
    ///     .activate(this, "lineChart_lc")
    ///     .addSeries("Series1", chartDataExample)
    ///     .addSeries("Series2", chartDataExample2)
    ///     .changeSeriesFillColor("Series1", "#FFFF00");
    ///     .changeSeriesLineColor("Series1", "#FFFF00");
    /// </code>
    /// </example>
    /// <remarks>Output :</remarks>
    /// @image html BarChartExample.png
    /// <remarks>For more detailed documentations please refer to MyLineChart</remarks>
    public class BuilderLineChart
    {
        /// <summary>
        /// Get the instance of the LineChart from XAML.
        /// </summary>
        /// <param name="_parent">An IMyContainer param.</param>
        /// <param name="_componentName">A string param.</param>
        /// <returns>IMyLineChart</returns>
        public IMyLineChart activate(IMyContainer _parent, string _componentName)
        {
            Object obj = _parent.getComponentByName(_componentName);
            IMyLineChart lineChart = new MyLineChart(((IMyContainer)obj).getComponentByName("lineChart_chr"));
            return lineChart;
        }
    }
}
