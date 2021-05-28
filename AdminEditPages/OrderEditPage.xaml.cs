using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Sport.AdminEditPages
{
    public partial class OrderEditPage : Page
    {
        Order _currentOrder = new Order();
        public OrderEditPage(Order selectedOrder = null)
        {
            InitializeComponent();
            if (selectedOrder != null) _currentOrder = selectedOrder;
            DataContext = _currentOrder;
            ProductCB.ItemsSource = dbSportEntities.GetContext().Equipments.ToList().Select(x => x.Name);
            ProductCB.SelectedItem = dbSportEntities.GetContext().Equipments.Where(x => x.Id == _currentOrder.IdEquipment).Select(x => x.Name).Single();
            //ChangeSum();
        }
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
                Manager.MainFrame.Navigate(new AdminPages.OrdersPage());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }
        void Back_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new AdminPages.OrdersPage()); }
        void ChangeSum()
        {
            int countText = 0;
            if (int.TryParse(Count.Text, out countText))
            {
                var price = dbSportEntities.GetContext().Equipments.Where(x => x.Name == ProductCB.SelectedItem.ToString()).Select(x => x.Price).Single();
                var count = countText;
                Sum.Text = $"{price * count}";
            }
            else { MessageBox.Show($"Введите только цифры!"); }
        }
        void Product_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { ChangeSum(); }
        void Count_TextChanged(object sender, TextChangedEventArgs e)
        { ChangeSum(); }
    }
}