using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Sport.AdminEditPages
{
    public partial class EquipmentEditPage : Page
    {
        Equipment _currentEquipment = new Equipment();
        public EquipmentEditPage(Equipment selectedEquipment = null)
        {
            InitializeComponent();
            if (selectedEquipment != null) _currentEquipment = selectedEquipment;
            DataContext = _currentEquipment;
        }
        void Back_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new AdminPages.EquipmentsPage()); }
        void Add_Click(object sender, RoutedEventArgs e)
        {
            if(Name.Text != null && Price.Text != null && Storage.Text != null && Name.Text != "" && Price.Text != "" && Storage.Text != "")
            {
                StringBuilder errors = new StringBuilder();
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                    return;
                }
                if (_currentEquipment.Id == 0) dbSportEntities.GetContext().Equipments.Add(_currentEquipment);
                try
                {
                    dbSportEntities.GetContext().SaveChanges();
                    MessageBox.Show("Информация сохранена!");
                    Manager.MainFrame.Navigate(new AdminPages.EquipmentsPage());
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message.ToString()); }
            }
            else MessageBox.Show("Введите данные во все поля");
        }
        void Storage_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Name.Text != null && dbSportEntities.GetContext().Equipments.Where(x => x.Name == Name.Text).ToList().Count != 0)
            {
                if (int.TryParse(Storage.Text, out int count))
                {

                    var _storage = dbSportEntities.GetContext().Equipments.Where(x => x.Name == Name.Text).Select(x => x.Storage).Single();
                    _storage = count;
                    Storage.Text = _storage.ToString();
                }
                else { MessageBox.Show($"Введите только цифры!"); Storage.Text = "0"; }
            }
        }
    }
}