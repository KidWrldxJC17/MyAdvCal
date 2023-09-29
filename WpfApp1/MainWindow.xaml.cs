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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            // Closes the application
            Application.Current.Shutdown();
        }


        private void Mini_Click(object sender, RoutedEventArgs e)
        {
            // Minimizes the window
            this.WindowState = WindowState.Minimized;
        }

        private void Max_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Maximized)
            {
                //The window is already big, make it normal
                this.WindowState = WindowState.Normal;
            }
            else
            {
                //The window is not big so it Maximizes the window
                this.WindowState = WindowState.Maximized;
            }
        }
    }
}
