using Velacro.UIElements.Basic;

namespace Velacro.Chart.PieChart
{
    /// <summary>
    /// PieChart builder class.
    /// </summary>
    /// <remarks>
    /// Below is an usage example.
    /// </remarks>
    /// <example>
    /// <code>
    /// BuilderPieChart builderPieChart;
    /// IMyPieChart pieChart;
    /// 
    /// MyList<double> seriesTitles = new MyList<double>() { "Series1", "Series2", "Series3", "Series4" };
    /// MyList<double> chartDataExample= new MyList<double>() { 40, 30, 20, 10 };
    /// builderPieChart = new BuilderPieChart();
    /// pieChart = builderPieChart
    ///     .activate(this, "pieChart_pc")
    ///     .addSeries(seriesTitles, chartDataExample)
    ///     .changeSeriesFillColor("Series1", "#FFFF00");
    /// </code>
    /// </example>
    /// <remarks>Output :</remarks>
    /// @image html PieChartExample.png
    /// <remarks>For more detailed documentations please refer to MyPieChart</remarks>
    public class BuilderPieChart
    {
        /// <summary>
        /// Get the instance of the PieChart from XAML.
        /// </summary>
        /// <param name="_parent"></param>
        /// <param name="_componentName"></param>
        /// <returns>IMyPieChart</returns>
        public IMyPieChart activate(IMyContainer _parent, string _componentName)
        {
            object obj = _parent.getComponentByName(_componentName);
            IMyPieChart pieChart = new MyPieChart(((IMyContainer)obj).getComponentByName("pieChart_chr"));
            return pieChart;
        }
    }
}
