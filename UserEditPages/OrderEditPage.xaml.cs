using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Sport.UserEditPages
{
    public partial class OrderEditPage : Page
    {
        Order _currentOrder = new Order();
        public OrderEditPage(Order selectedOrder)
        {
            InitializeComponent();
            if (selectedOrder != null) _currentOrder = selectedOrder;
            DataContext = _currentOrder;
            ClientTB.Text = dbSportEntities.GetContext().Clients.Where(x => x.IdUser == DataBank.UserID).Select(x => x.Name).Single();
            ProductCB.ItemsSource = dbSportEntities.GetContext().Equipments.ToList().Select(x => x.Name);
            ProductCB.SelectedItem = dbSportEntities.GetContext().Equipments.Where(x => x.Id == _currentOrder.IdEquipment).Select(x => x.Name).Single();
            ChangeSum();
        }
        void ProductCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { ChangeSum(); }
        void Count_TextChanged(object sender, TextChangedEventArgs e)
        { ChangeSum(); }
        void Back_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new UserPages.OrdersPage()); }
        void Save_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            _currentOrder.Sum = decimal.Parse(Sum.Text);
            if (errors.Length > 0) { MessageBox.Show(errors.ToString()); return; }
            if (_currentOrder.Id == 0) dbSportEntities.GetContext().Orders.Add(_currentOrder);
            try
            {
                dbSportEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Manager.MainFrame.Navigate(new UserPages.OrdersPage());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }
        void ChangeSum()
        {
            if (int.TryParse(Count.Text, out int countText))
            {
                var price = dbSportEntities.GetContext().Equipments.Where(x => x.Name == ProductCB.SelectedItem.ToString()).Select(x => x.Price).ToList().Single();
                var count = countText;
                var _storage = dbSportEntities.GetContext().Equipments.Where(x => x.Name == ProductCB.SelectedItem.ToString()).Select(x => x.Storage).Single();
                if (count > _storage)
                {
                    MessageBox.Show($"Количество которое вы указали превышает количество на складе\nНа складе: {_storage}");
                    Count.Text = _storage.ToString();
                    return;
                }
                Sum.Text = $"{price * count}";
            }
            else { MessageBox.Show($"Введите только цифры!"); Count.Text = "1"; }
        }
    }
}