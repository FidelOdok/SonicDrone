using GMap.NET.WindowsPresentation;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DroneMonitor.Visualization.Markers {
    /// <summary>
    /// Interaction logic for GreenMarker.xaml
    /// </summary>
    public partial class GreenMarker : UserControl {
        GMapMarker Marker;

        public GreenMarker(GMapMarker marker, string title) {
            InitializeComponent();
            DataContext = this;
            Marker = marker;
            text.Text = title;

            Loaded += CustomMarkerDemo_Loaded;
            SizeChanged += CustomMarkerDemo_SizeChanged;
            MouseEnter += MarkerControl_MouseEnter;
            MouseLeave += MarkerControl_MouseLeave;
            MouseLeftButtonUp += CustomMarkerDemo_MouseLeftButtonUp;
            MouseLeftButtonDown += CustomMarkerDemo_MouseLeftButtonDown;
        }

        void CustomMarkerDemo_Loaded(object sender, RoutedEventArgs e) {
            if (Icon.Source.CanFreeze) {
                Icon.Source.Freeze();
            }
        }

        void CustomMarkerDemo_SizeChanged(object sender, SizeChangedEventArgs e) {
            Marker.Offset = new Point(-e.NewSize.Width / 2, -e.NewSize.Height);
        }

        void CustomMarkerDemo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if (!IsMouseCaptured) {
                Mouse.Capture(this);
            }
        }

        void CustomMarkerDemo_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            if (IsMouseCaptured) {
                Mouse.Capture(null);
            }
        }

        void MarkerControl_MouseLeave(object sender, MouseEventArgs e) {
            Marker.ZIndex -= 10000;
        }

        void MarkerControl_MouseEnter(object sender, MouseEventArgs e) {
            Marker.ZIndex += 10000;
        }
    }
}
