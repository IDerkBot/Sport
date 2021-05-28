using System.Windows;
using System.Windows.Controls;

namespace Sport.Menu
{
    public partial class AdminMenu : Page
    {
        public AdminMenu() { InitializeComponent(); }

        void Clients_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new AdminPages.ClientsPage()); }

        void Products_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new AdminPages.EquipmentsPage()); }

        void Orders_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new AdminPages.OrdersPage()); }
    }
}