using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Sport.AuthReg
{
    public partial class Reg : Page
    {
        public Reg() { InitializeComponent(); }

        void RegIn_Click(object sender, RoutedEventArgs e)
        {
            var users = dbSportEntities.GetContext().Users.Where(x => x.Login == login.Text).ToList();
            if (login.Text == "" || password.Text == "")
                MessageBox.Show("Заполните все поля.", "", MessageBoxButton.OK);
            else
            {
                if (users.Count == 1) MessageBox.Show("Такой пользователь уже существует!", "", MessageBoxButton.OK);
                else
                {
                    User user = new User { Login = login.Text, Password = password.Text };
                    dbSportEntities.GetContext().Users.Add(user);
                    dbSportEntities.GetContext().SaveChanges();
                    MessageBox.Show("Вы успешно зарегистрировались.", "", MessageBoxButton.OK);
                    Manager.MainFrame.Navigate(new Auth());
                }
            }
        }
        void Cancel_Click(object sender, RoutedEventArgs e)
        { Manager.MainFrame.Navigate(new Auth()); }
    }
}