using MyFramework.basic;
using MyFramework.enums;

namespace MyFramework.ui_elements.text_block
{
    public interface IMyTextBlock
    {
        IMyTextBlock setTooltip(string _tooltip);
        IMyTextBlock setFontWeight(MyFontWeight myFontWeight);
        IMyTextBlock setFontStretch(MyFontStretch myFontStretch);
        IMyTextBlock setFontStyle(MyFontStyle myFontStyle);
        IMyTextBlock setTextAlignment(MyTextAlignment myTextAlignment);
        IMyTextBlock setTextWrapping(MyTextWrapping myTextWrapping);
        IMyTextBlock setVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyTextBlock setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);

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
        IMyTextBlock setTextColor(string _color);
        IMyTextBlock setBackgroundColor(string _color);
        IMyTextBlock addOnPreviewMouseDown(IMyController _controller, string _methodName);
    }
}