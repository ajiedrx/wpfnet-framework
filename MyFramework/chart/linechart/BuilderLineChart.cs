using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.chart.linechart
{
    /// <summary>
    /// LineChart builder class.
    /// </summary>
    /// <remarks>
    /// Below is an usage example.
    /// </remarks>
    /// <example>
    /// <code>
    /// BuilderBarChart builderLineChart;
    /// IMyBarChart lineChart;
    /// 
    /// MyList<double> chartDataExample = new MyList<double>() { 10, 20, 30, 40 };
    /// MyList<double> chartDataExample2 = new MyList<double>() { 40, 30, 20, 10 };
    /// builderLineChart = new BuilderLineChart();
    /// lineChart = builderLineChart
    ///     .activate(this, "lineChart_lc")
    ///     .addSeries("Series1", chartDataExample)
    ///     .addSeries("Series2", chartDataExample2)
    ///     .changeSeriesFillColor("Series1", "#FFFF00");
    /// </code>
    /// </example>
    /// <remarks>Output :</remarks>
    /// @ image html 
    public class BuilderLineChart
    {
        /// <summary>
        /// Getting the LineChart UI Element instance.
        /// </summary>
        /// <param name="_parent"></param>
        /// <param name="_componentName"></param>
        /// <returns>IMyLineChart</returns>
        public IMyLineChart activate(IMyContainer _parent, string _componentName)
        {
            Object obj = _parent.getComponentByName(_componentName);
            IMyLineChart lineChart = new MyLineChart(((IMyContainer)obj).getComponentByName("lineChart_chr"));
            return lineChart;
        }
    }
}
