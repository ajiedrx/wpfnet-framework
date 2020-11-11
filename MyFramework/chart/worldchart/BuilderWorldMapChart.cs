using MyFramework.basic;
using System;

namespace MyFramework.chart.worldchart
{
    /// <summary>
    /// WorldMapChart builder class.
    /// </summary>
    /// <remarks>
    /// Below is an usage example.
    /// </remarks>
    /// <example>
    /// <code>
    /// BuilderWorldMapChart builderWorldMapChart;
    /// IMyWorldMapChart worldMapChart;
    /// 
    /// MyList<string> countryCode = new MyList<string>() { "ID", "IR", "IN", "IT" };
    /// MyList<double> values = new MyList<double>() { 40, 30, 20, 10 };
    /// builderWorldMapChart = new BuilderWorldMapChart();
    /// worldMapChart = builderWorldMapChart
    ///     .activate(this, "worldMapChart_wmc")
    ///     .setXMLMapFile("C:\\Users\\users\\source\\repos\\MyFramework\\MyFramework\\chart\\worldchart\\World.xml")
    ///     .setValues(countryCode, values);
    /// </code>
    /// </example>
    /// <remarks>Output :</remarks>
    /// @image html WorldMapChartExample.png
    /// <remarks>For more detailed documentations please refer to MyWorldMapChart</remarks>
    public class BuilderWorldMapChart
    {
        /// <summary>
        /// Get the instance of the WorldMapChart from XAML.
        /// </summary>
        /// <param name="_parent">An IMyContainer param.</param>
        /// <param name="_componentName">A string param.</param>
        /// <returns>IMyWorldMapChart</returns>
        public IMyWorldMapChart activate(IMyContainer _parent, string _componentName) {
            object obj = _parent.getComponentByName(_componentName);
            IMyWorldMapChart radarChart = new MyWorldMapChart(((IMyContainer)obj).getComponentByName("worldMapChart_chr"));
            return radarChart;
        }
    }
}
