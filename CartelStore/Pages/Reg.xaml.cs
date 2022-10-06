using System.Windows;
using System.Windows.Controls;

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
    }
}