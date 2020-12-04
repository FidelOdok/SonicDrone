using DroneMonitor.Infrastructure.Utils;
using DroneMonitor.Vision.Views;
using Microsoft.Practices.ServiceLocation;
using Prism.Modularity;
using Prism.Regions;

namespace DroneMonitor.Vision {
    public class VisionModule : IModule {
        public void Initialize() {
            _regionManager.RegisterViewWithRegion(RegionNames.VisionRegion, typeof(VisionControl));
        }

        private IRegionManager _regionManager => ServiceLocator.Current.GetInstance<IRegionManager>();
    }
}
