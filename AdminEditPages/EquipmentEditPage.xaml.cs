using System;
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
    }
}