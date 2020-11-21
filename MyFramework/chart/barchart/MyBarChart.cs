using LiveCharts.Wpf;
using Velacro.Basic;
using Velacro.Chart.Basic;
using Velacro.Enums;

namespace Velacro.Chart.BarChart
{
    /// <summary>
    /// The BarChart main class.
    /// </summary>
    internal class MyBarChart : MyCartesianChart, IMyBarChart
    {
        private CartesianChart cartesianChart;

        internal MyBarChart(object _cartesianChart) : base((CartesianChart)_cartesianChart, MyCartesianChartType.BAR) {
            this.cartesianChart = (CartesianChart)_cartesianChart;
        }
        /// <summary>
        /// Set the X axis labels.
        /// </summary>
        /// <param name="_labels">MyList of string param.</param>
        /// <param name="_xLabelTitle">A string param.</param>
        /// <returns>IMyBarChart</returns>
        public IMyBarChart setXLabels(MyList<string> _labels, string _xLabelTitle) {
            base.setXLabels(_labels, _xLabelTitle);
            return this;
        }
        /// <summary>
        /// Set the legend visibility.
        /// </summary>
        /// <param name="_visibility">A boolean param.</param>
        /// <returns>IMyBarChart</returns>
        public IMyBarChart setLegendVisibility(bool _visibility) {
            base.setLegendVisibility(_visibility);
            return this;
        }
        /// <summary>
        /// Add series to the chart.
        /// </summary>
        /// <remarks>
        /// One series contains set of values.
        /// </remarks>
        /// <param name="_seriesTitle">A string param.</param>
        /// <param name="_values">MyList of double param.</param>
        /// <returns>IMyBarChartreturns</returns>
        public IMyBarChart addSeries(string _seriesTitle, MyList<double> _values) {
            base.addSeries(_seriesTitle, _values);
            return this;
        }
        /// <summary>
        /// Update one serie value based on serie title.
        /// </summary>
        /// <param name="_serieTitle">A string param.</param>
        /// <param name="_newValues">MyList of double param.</param>
        /// <returns>IMyBarChart</returns>
        public IMyBarChart updateSerieValue(string _serieTitle, MyList<double> _newValues) {
            base.updateSerieValue(_serieTitle, _newValues);
            return this;
        }
        /// <summary>
        /// Update overall chart values.
        /// </summary>
        /// <remarks>
        /// Values sequences based on series sequence's.
        /// </remarks>
        /// <param name="_newValues">MyList of double param.</param>
        /// <returns>IMyBarChart</returns>
        public IMyBarChart updateChartValue(MyList<double> _newValues) {
            base.updateChartValue(_newValues);
            return this;
        }
        /// <summary>
        /// Change series fill color based on a serie's title.
        /// </summary>
        /// <param name="_seriesTitle"></param>
        /// <param name="_hexColor"></param>
        /// <returns>IMyBarChart</returns>
        public IMyBarChart changeSeriesFillColor(string _seriesTitle, string _hexColor) {
            base.changeSeriesFillColor(_seriesTitle, _hexColor);
            return this;
        }
        /// <summary>
        /// Delete one serie.
        /// </summary>
        /// <param name="_seriesTitle">A string param.</param>
        /// <returns>IMyBarChart</returns>
        public IMyBarChart deleteSeries(string _seriesTitle) {
            base.deleteSeries(_seriesTitle);
            return this;
        }
        /// <summary>
        /// Change the background color.
        /// </summary>
        /// <param name="_hexColor">A string param.</param>
        /// <returns>IMyBarChart</returns>
        public IMyBarChart changeBackgroundColor(string _hexColor)
        {
            base.changeBackgroundColor(_hexColor);
            return this;
        }
        /// <summary>
        /// Change the foreground color.
        /// </summary>
        /// <param name="_hexColor">A string param.</param>
        /// <returns>IMyBarChart</returns>
        public IMyBarChart changeForegroundColor(string _hexColor)
        {
            base.changeForegroundColor(_hexColor);
            return this;
        }

    }
}
