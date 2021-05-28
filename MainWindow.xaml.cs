using System.Windows;

namespace Sport
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new AuthReg.Auth());
            Manager.MainFrame = MainFrame;
        }
    }
}