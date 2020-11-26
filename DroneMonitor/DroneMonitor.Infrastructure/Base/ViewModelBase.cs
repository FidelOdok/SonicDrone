using DroneMonitor.Infrastructure.Contracts;
using Microsoft.Practices.ServiceLocation;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;

namespace DroneMonitor.Infrastructure.Base {
    public class ViewModelBase : BindableBase {
        public IRegionManager RegionManager { get { return ServiceLocator.Current.GetInstance<IRegionManager>(); } }

        public IEventAggregator EventAggregator { get { return ServiceLocator.Current.GetInstance<IEventAggregator>(); } }

        public IWindowService WindowService { get { return ServiceLocator.Current.GetInstance<IWindowService>(); } }
    }
}
