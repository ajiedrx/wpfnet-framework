using MyFramework.basic;
using MyFramework.enums;

namespace MyFramework.ui_elements.text_block
{
    public interface IMyTextBlock
    {
        IMyTextBlock setTooltip(string _tooltip);
        IMyTextBlock setFontWeight(MyFontWeight _myFontWeight);
        IMyTextBlock setFontStretch(MyFontStretch _myFontStretch);
        IMyTextBlock setFontStyle(MyFontStyle _myFontStyle);
        IMyTextBlock setTextAlignment(MyTextAlignment _myTextAlignment);
        IMyTextBlock setTextWrapping(MyTextWrapping _myTextWrapping);
        IMyTextBlock setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment);
        IMyTextBlock setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment);

        IMyTextBlock setWidth(int _width);
        int getWidth();
        IMyTextBlock setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyTextBlock setHeight(int _height);
        int getHeight();        
        IMyTextBlock setMaxHeight(int _maxHeight);
        int getMaxHeight();
        IMyTextBlock setText(string _text);
        IMyTextBlock setFontSize(int _fontSize);
        IMyTextBlock setTextColor(string _hexColor);
        IMyTextBlock setBackgroundColor(string _hexColor);
        IMyTextBlock setBackgroundImage(string _path);
        IMyTextBlock addOnPreviewMouseDown(IMyController _controller, string _methodName);
        IMyTextBlock addOnPreviewMouseDown(IMyView _view, string _methodName);
    }
}