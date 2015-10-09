using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Delopgave1
{
    class BlueColorConverterID007 : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var id = value as string ?? "";

            return (id == "007" ? Brushes.Blue : Brushes.Black); 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
