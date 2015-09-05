using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MenuManager.App
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            //var button = (Button)sender;
            //var buttonPosition = button.TransformToAncestor(canvas).Transform(new Point(0, 0));

            //var newPosition = new Point(buttonPosition.X + button.ActualWidth, buttonPosition.Y + button.ActualHeight);

            //var menuItem = new Button
            //{
            //    Content = "New Menu Item"
            //};
            //Canvas.SetTop(menuItem, newPosition.X);
            //Canvas.SetLeft(menuItem, newPosition.Y);

            ////menuItem.Style = Application.Current.FindResource();

            //canvas.Children.Add(menuItem);
        }
    }
}
