﻿using Velacro.Basic;

namespace Velacro.Chart.LineChart
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
