using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Sport.UserPages
{
    public partial class OrdersPage : Page
    {
        public OrdersPage()
        {
            InitializeComponent();
            var query = from order in dbSportEntities.GetContext().Orders
                        join client in dbSportEntities.GetContext().Clients on order.IdClient equals client.Id
                        where DataBank.UserID == client.IdUser
                        select order;
            if (query.ToList().Count == 0) Alert.Text = "Заказов не найдено";
            else DGOrders.ItemsSource = query.ToList();
        }
        void Back_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new Menu.UserMenu()); }
    }
}