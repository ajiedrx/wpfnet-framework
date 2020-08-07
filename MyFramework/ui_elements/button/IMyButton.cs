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
        IMyButton setFontWeight(MyFontWeight _myFontWeight);
        IMyButton setFontStretch(MyFontStretch _myFontStretch);

        IMyButton setFontSize(int _fontSize);
        IMyButton setFontStyle(MyFontStyle _myFontStyle);
        IMyButton setTextVerticalAlignment(MyVerticalAlignment _myVerticalAlignment);
        IMyButton setTextHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment);
        IMyButton setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment);
        IMyButton setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment);

        IMyButton setText(string _text);

        IMyButton setWidth(int _width);
        int getWidth();
        IMyButton setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyButton setHeight(int _height);
        int getHeight();
        IMyButton setMaxHeight(int _maxHeight);
        int getMaxHeight();

        IMyButton setBackgroundColor(string _hexColor);

        IMyButton setBackgroundImage(string _path);

        IMyButton setTextColor(string _hexColor);
        IMyButton addOnClick(IMyController _controller, string _methodName);
        IMyButton addOnClick(IMyView _view, string _methodName);
        IMyButton addOnMouseDown(IMyController _controller, string _methodName);
        IMyButton addOnMouseUp(IMyController _controller, string _methodName);

        IMyButton addOnMouseHover(IMyController _controller, string _methodName);
        IMyButton addOnMouseHover(IMyView _view, string _methodName);

    }
}
