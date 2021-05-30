using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Sport.AdminPages
{
    public partial class OrdersPage : Page
    {
        public OrdersPage()
        {
            InitializeComponent();
            GetTableData();
        }
        void AddClient_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new AdminEditPages.OrderEditPage()); }
        void RemoveClient_Click(object sender, RoutedEventArgs e)
        {
            var orderForRemoving = DGOrders.SelectedItems.Cast<Order>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {orderForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    dbSportEntities.GetContext().Orders.RemoveRange(orderForRemoving);
                    dbSportEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    DGOrders.ItemsSource = dbSportEntities.GetContext().Orders.OrderBy(x => x.Id).Skip(1).ToList();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            }
        }
        void Back_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new Menu.AdminMenu()); }
        void Edit_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new AdminEditPages.OrderEditPage((sender as Button).DataContext as Order)); }
        void GetTableData()
        {
            DGOrders.Items.Clear();
            DGOrders.ItemsSource = dbSportEntities.GetContext().Orders.ToList();
        }
    }
}