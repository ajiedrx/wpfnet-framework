using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.chart.linechart
{
    public interface IMyLineChart
    {
        IMyLineChart setXLabels(MyList<string> _labels, string _xLabelTitle);
        IMyLineChart addSeries(string _seriesTitle, MyList<double> _values);
        IMyLineChart updateSerieValue(string _serieTitle, MyList<double> _newValues);
        IMyLineChart updateChartValue(MyList<double> _newValues);
        IMyLineChart changeSeriesFillColor(string _seriesTitle, string _hexColor);
        IMyLineChart changeSeriesLineColor(string _seriesTitle, string _hexColor);
        IMyLineChart setLegendVisibility(bool _visibility);
        IMyLineChart deleteSeries(string _seriesTitle);
        IMyLineChart setLineStyle(LineChartStyle _lineChartStyle);
        IMyLineChart changeBackgroundColor(string _hexColor);
        IMyLineChart changeForegroundColor(string _hexColor);
    }
}
