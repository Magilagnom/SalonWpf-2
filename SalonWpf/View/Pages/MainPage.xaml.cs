using SalonWpf.Controlers;
using SalonWpf.Model;
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

namespace SalonWpf.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        int idCategory;
        public MainPage()
        {
            InitializeComponent();
            ServiceListView.ItemsSource = ServiceCategoryesControlers.GetServiceCategoryes();
        }

        private void GridMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Grid activeCategory = sender as Grid;
            ServiceCategoryes activeData = activeCategory.DataContext as ServiceCategoryes;
            idCategory = activeData.CategoryId;
            this.NavigationService.Navigate(new PricePage(idCategory));
        }
    }
}
