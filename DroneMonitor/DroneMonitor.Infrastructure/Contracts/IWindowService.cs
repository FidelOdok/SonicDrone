using System.Windows;
using System.Windows.Controls;

namespace DroneMonitor.Infrastructure.Contracts {
    public interface IWindowService {
        T Launch<T>() where T : ContentControl;
        T Launch<T>(bool createNew) where T : ContentControl;

        T LaunchDialog<T>() where T : Window;

        string LaunchFileDialog();

        void CloseDialog();

        bool? DisplayAlert(string title, string messsage, bool yesNo = false);

        ContentControl GetActiveWindow();
    }
}
