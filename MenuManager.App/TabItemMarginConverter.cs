using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;


namespace MenuManager.App
{
    [ValueConversion(typeof(int), typeof(Thickness))]
    public class TabItemMarginConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var top = value as int? ?? 0;
            return new Thickness(0, top, 0, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }


        private static TParent FindParent<TParent>(object value, int level = 1)
            where TParent : class
        {
            var dependencyObject = value as DependencyObject;
            if (dependencyObject != null)
            {
                DependencyObject parent = dependencyObject;
                var currentLevel = 0;
                do
                {
                    parent = VisualTreeHelper.GetParent(parent);
                    if (parent != null && parent.GetType() == typeof(TParent))
                    {
                        currentLevel++;
                        if (currentLevel == level)
                        {
                            return parent as TParent;
                        }
                    }
                } while (parent != null);
            }
            return null;
        }

        private static void WalkVisualTree(object value)
        {
            var parents = new List<string>();
            var dependencyObject = value as DependencyObject;
            if (dependencyObject != null)
            {
                DependencyObject parent = dependencyObject;
                parents.Add(parent.GetType().Name);
                do
                {
                    parent = VisualTreeHelper.GetParent(parent);
                    if (parent != null)
                    {
                        parents.Add(parent.GetType().Name);
                    }
                } while (parent != null);
                parents.Reverse();

                var indentation = "";
                foreach (var p in parents)
                {
                    Debug.WriteLine(indentation + p);
                    indentation += "  ";
                }
            }
        }
    }
}