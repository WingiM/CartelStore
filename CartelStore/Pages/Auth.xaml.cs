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
    }
}