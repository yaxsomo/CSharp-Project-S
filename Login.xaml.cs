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
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }



        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            Queries BaseQueries = new Queries();


            // Validate the username and password
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Perform the login

            bool loginSuccessful = BaseQueries.PerformLogin(username, password);
            if (loginSuccessful)
            {
                // Login was successful, close the login window

                

                NavigationService navService = NavigationService.GetNavigationService(this);
                navService.Navigate(new Uri("ListProducts.xaml", UriKind.Relative));


            }
            else
            {
                // Login failed, display an error message
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }




    }
}
