using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.chart.piechart
{
    public interface IMyPieChart
    {
        IMyPieChart addSeriesWithPointLabel(MyList<string> _seriesLabels, MyList<double> _values, string _pointLabel);
        IMyPieChart addSeries(MyList<string> _seriesLabels, MyList<double> _values);
        IMyPieChart updateChartValue(MyList<double> _newValues);
        //IMyPieChart changeSeriesFillColor(string _seriesLabel, string _hexColor);
        IMyPieChart changeSeriesFillColor(MyList<string> _hexColor);
        IMyPieChart deleteSeries(string _seriesTitle);
        IMyPieChart changeBackgroundColor(string _hexColor);
        IMyPieChart changeForegroundColor(string _hexColor);
    }
}
