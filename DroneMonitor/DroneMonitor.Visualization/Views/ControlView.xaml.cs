using DroneMonitor.Visualization.ViewModels;
using System.Windows.Controls;

namespace DroneMonitor.Visualization.Views {
    /// <summary>
    /// Interaction logic for ControlView.xaml
    /// </summary>
    public partial class ControlView : UserControl {
        public ControlView() {
            InitializeComponent();
            DataContext = new ControlViewModel();
        }
    }
}
