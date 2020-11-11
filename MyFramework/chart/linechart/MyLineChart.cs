using LiveCharts;
using LiveCharts.Wpf;
using MyFramework.basic;
using MyFramework.enums;
using System.Collections.Generic;
using MyFramework.datastructures;

namespace MyFramework.chart.linechart
{
    /// <summary>
    /// The main LineChart class.
    /// </summary>
    class MyLineChart : MyCartesianChart, IMyLineChart
    {
        private CartesianChart cartesianChart;

        internal MyLineChart(object _cartesianChart) : base((CartesianChart)_cartesianChart, MyCartesianChartType.LINE) {
            this.cartesianChart = (CartesianChart)_cartesianChart;
        }
        /// <summary>
        /// Set the X axis labels.
        /// </summary>
        /// <param name="_labels">MyList of string param.</param>
        /// <param name="_xLabelTitle">A string param.</param>
        /// <returns>IMyLineChart</returns>
        public IMyLineChart setXLabels(MyList<string> _labels, string _xLabelTitle) {
            base.setXLabels(_labels, _xLabelTitle);
            return this;
        }
        /// <summary>
        /// Set the legend visibility.
        /// </summary>
        /// <param name="_visibility">A boolean param.</param>
        /// <returns>IMyLineChart</returns>
        public IMyLineChart setLegendVisibility(bool _visibility) {
            base.setLegendVisibility(_visibility);
            return this;
        }
        /// <summary>
        /// Delete one serie.
        /// </summary>
        /// <param name="_seriesTitle">A string param.</param>
        /// <returns>IMyLineChart</returns>
        public IMyLineChart deleteSeries(string _seriesTitle) {
            base.deleteSeries(_seriesTitle);
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
        /// <returns>IMyLineChart</returns>
        public IMyLineChart addSeries(string _seriesTitle, MyList<double> _values) {
            base.addSeries(_seriesTitle, _values);
            return this;
        }
        /// <summary>
        /// Update one serie value based on serie title.
        /// </summary>
        /// <param name="_seriesTitle">A string param.</param>
        /// <param name="_newValues">MyList of double param.</param>
        /// <returns>IMyLineChart</returns>
        public IMyLineChart updateSerieValue(string _seriesTitle, MyList<double> _newValues) {
            base.updateSerieValue(_seriesTitle, _newValues);
            return this;
        }
        /// <summary>
        /// Update overall chart values.
        /// </summary>
        /// <remarks>
        /// Values sequences based on series sequence's.
        /// </remarks>
        /// <param name="_newValues">MyList of double param.</param>
        /// <returns>IMyLineChart</returns>
        public IMyLineChart updateChartValue(MyList<double> _newValues) {
            base.updateChartValue(_newValues);
            return this;
        }
        /// <summary>
        /// Change series fill color based on a serie's title.
        /// </summary>
        /// <param name="_seriesTitle"></param>
        /// <param name="_hexColor"></param>
        /// <returns>IMyLineChart</returns>
        public IMyLineChart changeSeriesFillColor(string _seriesTitle, string _hexColor) {
            base.changeSeriesFillColor(_seriesTitle, _hexColor);
            return this;
        }
        /// <summary>
        /// Set the line style
        /// </summary>
        /// <param name="_lineChartStyle">
        /// A LineChartStyle param.
        /// You can set line chart style into 2 styles, sharp and smooth.
        /// Check the parameter's property.
        /// </param>
        /// <returns>IMyLineChart</returns>
        public IMyLineChart setLineStyle(LineChartStyle _lineChartStyle) {
            List<LineSeries> seriesTemp = new List<LineSeries>();
            for (int i = 0; i < cartesianChart.Series.Count; i++) {
                seriesTemp.Add((LineSeries)cartesianChart.Series[i]);
            }
            cartesianChart.Series.Clear();
            for (int i = 0; i < seriesTemp.Count; i++) {
                cartesianChart.Series[i] = new LineSeries()
                {
                    Fill = seriesTemp[i].Fill,
                    Title = seriesTemp[i].Title,
                    Values = seriesTemp[i].Values,
                    LineSmoothness = _lineChartStyle.getLineChartStyle()
                };
            }
            return this;
        }

        public IMyLineChart changeSeriesLineColor(string _seriesTitle, string _hexColor) {
            MySolidColorBrush mySolidColorBrush = new MySolidColorBrush();
            foreach (LineSeries aLineSeries in cartesianChart.Series) {
                if (aLineSeries.Title.Equals(_seriesTitle)) {
                    aLineSeries.Stroke = mySolidColorBrush.convertFromHex(_hexColor);
                }
            }
            return this;
        }
        /// <summary>
        /// Change the background color.
        /// </summary>
        /// <param name="_hexColor">A string param.</param>
        /// <returns>IMyLineChart</returns>
        public IMyLineChart changeBackgroundColor(string _hexColor) {
            base.changeBackgroundColor(_hexColor);
            return this;
        }
        /// <summary>
        /// Change the foreground color.
        /// </summary>
        /// <param name="_hexColor">A string param.</param>
        /// <returns>IMyLineChart</returns>
        public IMyLineChart changeForegroundColor(string _hexColor) {
            base.changeForegroundColor(_hexColor);
            return this;
        }
    }
}
