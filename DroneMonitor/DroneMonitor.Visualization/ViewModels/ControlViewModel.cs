using DroneMonitor.Infrastructure.Base;
using DroneMonitor.Visualization.Views;
using Prism.Commands;

namespace DroneMonitor.Visualization.ViewModels {
    public class ControlViewModel : ViewModelBase {
        public ControlViewModel() {
            StartCommand = new DelegateCommand(() => {
                WindowService.Launch<VisualizationView>();
            });
        }
        public DelegateCommand StartCommand { get; }
    }
}
