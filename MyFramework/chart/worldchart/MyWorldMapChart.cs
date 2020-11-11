using LiveCharts.Wpf;
using MyFramework.basic;
using System;
using MyFramework.datastructures;

namespace MyFramework.chart.worldchart
{
    /// <summary>
    /// The WorldChartMap main class.
    /// </summary>
    class MyWorldMapChart : IMyWorldMapChart
    {
        private GeoMap worldMapChart;
        internal MyWorldMapChart(Object _worldMapChart) {
            this.worldMapChart = (GeoMap)_worldMapChart;
        }
        /// <summary>
        /// Set the XML map file location.
        /// </summary>
        /// <param name="_XMLfullPath"></param>
        /// <returns></returns>
        public IMyWorldMapChart setXMLMapFile(string _XMLfullPath) {
            this.worldMapChart.Source = _XMLfullPath;
            return this;
        }
        /// <summary>
        /// Set each value of the locations.
        /// </summary>
        /// <param name="_countryISOAlpha2Code">MyList of string param.</param>
        /// <param name="_values">MyList of double param.</param>
        /// <returns></returns>
        public IMyWorldMapChart setValues(MyList<string> _countryISOAlpha2Code,MyList<double> _values) {
            for (int i = 0; i < _values.Count; i++) {
                worldMapChart.HeatMap.Add(_countryISOAlpha2Code[i], _values[i]);
            }
            return this;
        }
    }
}
