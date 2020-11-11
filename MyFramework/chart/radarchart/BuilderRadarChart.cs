using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.chart.radarchart
{
    /// <summary>
    /// RadarChart builder class.
    /// </summary>
    /// <remarks>
    /// Below is an usage example.
    /// </remarks>
    /// <example>
    /// <code>
    /// BuilderRadarChart builderRadarChart;
    /// IMyRadarChart radarChart;
    /// 
    /// MyList<double> chartDataExample = new MyList<double>() { 10, 20, 30, 40 };
    /// MyList<double> chartDataExample2 = new MyList<double>() { 40, 30, 20, 10 };
    /// builderRadarChart = new BuilderRadarChart();
    /// radarChart = builderRadarChart
    ///     .activate(this, "radarChart_rc")
    ///     .addSeries("Series1", chartDataExample)
    ///     .addSeries("Series2", chartDataExample2)
    ///     .changeSeriesFillColor("Series1", "#FFFF00");
    /// </code>
    /// </example>
    /// <remarks>Output :</remarks>
    /// @image html RadarChartExample.png
    /// <remarks>For more detailed documentations please refer to MyRadarChart</remarks>
    public class BuilderRadarChart
    {
        /// <summary>
        /// Get the instance of the RadarChart from XAML.
        /// </summary>
        /// <param name="_parent">An IMyContainer param.</param>
        /// <param name="_componentName">A string param.</param>
        /// <returns>IMyRadarChart</returns>
        public IMyRadarChart activate(IMyContainer _parent, string _componentName) {
            Object obj = _parent.getComponentByName(_componentName);
            IMyRadarChart radarChart = new MyRadarChart(((IMyContainer)obj).getComponentByName("radarChart_chr"));
            return radarChart;
        }
    }
}
