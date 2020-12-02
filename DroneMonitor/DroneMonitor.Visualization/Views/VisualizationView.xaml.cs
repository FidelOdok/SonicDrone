using DroneMonitor.Visualization.Markers;
using DroneMonitor.Visualization.Models;
using DroneMonitor.Visualization.ViewModels;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsPresentation;
using System.Windows;
using System.Windows.Controls;

namespace DroneMonitor.Visualization.Views {
    /// <summary>
    /// Interaction logic for VisualizationView.xaml
    /// </summary>
    public partial class VisualizationView : UserControl {
        private GMapMarker _currentMarker;
        private VisualizationViewModel _viewModel;
        public VisualizationView() {
            InitializeComponent();
            DataContext = _viewModel = new VisualizationViewModel();

            if (!Stuff.PingNetwork("google.com")) {
                MessageBox.Show("No internet connection available.", 
                    "Drone Monitor",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            GoogleMapProvider.Instance.ApiKey = Stuff.GoogleMapsApiKey;
            map.OnPositionChanged += PositionChanged;

            // set current marker
            _currentMarker = new GMapMarker(_viewModel.Position) {
                Offset = new Point(-15, -15),
                ZIndex = int.MaxValue,
            };
            _currentMarker.Shape = new RedMarker(_currentMarker, "current position");
            map.Markers.Add(_currentMarker);
        }

        private void PositionChanged(PointLatLng point) {
            _currentMarker.Position = point;
        }
    }
}
