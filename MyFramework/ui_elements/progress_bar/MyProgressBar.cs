using MyFramework.basic;
using MyFramework.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MyFramework.ui_elements.progress_bar
{
    internal class MyProgressBar : IMyProgressBar, IMyProgressBarInjector
    {
        private ProgressBar myProgressBar_pb;
        private IMySolidColorBrush mySolidColorBrush;
        private IMyDuration myDuration;
        private IMyDoubleAnimation myDoubleAnimation;
        internal MyProgressBar(Object _developedProgressBar) {
            myProgressBar_pb = (ProgressBar)_developedProgressBar;
        }

        #region properties
        public IMyProgressBar setVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myProgressBar_pb.VerticalAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }

        public IMyProgressBar setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myProgressBar_pb.HorizontalAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyProgressBar setFlowDirection(MyFlowDirection myFlowDirection) {
            myProgressBar_pb.FlowDirection = myFlowDirection.getFlowDirection();
            return this;
        }

        public IMyProgressBar setValue(double _value) {
            myProgressBar_pb.Value = _value;
            return this;
        }
        public double getValue() {
            return myProgressBar_pb.Value;
        }

        public IMyProgressBar setMaxValue(double _maxValue) {
            myProgressBar_pb.Maximum = _maxValue;
            return this;
        }
        public double getMaxValue() {
            return myProgressBar_pb.Maximum;
        }

        public IMyProgressBar setIndeterminate(bool _indeterminate) {
            myProgressBar_pb.IsIndeterminate = _indeterminate;
            return this;
        }
        public bool isIndeterminate() {
            return myProgressBar_pb.IsIndeterminate;
        }
        
        public IMyProgressBar setColor(string _color) {
            myProgressBar_pb.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }
        public IMyProgressBar setBackgroundColor(string _color) {
            myProgressBar_pb.Background = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public IMyProgressBar setWidth(int _width) {
            myProgressBar_pb.Width = _width;
            return this;
        }
        public int getWidth() {
            return (int)myProgressBar_pb.Width;
        }

        public IMyProgressBar setMaxWidth(int _maxWidth) {
            myProgressBar_pb.MaxWidth = _maxWidth;
            return this;
        }
        public int getMaxWidth() {
            return (int)myProgressBar_pb.MaxWidth;
        }

        public IMyProgressBar setHeight(int _height) {
            myProgressBar_pb.Height = _height;
            return this;
        }
        public int getHeight() {
            return (int)myProgressBar_pb.Height;
        }

        public IMyProgressBar setMaxHeight(int _maxHeight) {
            myProgressBar_pb.MaxHeight = _maxHeight;
            return this;
        }
        public int getMaxHeight() {
            return (int)myProgressBar_pb.MaxHeight;
        }
        
        public IMyProgressBar animate(double _duration, double _value) {
            myDuration.setMyDuration(_duration);
            myDoubleAnimation.setMyDoubleAnimation(_value, myDuration);
            myProgressBar_pb.BeginAnimation(ProgressBar.ValueProperty, myDoubleAnimation.getDoubleAnimation());
            return this;
        }

        #endregion

        #region event-handler

        public IMyProgressBar addOnValueChanged(IMyController _controller, string _methodName) {
            myProgressBar_pb.ValueChanged += delegate (object sender, RoutedPropertyChangedEventArgs<double> e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        public IMyProgressBar addOnGotFocus(IMyController _controller, string _methodName) {
            myProgressBar_pb.GotFocus += delegate (object sender, RoutedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        #endregion

        #region set-field

        public void setMySolidColorBrush(IMySolidColorBrush _mySolidColorBrush) {
            mySolidColorBrush = _mySolidColorBrush;
        }

        public void setMyDuration(IMyDuration _myDuration) {
            this.myDuration = _myDuration;
        }

        public void setMyDoubleAnimation(IMyDoubleAnimation _myDoubleAnimation) {
            this.myDoubleAnimation = _myDoubleAnimation;
        }

        #endregion
    }
}
