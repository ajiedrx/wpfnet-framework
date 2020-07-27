using MyFramework.basic;
using MyFramework.enums;
using MyFramework.validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace MyFramework.ui_elements.text_box
{
    internal class MyTextBox : IMyTextBox, IMyTextBoxInjector
    {
        private TextBox myTextBox_txt;
        private IMySolidColorBrush mySolidColorBrush;
        private MyRegex myRegex;

        internal MyTextBox(Object _deployedTextBox) {
            myTextBox_txt = (TextBox)_deployedTextBox;
        }

        #region properties
        public IMyTextBox setTooltip(string _tooltip) {
            myTextBox_txt.ToolTip = _tooltip;
            return this;
        }

        public IMyTextBox setFontWeight(MyFontWeight myFontWeight) {
            myTextBox_txt.FontWeight = myFontWeight.getFontWeight();
            return this;
        }

        public IMyTextBox setFontStretch(MyFontStretch myFontStretch) {
            myTextBox_txt.FontStretch = myFontStretch.getFontStretch();
            return this;
        }

        public IMyTextBox setFontSize(int _fontSize) {
            myTextBox_txt.FontSize = _fontSize;
            return this;
        }

        public IMyTextBox setFontStyle(MyFontStyle myFontStyle) {
            myTextBox_txt.FontStyle = myFontStyle.getFontStyle();
            return this;
        }

        public IMyTextBox setTextVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myTextBox_txt.VerticalContentAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }

        public IMyTextBox setTextHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myTextBox_txt.HorizontalContentAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyTextBox setVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myTextBox_txt.VerticalAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }

        public IMyTextBox setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myTextBox_txt.HorizontalAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyTextBox setText(string _text) {
            myTextBox_txt.Text = _text;
            return this;
        }

        public String getText() {
            return myTextBox_txt.Text.ToString();
        }

        public IMyTextBox setWidth(int _width) {
            myTextBox_txt.Width = _width;
            return this;
        }
        public int getWidth() {
            return (int)myTextBox_txt.Width;
        }

        public IMyTextBox setMaxWidth(int _maxWidth) {
            myTextBox_txt.MaxWidth = _maxWidth;
            return this;
        }
        public int getMaxWidth() {
            return (int)myTextBox_txt.MaxWidth;
        }

        public IMyTextBox setHeight(int _height) {
            myTextBox_txt.Height = _height;
            return this;
        }
        public int getHeight() {
            return (int)myTextBox_txt.Height;
        }

        public IMyTextBox setMaxHeight(int _maxHeight) {
            myTextBox_txt.MaxHeight = _maxHeight;
            return this;
        }
        public int getMaxHeight() {
            return (int)myTextBox_txt.MaxHeight;
        }

        public IMyTextBox setMaxLength(int _maxLength){
            myTextBox_txt.MaxLength = _maxLength;
            return this;
        }

        public IMyTextBox setBackgroundColor(string _color) {
            myTextBox_txt.Background = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public IMyTextBox setTextColor(string _color) {
            myTextBox_txt.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        #endregion

        #region event-handler

        public IMyTextBox setInputValidation(Validator _validator) {
            myRegex = _validator.getMyRegex();
            return this;
        }

        public bool getInputValidation() {
            return myRegex.IsMatch(getText());
        }

        //private void validationHandler(object sender, TextCompositionEventArgs e) {
        //    e.Handled = myRegex.IsMatch(e.Text);
        //}

        public IMyTextBox addOnTextChanged(IMyController _controller, string _methodName) {
            myTextBox_txt.TextChanged += delegate (object sender, TextChangedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        
        public IMyTextBox addOnGotFocus(IMyController _controller, string _methodName) {
            myTextBox_txt.GotFocus += delegate (object sender, System.Windows.RoutedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        public IMyTextBox addOnPreviewMouseDown(IMyController _controller, string _methodName) {
            myTextBox_txt.PreviewMouseDown += delegate (object sender, MouseButtonEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        } 

        #endregion

        #region set-field

        public void setMySolidColorBrush(IMySolidColorBrush _mySolidColorBrush) {
            this.mySolidColorBrush = _mySolidColorBrush;
        }

        #endregion

    }
}
