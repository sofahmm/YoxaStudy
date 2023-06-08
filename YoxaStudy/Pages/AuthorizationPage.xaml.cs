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
using YoxaStudy.Data;

namespace YoxaStudy.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public static List<Stajer> stajers { get; set; }
        public AuthorizationPage()
        {
            InitializeComponent();

        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {

            string login = loginTb.Text.Trim();
            string password = passwordTb.Password.Trim();
            stajers = new List<Stajer>(DbConnection.diplomEntities.Stajer.ToList());
            Stajer currentUser = stajers.FirstOrDefault(i => i.Login == login && i.Password == password);
            if (currentUser != null)
                NavigationService.Navigate(new CabinetUserPage(currentUser));
            else
                MessageBox.Show("Неверный логин или пароль, попробуйте снова!");
        }
    }
}
