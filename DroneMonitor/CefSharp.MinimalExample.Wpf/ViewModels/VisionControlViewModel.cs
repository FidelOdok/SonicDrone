using DroneMonitor.Infrastructure.Base;
using Prism.Commands;
using System;

namespace DroneMonitor.Vision.ViewModels {
    public class VisionControlViewModel : ViewModelBase {
        public VisionControlViewModel() {
            StartCommand = new DelegateCommand(StartAction);
        }

        private void StartAction() {
            WindowService.Launch<Views.Vision>();
        }

        public DelegateCommand StartCommand { get; }
    }
}
