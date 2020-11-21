using Velacro.UIElements.Basic;

namespace Velacro.UIElements.ProgressBar
{
    /// <summary>
    /// The ProgressBar element builder class.
    /// </summary>
    /// <remarks>
    /// For more detailed information please refer to the main class of the element.
    /// Below is an usage example
    /// </remarks>
    /// <example>
    /// <code>
    /// builderProgressBar = new BuilderProgressBar();
    /// testProgressBar = builderProgressBar
    ///         .activate(this, "testProgressBar_psb")
    ///         .animate(10,100);
    /// </code>
    /// </example>
    public class BuilderProgressBar
    {
        private IMyDuration myDuration = new MyDuration();
        private IMyDoubleAnimation myDoubleAnimation = new MyDoubleAnimation();

        public BuilderProgressBar() { }
        /// <summary>
        /// Method for getting the UI Element instance.
        /// </summary>
        /// <param name="_container"></param>
        /// <param name="_instanceName"></param>
        /// <returns>IMyProgressBar</returns>
        public IMyProgressBar activate(IMyContainer _container, string _instanceName)
        {
            IMyProgressBar myProgressBar = new MyProgressBar(_container.getComponentByName(_instanceName));

            IMyProgressBarInjector myProgressBarInjector = (IMyProgressBarInjector)myProgressBar;
            myProgressBarInjector.setMyDuration(myDuration);
            myProgressBarInjector.setMyDoubleAnimation(myDoubleAnimation);

            return myProgressBar;
        }

    }
}
