using Prism.Unity;
using Microsoft.Practices.Unity;
using System.Windows;
using Prism.Modularity;
using System;
using DroneMonitor.Infrastructure.Contracts;
using DroneMonitor.Infrastructure.Services;

namespace DroneMonitor {
    public class Bootstrapper : UnityBootstrapper {
        protected override DependencyObject CreateShell() {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell() {
            base.InitializeShell();
            Application.Current.MainWindow.Show();
        }

        protected override IModuleCatalog CreateModuleCatalog() {
            base.CreateModuleCatalog();
            return new DirectoryModuleCatalog() {
                ModulePath = AppDomain.CurrentDomain.BaseDirectory + "Modules"
            };
        }

        protected override void ConfigureContainer() {
            base.ConfigureContainer();
            Container.RegisterType<IWindowService, WindowService>();
        }

    }
}
