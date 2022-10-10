using System.Data.Common;
using System.Linq;
using System.Windows;
using CartelStore.Database;
using CartelStore.Pages;

namespace CartelStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Auth());
        }
    }
}