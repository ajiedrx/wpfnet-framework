namespace MyFramework.basic {
    public interface IMyView : IMyMethodCaller
    {
        void setController(IMyController _controller);
    }
}
