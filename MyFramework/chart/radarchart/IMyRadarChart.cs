using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFramework.datastructures;

namespace MyFramework.chart.radarchart
{
    public interface IMyRadarChart
    {
        IMyRadarChart setAxisItems(MyList<string> _axisItems);

        IMyRadarChart updateSerieValue(string _seriesTitle, MyList<double> _newValues);
        IMyRadarChart addSeries(string _seriesTitle, MyList<double> _values, string _dataLineHexColor);
    }
}
