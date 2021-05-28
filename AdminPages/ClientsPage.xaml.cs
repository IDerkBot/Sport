using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Sport.AdminPages
{
    public partial class ClientsPage : Page
    {
        public ClientsPage() {
            InitializeComponent();
            DGClients.ItemsSource = dbSportEntities.GetContext().Clients.ToList();
        }
        void Edit_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new AdminEditPages.ClientEditPage((sender as Button).DataContext as Client)); }
        void Back_Click(object sender, RoutedEventArgs e) { Manager.MainFrame.Navigate(new Menu.AdminMenu()); }
        void AddClient_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new AdminEditPages.ClientEditPage()); }
        void DeleteClient_Click(object sender, RoutedEventArgs e)
        {
            var clientsForRemoving = DGClients.SelectedItems.Cast<Client>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {clientsForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    dbSportEntities.GetContext().Clients.RemoveRange(clientsForRemoving);
                    dbSportEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    DGClients.ItemsSource = dbSportEntities.GetContext().Clients.OrderBy(x => x.Id).Skip(1).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}