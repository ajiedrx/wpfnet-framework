﻿using System;
using LiveCharts;
using LiveCharts.Wpf;
using Velacro.Basic;
using Velacro.UIElements.Basic;

namespace Velacro.Chart.PieChart
{
    /// <summary>
    /// The PieChart main class.
    /// </summary>
    class MyPieChart : IMyPieChart
    {
        private LiveCharts.Wpf.PieChart pieChart;
        private IMySolidColorBrush mySolidColorBrush;
        private string pointLabel = "";

        internal MyPieChart(Object _pieChart) {
            this.pieChart = (LiveCharts.Wpf.PieChart)_pieChart;
            setMySolidColorBrush(new MySolidColorBrush());
        }
        /// <summary>
        /// Add series to the chart.
        /// </summary>
        /// <remarks>
        /// One series contains one values.
        /// </remarks>
        /// <param name="_seriesTitle">A string param.</param>
        /// <param name="_values">MyList of double param.</param>
        /// <returns>IMyPieChart</returns>
        public IMyPieChart addSeries(MyList<string> _seriesLabels, MyList<double> _values) {
            for (int i = 0; i < _values.Count; i++) {
                ChartValues<double> value = new ChartValues<double>() { _values[i] };
                pieChart.Series.Add(new PieSeries() {
                    Title = _seriesLabels[i],
                    Values = value,
                    DataLabels = true,
                 
                });
            }
            return this;
        }
        /// <summary>
        /// Add series with point label, such as "%, $, etc."
        /// </summary>
        /// <param name="_seriesLabels">MyList of string param.</param>
        /// <param name="_values">MyList of double param.</param>
        /// <param name="_pointLabel">A string param.</param>
        /// <returns></returns>
        public IMyPieChart addSeriesWithPointLabel(MyList<string> _seriesLabels, MyList<double> _values, string _pointLabel) {
            this.pointLabel = _pointLabel;
            for(int i = 0; i < _values.Count; i++) {
                ChartValues<double> value = new ChartValues<double>() { _values[i] };
                pieChart.Series.Add(new PieSeries() {
                    Title = _seriesLabels[i],
                    Values = value,
                    LabelPoint = chartPoint => string.Format("{0} {1:P}", value[0].ToString(), _pointLabel),
                    DataLabels = true
                });
            }
            return this;
        }
        /// <summary>
        /// Update overall chart values.
        /// </summary>
        /// <remarks>
        /// Values sequences based on series sequence's.
        /// </remarks>
        /// <param name="_newValues">MyList of double param.</param>
        /// <returns>IMyPieChart</returns>
        public IMyPieChart updateChartValue(MyList<double> _newValues) {
            for (int i = 0; i < pieChart.Series.Count; i++) {
                ChartValues<double> value = new ChartValues<double>() { _newValues[i] };
                pieChart.Series[i].Values = null;
                pieChart.Series[i].Values = value;
                pieChart.Series[i].LabelPoint = chartPoint => string.Format("{0} {1:P}", value[0].ToString(), this.pointLabel);
            }
            return this;
        }
        /// <summary>
        /// Change all series fill color.
        /// </summary>
        /// <param name="_seriesTitle"></param>
        /// <param name="_hexColor"></param>
        /// <returns>IMyPieChart</returns>
        public IMyPieChart changeSeriesFillColor(MyList<string> _hexColor) {
            LiveCharts.Wpf.PieChart chartTemp;
            chartTemp = pieChart;
            for (int i = 0; i < pieChart.Series.Count; i++) {
                pieChart.Series[i] = new PieSeries() {
                    Fill = mySolidColorBrush.convertFromHex(_hexColor[i]),
                    Title = chartTemp.Series[i].Title,
                    Values = chartTemp.Series[i].Values,
                    DataLabels = chartTemp.Series[i].DataLabels,
                    LabelPoint = chartTemp.Series[i].LabelPoint
                };
            }
            return this;
        }
        /// <summary>
        /// Change series fill color based on a serie's title.
        /// </summary>
        /// <param name="_seriesTitle"></param>
        /// <param name="_hexColor"></param>
        /// <returns>IMyPieChart</returns>
        public IMyPieChart changeOneSeriesFillColor(string _seriesLabel, string _hexColor) {
            LiveCharts.Wpf.PieChart chartTemp;
            chartTemp = pieChart;
            for (int i = 0; i < pieChart.Series.Count; i++) {
                if (pieChart.Series[i].Title.Equals(_seriesLabel)) {
                    pieChart.Series[i] = new PieSeries() {
                        Fill = mySolidColorBrush.convertFromHex(_hexColor),
                        Title = chartTemp.Series[i].Title,
                        Values = chartTemp.Series[i].Values,
                        DataLabels = chartTemp.Series[i].DataLabels,
                        LabelPoint = chartTemp.Series[i].LabelPoint
                    };
                }
            }
            return this;
        }

        /// <summary>
        /// Delete one serie.
        /// </summary>
        /// <param name="_seriesTitle">A string param.</param>
        /// <returns>IMyPieChart</returns>
        public IMyPieChart deleteSeries(string _seriesTitle) {
            for (int i = 0; i < pieChart.Series.Count; i++) {
                if (pieChart.Series[i].Title.Equals(_seriesTitle)) {
                    pieChart.Series.RemoveAt(i);
                }
            }
            return this;
        }

        private void setMySolidColorBrush(IMySolidColorBrush _mySolidColorBrush)  {
            this.mySolidColorBrush = _mySolidColorBrush;
        }
        /// <summary>
        /// Change the background color.
        /// </summary>
        /// <param name="_hexColor">A string param.</param>
        /// <returns>IMyPieChart</returns>
        public IMyPieChart changeBackgroundColor(string _hexColor) {
            pieChart.Background = mySolidColorBrush.convertFromHex(_hexColor);
            return this;
        }
        /// <summary>
        /// Change the foreground color.
        /// </summary>
        /// <param name="_hexColor">A string param.</param>
        /// <returns>IMyPieChart</returns>
        public IMyPieChart changeForegroundColor(string _hexColor) {
            pieChart.Foreground = mySolidColorBrush.convertFromHex(_hexColor);
            return this;
        }
    }
}
