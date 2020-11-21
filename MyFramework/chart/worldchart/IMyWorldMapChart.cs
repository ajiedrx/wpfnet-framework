using Velacro.Basic;

namespace Velacro.Chart.WorldChart
{
    public interface IMyWorldMapChart
    {
        IMyWorldMapChart setXMLMapFile(string _XMLfullPath);
        IMyWorldMapChart setValues(MyList<string> _countryISOAlpha2Code, MyList<double> _values);
    }
}
