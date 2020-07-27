using System;
using System.Reflection;
using System.Windows;

namespace MyFramework.basic {
    public class MyWindow : Window, IMyContainer, IMyView
    {
        private IMyController controller;

        public MyWindow() {

        }

        public void setController(IMyController _controller) {
            this.controller = _controller;
        }

        public IMyController getController() {
            return this.controller;
        }

        public void callMethod(string _methodName) {
            Type type = this.GetType();
            MethodInfo method = type.GetMethod(_methodName);
            method.Invoke(this, null);
        }

        public void callMethod(string _methodName, params object[] _parameter) {
            Type type = this.GetType();
            MethodInfo method = type.GetMethod(_methodName);
            method.Invoke(this, _parameter);
        }

        public object getComponentByName(string _instanceName) {
            return this.FindName(_instanceName);
        }
    }
}
