using MyFramework.basic;
using MyFramework.chart.linechart;
using MyFramework.ui_elements.button;
using MyFramework.ui_elements.data_grid;
using MyFramework.ui_elements.list_box;
using MyFramework.ui_elements.list_view;
using MyFramework.ui_elements.password_box;
using MyFramework.ui_elements.progress_bar;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using MyFramework.api;
using MyFramework.datastructures;
using MyFramework.localfile;
using Newtonsoft.Json.Linq;
using RestSharp;
using ApiClient = MyFramework.api;
using Image = System.Drawing.Image;

namespace MyFramework {
    public partial class MainWindow : MyWindow{
        public MainWindow() {
            InitializeComponent();
            string token = "";
            
        }

        public void execute(){
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e){
            execute();
        }
    }
}
