using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Wpf.Ui.Appearance;

namespace ImageUtility.Converters
{
    public class BoolToEnabledConverter : IValueConverter
    {
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
           => value is bool b && b
           ? false
           : true;

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
          => value is bool b && b
          ? true
          : false;
    }
}
