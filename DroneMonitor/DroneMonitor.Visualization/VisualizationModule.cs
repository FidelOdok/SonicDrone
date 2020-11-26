using DroneMonitor.Infrastructure.Utils;
using DroneMonitor.Visualization.Views;
using Microsoft.Practices.ServiceLocation;
using Prism.Modularity;
using Prism.Regions;

namespace DroneMonitor.Visualization {
    public class VisualizationModule : IModule {
        public void Initialize() {
            _regionManager.RegisterViewWithRegion(RegionNames.PictureRegion, typeof(PictureView));
            _regionManager.RegisterViewWithRegion(RegionNames.ControlRegion, typeof(ControlView));
        }

        private IRegionManager _regionManager => ServiceLocator.Current.GetInstance<IRegionManager>();
    }
}
