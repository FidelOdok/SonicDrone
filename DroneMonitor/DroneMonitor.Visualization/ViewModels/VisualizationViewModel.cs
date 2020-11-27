using DroneMonitor.Infrastructure.Base;
using System.IO.Ports;

namespace DroneMonitor.Visualization.ViewModels {
    public class VisualizationViewModel : ViewModelBase {
        public VisualizationViewModel() {
             Ports = SerialPort.GetPortNames();
        }

        public string[] Ports { get; set; }
    }
}
