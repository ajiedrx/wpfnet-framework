using Velacro.Basic;
using Velacro.Enums;

namespace Velacro.UIElements.ProgressBar
{
    public interface IMyProgressBar
    {
        IMyProgressBar setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment);
        IMyProgressBar setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment);
        IMyProgressBar setValue(double _value);
        IMyProgressBar setFlowDirection(MyFlowDirection _myFlowDirection);
        double getValue();
        IMyProgressBar setMaxValue(double _maxValue);
        double getMaxValue();
        IMyProgressBar setIndeterminate(bool _indeterminate);
        bool isIndeterminate();
        IMyProgressBar setColor(string _hexColor);
        IMyProgressBar setBackgroundColor(string _hexColor);
        IMyProgressBar setWidth(int _width);
        int getWidth();
        IMyProgressBar setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyProgressBar setHeight(int _height);
        int getHeight();
        IMyProgressBar setMaxHeight(int _maxHeight);
        int getMaxHeight();
        IMyProgressBar animate(double _duration, double _value);
        IMyProgressBar setBackgroundImage(string _path);
        IMyProgressBar addOnValueChanged(IMyController _controller, string _methodName);
        IMyProgressBar addOnGotFocus(IMyController _controller, string _methodName);
        IMyProgressBar addOnValueChanged(IMyView _view, string _methodName);
        IMyProgressBar addOnGotFocus(IMyView _view, string _methodName);
    }
}