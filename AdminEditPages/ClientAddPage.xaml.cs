using System.Windows;
using System.Windows.Controls;

namespace Sport.AdminEditPages
{
    public partial class ClientAddPage : Page
    {
        Order _sendOrder;
        public ClientAddPage(Order sendOrder = null)
        {
            InitializeComponent();
            _sendOrder = sendOrder;
        }
        void Back_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new OrderEditPage(_sendOrder)); }

        void Add_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text == null || Phone.Text == null || Address.Text == null)
                MessageBox.Show("Заполните пожалуйста все поля", "", MessageBoxButton.OK);
            else
            {
                var client = new Client
                { Name = Name.Text, Phone = Phone.Text, Address = Address.Text };
                dbSportEntities.GetContext().Clients.Add(client);
                dbSportEntities.GetContext().SaveChanges();
                MessageBox.Show("Клиент успешно добавлен!", "", MessageBoxButton.OK);
                if(_sendOrder != null && _sendOrder.Id != 0)
                    Manager.MainFrame.Navigate(new OrderEditPage(_sendOrder));
                else Manager.MainFrame.Navigate(new OrderEditPage());
            }
        }
    }
}