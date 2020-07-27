using System;
using System.Reflection;

namespace MyFramework.basic {
    public class MyController : IMyController
    {
        private IMyView myView;

        public MyController(IMyView _myView) {
            myView = _myView;
        }

        public void callMethod(string _myMethod) {
            MethodInfo method = this.GetType().GetMethod(_myMethod);
            method.Invoke(this, null);
        }

        public void callMethod(string _myMethod, params object[] _parameter) {
            Type type = this.GetType();
            MethodInfo method = type.GetMethod(_myMethod);
            method.Invoke(this, _parameter);
        }

        public IMyView getView() {
            return myView;
        }
    }
}
