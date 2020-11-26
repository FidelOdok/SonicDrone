using System.Windows;

namespace DroneMonitor {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            new Bootstrapper().Run();
        }
    }
}
