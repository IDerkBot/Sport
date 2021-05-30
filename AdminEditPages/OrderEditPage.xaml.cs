using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Sport.AdminEditPages
{
    public partial class OrderEditPage : Page
    {
        Order _selectOrder = new Order();
        Order _currentOrder = new Order();
        int _countOld = 0;
        int _countNew = 0;
        public OrderEditPage(Order selectedOrder = null)
        {
            InitializeComponent();
            if (selectedOrder != null)
            {
                _currentOrder = selectedOrder;
                _selectOrder = selectedOrder;
            }
            DataContext = _currentOrder;
            Count.Text = _currentOrder.Count.ToString();
            ProductCB.ItemsSource = dbSportEntities.GetContext().Equipments.Select(x => x.Name).ToList();
            if (selectedOrder != null)
            {
                ProductCB.SelectedItem = dbSportEntities.GetContext().Equipments.Where(x => x.Id == _currentOrder.IdEquipment).Select(x => x.Name).Single();
                _countOld = int.Parse(_currentOrder.Count.ToString());
            }
            ChangeSum();
        }
        void Save_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            _currentOrder.Sum = decimal.Parse(Sum.Text);
            if (errors.Length > 0) { MessageBox.Show(errors.ToString()); return; }
            if (_currentOrder.Id == 0) dbSportEntities.GetContext().Orders.Add(_currentOrder);
            try
            {
                if (_countOld >= 0)
                {
                    var _selectEqupmint = dbSportEntities.GetContext().Equipments.Where(x => x.Name == ProductCB.SelectedItem.ToString()).Single();
                    if (_countOld != _countNew)
                    {
                        if (_countOld > _countNew) _selectEqupmint.Storage += _countOld - _countNew;
                        else if (_countOld < _countNew) _selectEqupmint.Storage -= _countNew;
                    }
                }
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
            if(ProductCB.SelectedItem != null && Count.Text != null)
            {
                if (int.TryParse(Count.Text, out int countText))
                {
                    var price = dbSportEntities.GetContext().Equipments.Where(x => x.Name == ProductCB.SelectedItem.ToString()).Select(x => x.Price).ToList().Single();
                    var count = countText;
                    int? _storage = dbSportEntities.GetContext().Equipments.Where(x => x.Name == ProductCB.SelectedItem.ToString()).Select(x => x.Storage).Single();
                    if (count > _storage)
                    {
                        MessageBox.Show($"Количество которое вы указали превышает количество на складе\nНа складе: {_storage}");
                        Count.Text = _storage.ToString();
                        return;
                    }
                    _countNew = count;
                    Sum.Text = $"{price * count}";
                }
                else { MessageBox.Show($"Введите только цифры!"); Count.Text = "0"; ChangeSum(); }
            }
        }
        void Product_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { ChangeSum(); }
        void Count_TextChanged(object sender, TextChangedEventArgs e)
        { ChangeSum(); }
    }
}