using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Sport.AdminPages
{
    public partial class EquipmentsPage : Page
    {
        public EquipmentsPage()
        {
            InitializeComponent();
            DGEquipments.ItemsSource = dbSportEntities.GetContext().Equipments.ToList();
        }
        void Edit_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new AdminEditPages.EquipmentEditPage((sender as Button).DataContext as Equipment)); }
        void Back_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new Menu.AdminMenu()); }
        void Add_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new AdminEditPages.EquipmentEditPage()); }
        void Remove_Click(object sender, RoutedEventArgs e)
        {
            var equipmentForRemoving = DGEquipments.SelectedItems.Cast<Equipment>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {equipmentForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    dbSportEntities.GetContext().Equipments.RemoveRange(equipmentForRemoving);
                    dbSportEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    DGEquipments.ItemsSource = dbSportEntities.GetContext().Equipments.OrderBy(x => x.Id).Skip(1).ToList();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message.ToString()); }
            }
        }
    }
}