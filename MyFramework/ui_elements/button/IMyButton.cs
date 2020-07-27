using MyFramework.basic;
using MyFramework.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyFramework.ui_elements.button {
    public interface IMyButton
    {
        IMyButton setTooltip(string _tooltip);
        IMyButton setFontWeight(MyFontWeight myFontWeight);
        IMyButton setFontStretch(MyFontStretch myFontStretch);

        IMyButton setFontSize(int _fontSize);
        IMyButton setFontStyle(MyFontStyle myFontStyle);
        IMyButton setTextVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyButton setTextHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);
        IMyButton setVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyButton setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);

        IMyButton setText(string _text);

        IMyButton setWidth(int _width);
        int getWidth();
        IMyButton setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyButton setHeight(int _height);
        int getHeight();
        IMyButton setMaxHeight(int _maxHeight);
        int getMaxHeight();

        IMyButton setBackgroundColor(string _color);

        IMyButton setBackgroundImage(string _path);

        IMyButton setTextColor(string _color);
        IMyButton addOnClick(IMyController _controller, string _methodName);
        IMyButton addOnClick(IMyView _view, string _methodName);
        IMyButton addOnMouseDown(IMyController _controller, string _methodName);
        IMyButton addOnMouseUp(IMyController _controller, string _methodName);

    }
}
