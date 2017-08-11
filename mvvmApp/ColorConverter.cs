using System;
using System.Globalization;
using Xamarin.Forms;

namespace mvvmApp
{
    public class ColorConverter : IValueConverter
    {
        public ColorConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((bool)value) ? Color.Green : Color.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
