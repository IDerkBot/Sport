using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Sport.UserPages
{
    public partial class ProfilePage : Page
    {
        Client _currentClient = new Client();
        public ProfilePage() {
            InitializeComponent();
            var client = dbSportEntities.GetContext().Clients.Where(x => x.Id == DataBank.UserID).Single();
            if (dbSportEntities.GetContext().Clients.Where(x => x.Id == DataBank.UserID).Count() == 1) _currentClient = client;
            DataContext = _currentClient;
        }
        void InMenu_Click(object sender, RoutedEventArgs e) { Manager.MainFrame.Navigate(new Menu.UserMenu()); }
        void Save_Click(object sender, RoutedEventArgs e)
        {
            _currentClient.Name = Name.Text;
            _currentClient.Address = Address.Text;
            _currentClient.Phone = Phone.Text;
            _currentClient.IdUser = DataBank.UserID;
            dbSportEntities.GetContext().SaveChanges();
            MessageBox.Show("Данные успешно сохранены!", "", MessageBoxButton.OK);
            Manager.MainFrame.Navigate(new Menu.UserMenu());
        }
    }
}