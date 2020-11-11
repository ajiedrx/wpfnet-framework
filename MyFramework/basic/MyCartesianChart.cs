using LiveCharts;
using LiveCharts.Wpf;
using MyFramework.enums;
using System.Collections.Generic;
using MyFramework.datastructures;

namespace MyFramework.basic {
    public class MyCartesianChart {

        private CartesianChart cartesianChart;
        private MyCartesianChartType myCartesianChartType;
        private IMySolidColorBrush mySolidColorBrush;

        public MyCartesianChart(CartesianChart _cartesianChart, MyCartesianChartType _chartType) {
            mySolidColorBrush = new MySolidColorBrush();
            cartesianChart = _cartesianChart;
            myCartesianChartType = _chartType;
        }

        public void setXLabels(MyList<string> _labels, string _xLabelTitle) {
            cartesianChart.AxisX.Add(new Axis() {
                Labels = new MyList<string>(_labels),
                Title = _xLabelTitle
            });
        }

        public void setLegendVisibility(bool _visible) {
            if (_visible) {
                this.cartesianChart.ChartLegend.Visibility = System.Windows.Visibility.Visible;
            } else
                this.cartesianChart.ChartLegend.Visibility = System.Windows.Visibility.Hidden;
        }

        public void addSeries(string _seriesTitle, MyList<double> _values) {
            ChartValues<double> chartValues = new ChartValues<double>(_values);
            if (myCartesianChartType.Equals(MyCartesianChartType.BAR)) {
                cartesianChart.Series.Add(createColumnSeries(null, _seriesTitle, chartValues));
            } else {
                cartesianChart.Series.Add(createLineSeries(null, _seriesTitle, chartValues));
            }
            
        }

        private ColumnSeries createColumnSeries(string _hexColor, string _seriesTitle, ChartValues<double> _chartValues) {
            return new ColumnSeries() {
                Fill = mySolidColorBrush.convertFromHex(_hexColor),
                Title = _seriesTitle,
                Values = _chartValues
            };
        }

        private LineSeries createLineSeries(string _hexColor, string _seriesTitle, ChartValues<double> _chartValues) {
            return new LineSeries() {
                Fill = mySolidColorBrush.convertFromHex(_hexColor),
                Title = _seriesTitle,
                Values = _chartValues
            };
        }


        public void updateSerieValue(string _serieTitle, MyList<double> _newValues) {
            ChartValues<double> chartValues = new ChartValues<double>();
            foreach (double aValue in _newValues) {
                chartValues.Add(aValue);
            }
            for (int i = 0; i < cartesianChart.Series.Count; i++) {
                if (cartesianChart.Series[i].Title.Equals(_serieTitle)) {
                    cartesianChart.Series[i].Values = null;
                    cartesianChart.Series[i].Values = chartValues;
                }
            }
        }

        public void updateChartValue(MyList<double> _newValues) {
            ChartValues<double> chartValues = new ChartValues<double>();
            foreach (double aValue in _newValues) {
                chartValues.Add(aValue);
            }
            for (int i = 0; i < cartesianChart.Series.Count; i++) {
                cartesianChart.Series[i].Values = null;
                cartesianChart.Series[i].Values = chartValues;
            }
        }

        public void changeSeriesFillColor(string _seriesTitle, string _hexColor) {
            ChartValues<double> chartValuesTemp = new ChartValues<double>();
            for (int i = 0; i < cartesianChart.Series.Count; i++) {
                if (cartesianChart.Series[i].Title.Equals(_seriesTitle)) {
                    foreach (double aValue in cartesianChart.Series[i].Values) {
                        chartValuesTemp.Add(aValue);
                    }
                    if (myCartesianChartType.Equals(MyCartesianChartType.BAR)) {
                        cartesianChart.Series[i] = createColumnSeries(_hexColor, _seriesTitle, chartValuesTemp);
                    } else {
                        cartesianChart.Series[i] = createLineSeries(_hexColor, _seriesTitle, chartValuesTemp);
                    }
                }
            }
        }

        public void deleteSeries(string _seriesTitle) {
            for (int i = 0; i < cartesianChart.Series.Count; i++) {
                if (cartesianChart.Series[i].Title.Equals(_seriesTitle)) {
                    cartesianChart.Series.RemoveAt(i);
                }
            }
        }

        public void changeBackgroundColor(string _hexColor) {
            cartesianChart.Background = mySolidColorBrush.convertFromHex(_hexColor);
        }

        public void changeForegroundColor(string _hexColor) {
            cartesianChart.Foreground = mySolidColorBrush.convertFromHex(_hexColor);
        }
    }
}
