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

namespace EcomDesktop
{
    /// <summary>
    /// Logique d'interaction pour AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Page
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        Queries BaseQueries = new Queries();





        public void AddProduct_Click(object sender, RoutedEventArgs e)
        {

            string name = productNameTextBox.Text;
            float price = float.Parse(productPriceTextBox.Text);
            int quantity = int.Parse(productQuantityTextBox.Text);
            string supplier = productSupplierTextBox.Text;
            string category = productCategoryTextBox.Text;

            BaseQueries.CreateProduct(name,price,quantity,supplier,category);

            NavigationService navService = NavigationService.GetNavigationService(this);
            navService.Navigate(new Uri("ListProducts.xaml", UriKind.Relative));

        }


        public void ListProducts_Navigate(object sender, RoutedEventArgs e)
        {
            NavigationService navService = NavigationService.GetNavigationService(this);
            navService.Navigate(new Uri("ListProducts.xaml", UriKind.Relative));
        }



    }
}
