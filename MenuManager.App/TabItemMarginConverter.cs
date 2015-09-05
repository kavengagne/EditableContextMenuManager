using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;


namespace MenuManager.App
{
    [ValueConversion(typeof(TabItem), typeof(Thickness))]
    public class TabItemMarginConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var tabItem = value as TabItem;
            var tabControl = tabItem?.Parent as TabControl;
            if (tabControl != null)
            {
                var transform = tabItem.TransformToAncestor(tabControl).Transform(new Point(0, 0));
                var top = Math.Max(transform.Y - 2, 0);
                return new Thickness(0, top, 0, 0);
            }
            return new Thickness(0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}