using MyFramework.basic;
using MyFramework.enums;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;

namespace MyFramework.ui_elements.progress_bar
{
    internal class MyProgressBar : MyUIElements, IMyProgressBar, IMyProgressBarInjector
    {
        private ProgressBar myProgressBar_pb;
        private IMyDuration myDuration;
        private IMyDoubleAnimation myDoubleAnimation;
        internal MyProgressBar(object _uiElement) : base((ProgressBar)_uiElement) {
            myProgressBar_pb = (ProgressBar)_uiElement;
        }

        #region properties
        /// <summary>
        /// Set the vertical alignment.
        /// </summary>
        /// <param name="_myVerticalAlignment">A MyVerticalAlignment param.</param>
        /// <typeparam name="MyVerticalAlignment"></typeparam>
        /// <returns>IMyProgressBar</returns>
        public IMyProgressBar setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment) {
            base.setVerticalAlignment(_myVerticalAlignment);
            return this;
        }
        /// <summary>
        /// Set the horizontal alignment.
        /// </summary>
        /// <param name="_myHorizontalAlignment">A MyHorizontalAlignment param.</param>
        /// <typeparam name="MyHorizontalAlignment"></typeparam>
        /// <returns>IMyProgressBar\</returns>
        public IMyProgressBar setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment) {
            base.setHorizontalAlignment(_myHorizontalAlignment);
            return this;
        }
        /// <summary>
        /// Set the flow direction of progress bar.
        /// </summary>
        /// <param name="myFlowDirection">A MyFlowDirection param.</param>
        /// <returns></returns>
        public IMyProgressBar setFlowDirection(MyFlowDirection _myFlowDirection) {
            myProgressBar_pb.FlowDirection = _myFlowDirection.getFlowDirection();
            return this;
        }
        /// <summary>
        /// Set the value of current progress.
        /// </summary>
        /// <param name="_value">A double value.</param>
        /// <returns></returns>
        public IMyProgressBar setValue(double _value) {
            myProgressBar_pb.Value = _value;
            return this;
        }
        /// <summary>
        /// Get the value of current progress.
        /// </summary>
        /// <returns></returns>
        public double getValue() {
            return myProgressBar_pb.Value;
        }
        /// <summary>
        /// Set the max value of the progress bar.
        /// </summary>
        /// <param name="_maxValue"></param>
        /// <returns></returns>
        public IMyProgressBar setMaxValue(double _maxValue) {
            myProgressBar_pb.Maximum = _maxValue;
            return this;
        }
        /// <summary>
        /// Get the max value of the progress bar.
        /// </summary>
        /// <returns></returns>
        public double getMaxValue() {
            return myProgressBar_pb.Maximum;
        }
        /// <summary>
        /// Set the progress bar mode.
        /// Default is determinate mode.
        /// </summary>
        /// <param name="_indeterminate"></param>
        /// <returns></returns>
        public IMyProgressBar setIndeterminate(bool _indeterminate) {
            myProgressBar_pb.IsIndeterminate = _indeterminate;
            return this;
        }
        /// <summary>
        /// Get the progress bar mode.
        /// </summary>
        /// <returns></returns>
        public bool isIndeterminate() {
            return myProgressBar_pb.IsIndeterminate;
        }
        /// <summary>
        /// Set the progress bar color.
        /// </summary>
        /// <param name="_color"></param>
        /// <returns></returns>
        public IMyProgressBar setColor(string _hexColor) {
            base.setTextColor(_hexColor);
            return this;
        }
        /// <summary>
        /// Set the background color.
        /// </summary>
        /// <param name="_color"></param>
        /// <returns></returns>
        public IMyProgressBar setBackgroundColor(string _hexColor) {
            base.setBackgroundColor(_hexColor);
            return this;
        }
        /// <summary>
        /// Set the width of the ProgressBar.
        /// </summary>
        /// <param name="_width">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyProgressBar</returns>
        public IMyProgressBar setWidth(int _width) {
            base.setWidth(_width);
            return this;
        }
        /// <summary>
        /// Get the width of the ProgressBar.
        /// </summary>
        /// <returns>int</returns>
        public int getWidth() {
            return base.getWidth();
        }
        /// <summary>
        /// Set the ProgressBar max width.
        /// </summary>
        /// <param name="_maxWidth">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyProgressBar</returns>
        public IMyProgressBar setMaxWidth(int _maxWidth) {
            base.setMaxWidth(_maxWidth);
            return this;
        }
        /// <summary>
        /// Get the max width of the ProgressBar.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxWidth() {
            return base.getMaxWidth();
        }
        /// <summary>
        /// Set the ProgressBar height.
        /// </summary>
        /// <param name="_height">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyProgressBar</returns>
        public IMyProgressBar setHeight(int _height) {
            base.setHeight(_height);
            return this;
        }
        /// <summary>
        /// Get the height of the ProgressBar.
        /// </summary>
        /// <returns>int</returns>
        public int getHeight() {
            return base.getHeight();
        }
        /// <summary>
        /// Set the ProgressBar max height.
        /// </summary>
        /// <param name="_maxHeight">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyProgressBar</returns>
        public IMyProgressBar setMaxHeight(int _maxHeight) {
            base.setMaxHeight(_maxHeight);
            return this;
        }
        /// <summary>
        /// Get the ProgressBar max height.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxHeight() {
            return base.getMaxHeight();
        }
        /// <summary>
        /// Animate the progress bar.
        /// </summary>
        /// <param name="_duration">A double param. (in second)</param>
        /// <param name="_value">A double param. (from 0 to 100)</param>
        /// <returns></returns>
        public IMyProgressBar animate(double _duration, double _value) {
            myDuration.setMyDuration(_duration);
            myDoubleAnimation.setMyDoubleAnimation(_value, myDuration);
            myProgressBar_pb.BeginAnimation(ProgressBar.ValueProperty, myDoubleAnimation.getDoubleAnimation());
            return this;
        }

        /// <summary>
        /// Set the background image.
        /// </summary>
        /// <remarks>Image build action must be set to Resource.</remarks>
        /// <param name="_path">A string image path param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyProgressBar</returns>
        public IMyProgressBar setBackgroundImage(string _path) {
            base.setBackgroundImage(_path);
            return this;
        }
        #endregion

        #region event-handler
        /// <summary>
        /// Add onValueChanged listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyProgressBar</returns>
        public IMyProgressBar addOnValueChanged(IMyController _controller, string _methodName) {
            myProgressBar_pb.ValueChanged += delegate (object sender, RoutedPropertyChangedEventArgs<double> e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onValueChanged listener.
        /// </summary>
        /// <param name="_view"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyProgressBar</returns>
        public IMyProgressBar addOnValueChanged(IMyView _view, string _methodName) {
            myProgressBar_pb.ValueChanged += delegate (object sender, RoutedPropertyChangedEventArgs<double> e) {
                _view.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onGotFocus listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyProgressBar</returns>
        public IMyProgressBar addOnGotFocus(IMyController _controller, string _methodName) {
            myProgressBar_pb.GotFocus += delegate (object sender, RoutedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onGotFocus listener.
        /// </summary>
        /// <param name="_view"></param>
        /// <param name="_methodName"></param>
        /// <returns></returns>
        public IMyProgressBar addOnGotFocus(IMyView _view, string _methodName) {
            myProgressBar_pb.GotFocus += delegate (object sender, RoutedEventArgs e) {
                _view.callMethod(_methodName);
            };
            return this;
        }

        #endregion

        #region set-field
        public void setMyDuration(IMyDuration _myDuration) {
            this.myDuration = _myDuration;
        }

        public void setMyDoubleAnimation(IMyDoubleAnimation _myDoubleAnimation) {
            this.myDoubleAnimation = _myDoubleAnimation;
        }

        #endregion
    }
}
