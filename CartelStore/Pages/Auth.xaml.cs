using CartelStore.Database;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CartelStore.Pages
{
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Registrate_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Reg());
        }

        private void Sign_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var strings = new[] { Login.Text, PasswordBox.Password };
                if (strings.All(x => !string.IsNullOrEmpty(x)))
                {
                    var userLogInfo = CartelStoreConnection.Connection.LoginInfo.FirstOrDefault(z => z.Login == Login.Text && z.Password == PasswordBox.Password);
                    
                    if(userLogInfo != null)
                    {
                        MessageBox.Show("Успешно!");
                        MessageBox.Show(userLogInfo.User.Name);
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка авторизации!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}