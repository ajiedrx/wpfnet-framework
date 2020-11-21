using Velacro.Basic;

namespace Velacro.Chart.BarChart
{
    public interface IMyBarChart
    {
        IMyBarChart setXLabels(MyList<string> _labels, string _xLabelTitle);
        IMyBarChart addSeries(string _seriesTitle, MyList<double> _values);
        IMyBarChart updateSerieValue(string _serieTitle, MyList<double> _newValues);
        IMyBarChart updateChartValue(MyList<double> _newValues);
        IMyBarChart changeSeriesFillColor(string _seriesTitle, string _hexColor);
        IMyBarChart setLegendVisibility(bool _visibility);
        IMyBarChart deleteSeries(string _seriesTitle);
        IMyBarChart changeBackgroundColor(string _hexColor);
        IMyBarChart changeForegroundColor(string _hexColor);
    }
}
