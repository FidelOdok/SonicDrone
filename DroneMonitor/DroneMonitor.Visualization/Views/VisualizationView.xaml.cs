using DroneMonitor.Visualization.ViewModels;
using System.Windows.Controls;

namespace DroneMonitor.Visualization.Views {
    /// <summary>
    /// Interaction logic for VisualizationView.xaml
    /// </summary>
    public partial class VisualizationView : UserControl {
        public VisualizationView() {
            InitializeComponent();
            DataContext = new VisualizationViewModel();
            browser.Navigate("https://google.com");
        }
    }
}
