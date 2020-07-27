using MyFramework.basic;

namespace MyFramework.ui_elements.text_block
{
    public class BuilderTextBlock
    {
        private IMySolidColorBrush mySolidColorBrush = new MySolidColorBrush();
        public BuilderTextBlock() { }
        public IMyTextBlock activate(IMyContainer _container, string _instanceName) {
            IMyTextBlock myTextBlock = new MyTextBlock(_container.getComponentByName(_instanceName));

            IMyTextBlockInjector myTextBlockInjector = (IMyTextBlockInjector)myTextBlock;
            myTextBlockInjector.setMySolidColorBrush(mySolidColorBrush);

            return myTextBlock;
        }
    }
}
