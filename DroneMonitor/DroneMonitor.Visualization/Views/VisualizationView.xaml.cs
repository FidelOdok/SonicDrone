using DroneMonitor.Visualization.Markers;
using DroneMonitor.Visualization.Models;
using DroneMonitor.Visualization.ViewModels;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsPresentation;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
            map.MouseLeftButtonDown += Map_MouseLeftButtonDown;
            _viewModel.Map = map;
        }

        private void Map_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            _viewModel.MapClicked((GMapControl)sender, e);
        }

        private void PositionChanged(PointLatLng point) {
            _currentMarker.Position = point;
        }
    }
}
