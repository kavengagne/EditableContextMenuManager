using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;


namespace MenuManager.App
{
    [ValueConversion(typeof(JsonMenuItem), typeof(Visibility))]
    public class ParentToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var parent = value as JsonMenuItem;
            if (parent?.Name != null)
            {
                return Visibility.Visible;
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}