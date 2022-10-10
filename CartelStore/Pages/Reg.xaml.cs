using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using CartelStore.ADOApp;
using CartelStore.Database;

namespace CartelStore.Pages
{
    public partial class Reg : Page
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void Reverse_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Registrate_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var stings = new[] {Name.Text, Login.Text, PasswordBox.Password};
                if (stings.All(x => !string.IsNullOrEmpty(x)))
                {
                    var newUser = new User()
                    {
                        Name = Name.Text
                    };

                    LoginInfo newLogin = new LoginInfo
                    {
                        Login = Login.Text,
                        Password = PasswordBox.Password
                    };
                
                    newUser.LoginInfo.Add(newLogin);

                    CartelStoreConnection.Connection.User.Add(newUser);
                    CartelStoreConnection.Connection.SaveChanges();
                    MessageBox.Show("Успешно!");
                    NavigationService.GoBack();
                }
                else
                {
                    MessageBox.Show("Такой логин уже существует!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}