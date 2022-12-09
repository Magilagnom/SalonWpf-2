using SalonWpf.View.Pages;
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

namespace SalonWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new AuthorizationPage());
        }

        
        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Page currentPage = MainFrame.Content as Page;
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            Page currentPage = MainFrame.Content as Page;
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
        }
    }
}