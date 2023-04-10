using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Logique d'interaction pour ListProducts.xaml
    /// </summary>
    public partial class ListProducts : Page
    {
        public ListProducts()
        {
            InitializeComponent();
        }

        Queries BaseQueries = new Queries();

        public void DisplayProductCards()
        {
            List<Product> Products = BaseQueries.getProducts();

            // Set the number of columns and rows in the UniformGrid
            uniformGrid.Columns = 3;
            uniformGrid.Rows = (int)Math.Ceiling((double)Products.Count / uniformGrid.Columns);

            foreach (Product product in Products)
            {
                // Create a StackPanel to hold the product information
                StackPanel productPanel = new StackPanel();


                // Product Card Margin
                productPanel.Margin = new Thickness(2);


                // Product Card Borders
                Border productBorder = new Border();
                productBorder.BorderThickness = new Thickness(1);
                productBorder.BorderBrush = Brushes.Black;
                productPanel.Children.Add(productBorder);

                // Id
                TextBlock idTextBlock = new TextBlock();
                idTextBlock.Text = "Id: " + product.Id;
                productPanel.Children.Add(idTextBlock);

                // Product Name
                TextBlock productNameTextBlock = new TextBlock();
                productNameTextBlock.Text = product.Name;
                productPanel.Children.Add(productNameTextBlock);

                // Price
                TextBlock productPriceTextBlock = new TextBlock();
                productPriceTextBlock.Text = "Price: " + product.Price.ToString("C");
                productPanel.Children.Add(productPriceTextBlock);

                // Quantity
                TextBlock productQuantityTextBlock = new TextBlock();
                productQuantityTextBlock.Text = "Quantity: " + product.Quantity;
                productPanel.Children.Add(productQuantityTextBlock);

                // Supplier
                TextBlock supplierTextBlock = new TextBlock();
                supplierTextBlock.Text = "Supplier: " + product.Suppliers;
                productPanel.Children.Add(supplierTextBlock);

                // Category
                TextBlock categoryTextBlock = new TextBlock();
                categoryTextBlock.Text = "Category: " + product.Category;
                productPanel.Children.Add(categoryTextBlock);


                TextBox stockHandle = new TextBox();
                stockHandle.Name = "stockToTreat";
                productPanel.Children.Add(stockHandle);


                // Create a Button to delete the product
                Button modifyStock = new Button();
                modifyStock.Content = "Modify Stock";
                modifyStock.Click += ModifyStock_Click;
                modifyStock.Tag = product.Id.ToString();
                productPanel.Children.Add(modifyStock);


                // Create a Button to delete the product
                Button deleteButton = new Button();
                deleteButton.Content = "Delete";
                deleteButton.Click += DeleteButton_Click;
                deleteButton.Tag = product.Id.ToString();
                productPanel.Children.Add(deleteButton);

                


                // Add the StackPanel to the UniformGrid
                uniformGrid.Children.Add(productPanel);
            }
        }



        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the product to delete
            Button deleteButton = (Button)sender;
            int id = Int32.Parse(deleteButton.Tag.ToString());

                // Perform the delete operation using the Queries class
                BaseQueries.DeleteProduct(id);

            // Refresh the page
            NavigationService navService = NavigationService.GetNavigationService(this);
            navService.Refresh();

        }


        public void AddProduct_Navigate(object sender, RoutedEventArgs e)
        {
            NavigationService navService = NavigationService.GetNavigationService(this);
            navService.Navigate(new Uri("AddProduct.xaml", UriKind.Relative));
        }




        public void ModifyStock_Click(object sender, RoutedEventArgs e)
        {

            // Get the product to delete
            Button modifyStock = (Button)sender;
            int id = Int32.Parse(modifyStock.Tag.ToString());

            string stockQuantity = (string)FindName("stockToTreat");
            MessageBox.Show(stockQuantity, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            int number;
            if (int.TryParse(stockQuantity, out number))
            {
                if (number > 0)
                {
                    MessageBox.Show("Positive", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (number < 0)
                {
                    MessageBox.Show("Negative", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Boh", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }





        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DisplayProductCards();
        }








    }
}
