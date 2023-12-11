using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Converters
{
    public class FactorConverter : IValueConverter
    {
        //OneWay
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double wert = System.Convert.ToDouble(value);
            double factor = System.Convert.ToDouble(parameter);
            return wert * factor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
