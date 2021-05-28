using System.Windows;
using System.Windows.Controls;

namespace Sport.Menu
{
    public partial class UserMenu : Page
    {
        public UserMenu() { InitializeComponent(); }
        void Profile_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new UserPages.ProfilePage()); }
        void Products_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new UserPages.ProductsPage()); }
        void Orders_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new UserPages.OrdersPage()); }
    }
}