using MyFramework.basic;
using MyFramework.datastructures;

namespace MyFramework.chart.worldchart
{
    public interface IMyWorldMapChart
    {
        IMyWorldMapChart setXMLMapFile(string _XMLfullPath);
        IMyWorldMapChart setValues(MyList<string> _countryISOAlpha2Code, MyList<double> _values);
    }
}
