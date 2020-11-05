using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ZvukDb.Repo;

namespace ZvukDb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            if (!Repository.UserExist("admin"))
            {
                Repository.AddUser("admin", "admin");
            }
            InitializeComponent();
        }

        


        private void Enter_click(object sender, RoutedEventArgs e)
        {
            if (Repository.FindUser(LoginTextBox.Text, PasswordTextBox.Password))
            {
                MessageBox.Show("Вход выполнен");
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void Registy_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данная возможность временно недоступна");
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
