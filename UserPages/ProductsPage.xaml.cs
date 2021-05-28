using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Sport.UserPages
{
    public partial class ProductsPage : Page
    {
        public ProductsPage()
        { InitializeComponent(); DGProducts.ItemsSource = dbSportEntities.GetContext().Equipments.ToList(); }
        void Back_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new Menu.UserMenu()); }
        void AddCart_Click(object sender, RoutedEventArgs e)
        {
            var btn = (sender as Button).DataContext as Equipment;
            var clientId = from client in dbSportEntities.GetContext().Clients where client.IdUser == DataBank.UserID select client.Id;
            Order order = new Order
            { IdEquipment = btn.Id, IdClient = clientId.Single(), Count = (btn.Storage >= 1) ? 1 : 0, Sum = btn.Price };
            Manager.MainFrame.Navigate(new UserEditPages.OrderEditPage(order));
        }
    }
}