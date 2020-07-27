using MyFramework.basic;
using MyFramework.enums;

namespace MyFramework.ui_elements.progress_bar
{
    public interface IMyProgressBar
    {
        IMyProgressBar setVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyProgressBar setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);
        IMyProgressBar setValue(double _value);
        IMyProgressBar setFlowDirection(MyFlowDirection myFlowDirection);
        double getValue();
        IMyProgressBar setMaxValue(double _maxValue);
        double getMaxValue();
        IMyProgressBar setIndeterminate(bool _indeterminate);
        bool isIndeterminate();
        IMyProgressBar setColor(string _color);
        IMyProgressBar setBackgroundColor(string _color);
        IMyProgressBar setWidth(int _width);
        int getWidth();
        IMyProgressBar setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyProgressBar setHeight(int _height);
        int getHeight();
        IMyProgressBar setMaxHeight(int _maxHeight);
        int getMaxHeight();
        IMyProgressBar animate(double _duration, double _value);
        IMyProgressBar addOnValueChanged(IMyController _controller, string _methodName);
    }
}