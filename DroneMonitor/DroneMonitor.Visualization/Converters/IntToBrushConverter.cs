using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace DroneMonitor.Visualization.Converters {
    public class IntToBrushConverter : IValueConverter {
        public object Convert(object value, Type targetType, 
            object parameter, CultureInfo culture) {
            var input = (int) value;
            if (input > 108)
                return Brushes.Lime;
            else if (input > 100)
                return Brushes.Yellow;
            else
                return Brushes.Red;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture) {
            return 1;
        }
    }
}
