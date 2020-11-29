using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace DroneMonitor.Visualization.Converters {
    public class BoolToBrushConverter : IValueConverter {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture) {
            var input = (bool)value;
            if (input) {
                return Brushes.Red;
            }
            return Brushes.Green;
        }

        public object ConvertBack(object value, Type targetType, 
                object parameter, CultureInfo culture) {
            return "";
        }
    }
}
