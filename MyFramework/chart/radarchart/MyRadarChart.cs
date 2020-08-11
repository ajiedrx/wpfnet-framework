using MyFramework.basic;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using WpfCharts;


namespace MyFramework.chart.radarchart
{
    class MyRadarChart : IMyRadarChart
    {
        private IMySolidColorBrush      mySolidColorBrush;
        private SpiderChart             radarChart;
        ObservableCollection<ChartLine> lines;
        internal MyRadarChart(object _radarChart) {
            this.radarChart = (SpiderChart)_radarChart;
            this.mySolidColorBrush = new MySolidColorBrush();
            this.lines = new ObservableCollection<ChartLine>();
            radarChart.ShowLegend = true;
            radarChart.LegendLocation = LegendLocation.BottomRight;
            radarChart.Minimum = 1;
            radarChart.Ticks = 5;
        }
        /// <summary>
        /// Set the axis items.
        /// </summary>
        /// <param name="_axisItems"></param>
        /// <returns>IMyRadarChart</returns>
        public IMyRadarChart setAxisItems(MyList<string> _axisItems) {
            string[] items = new string[_axisItems.Count];
            for (int i = 0; i < _axisItems.Count; i++) {
                items[i] = _axisItems[i];
            }
            this.radarChart.Axis = items;
            return this;
        }
        private double getMaxValue(MyList<double> _values) {
            double max = 0;
            Collection<double> valuesCollection = new Collection<double>(_values);
            max = valuesCollection.Max();
            return max;
        }
        /// <summary>
        /// Add one series to the chart.
        /// </summary>
        /// <param name="_seriesTitle">A string param.</param>
        /// <param name="_values">MyList of double param.</param>
        /// <param name="_dataLineHexColor">
        /// A string hex color param.
        /// If it's null, it will use the default color.
        /// </param>
        /// <returns>IMyRadarChart</returns>
        public IMyRadarChart addSeries(string _seriesTitle, MyList<double> _values, string _dataLineHexColor) {
            if (radarChart.Maximum < getMaxValue(_values)) {
                radarChart.Maximum = getMaxValue(_values);
            }
            lines.Add(new ChartLine()
            {
                LineColor = mySolidColorBrush.convertStringToColor(_dataLineHexColor),
                LineThickness = 1,
                PointDataSource = _values,
                Name = _seriesTitle
            });
            this.radarChart.Lines = lines;
            return this;
        }
        /// <summary>
        /// Update a serie value based on serie title.
        /// </summary>
        /// <param name="_seriesTitle">A string param.</param>
        /// <param name="_newValues">MyList of double param.</param>
        /// <returns>IMyRadarChart</returns>
        public IMyRadarChart updateSerieValue(string _seriesTitle, MyList<double> _newValues)
        {
            ChartLine temp;
            for (int i = 0; i < radarChart.Lines.ToList().Count; i++)
            {
                if (radarChart.Lines.ToList()[i].Name.Equals(_seriesTitle))
                {
                    temp = radarChart.Lines.ToList()[i];
                    radarChart.Lines.ToList()[i] = new ChartLine()
                    {
                        LineColor = temp.LineColor,
                        LineThickness = temp.LineThickness,
                        PointDataSource = _newValues,
                        Name = temp.Name
                    };
                    if (radarChart.Maximum < getMaxValue(_newValues))
                    {
                        radarChart.Maximum = getMaxValue(_newValues);
                    }
                }
            }
            return this;
        }
    }
}
