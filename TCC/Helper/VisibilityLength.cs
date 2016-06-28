using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using TCC.Model;

namespace TCC.Helper
{
    class VisibilityLength : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Value val = value as Value;

            if (val != null)
            {
                if (val.TypeVisibility != "Static" && (val.ID >= 1 && val.ID < 3000) && ( val.Type != "Int" && val.Type != "Byte" && val.Type != "Real" ))
                {
                    return Visibility.Visible;
                }
                else
                {
                    return Visibility.Collapsed;
                }
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException("IsNotConverter can only be used OneWay.");
        }
    }
}
