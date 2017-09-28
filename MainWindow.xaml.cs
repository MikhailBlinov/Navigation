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

namespace Navigation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["PageOne"] = new PageOne();
            Application.Current.Properties["PageTwo"] = new PageTwo();
            Application.Current.Properties["PageThree"] = new PageThree();

            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;

            MainFrame.Content = (PageOne)Application.Current.Properties["PageOne"];
        }

        private void Button1Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = (PageTwo)Application.Current.Properties["PageTwo"];

        }

        private void Button2Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = (PageThree)Application.Current.Properties["PageThree"];
        }

        private void Button3Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = (PageOne)Application.Current.Properties["PageOne"];
        }
    }
}
