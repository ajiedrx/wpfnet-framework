using MyFramework.basic;
using MyFramework.ui_elements.button;
using MyFramework.ui_elements.progress_bar;


namespace MyFramework {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MyWindow {
        BuilderButton builderButton;
        BuilderProgressBar builderProgressBar;
        IMyButton testButton;

        public MainWindow() {
            InitializeComponent();
            builderButton = new BuilderButton();
            testButton = builderButton
                .activate(this, "testButton_btn")
                .addOnClick(this, "testMethod")
                .setTooltip("Ini button Test")
                .setBackgroundImage("images/WORLDMAP.png");
        }

        public void testMethod() {
            this.Close();
        }
    }
}
