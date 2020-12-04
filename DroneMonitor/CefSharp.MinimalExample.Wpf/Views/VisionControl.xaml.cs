using DroneMonitor.Vision.ViewModels;
using System.Windows.Controls;

namespace DroneMonitor.Vision.Views {
    /// <summary>
    /// Interaction logic for VisionControl.xaml
    /// </summary>
    public partial class VisionControl : UserControl {
        public VisionControl() {
            InitializeComponent();
            DataContext = new VisionControlViewModel();
        }
    }
}
