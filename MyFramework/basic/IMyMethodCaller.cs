﻿namespace MyFramework.basic {
    public interface IMyMethodCaller
    {
        void callMethod(string _methodName);
        void callMethod(string _methodName, params object[] _parameters);
    }
}