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
using YoxaStudy.Windows;

namespace YoxaStudy.Pages
{
    /// <summary>
    /// Логика взаимодействия для ForthDayPantsPages.xaml
    /// </summary>
    public partial class ForthDayPantsPages : Page
    {
        public static List<Data.Task> products { get; set; }
        public static Stajer stjr { get; set; }
        public static Stajer stajer1 = new Stajer();
        public ForthDayPantsPages(Stajer stajer)
        {
            InitializeComponent();
            products = new List<Data.Task>(DbConnection.diplomEntities.Task.Where(i => i.IdDay == 4).ToList());
            stajer1 = stajer;
            stjr = stajer1;
            NameTb.Text = stajer1.Surname + " " + stajer1.Name + " " + stajer1.Patronymic;
            this.DataContext = this;
        }

        private void firstDayBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FirstDayFabricPage(stajer1));
        }

        private void secondDayBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SecondDayMashinePages(stajer1));
        }

        private void thirdDayBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ThirdDayTshortsPages(stajer1));
        }

        private void forthDayBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void fivethDayBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FivesDayBuilsingsPages(stajer1));
        }

        private void sixthDayBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("К итоговому тесту можно приступить только после завершения 5 дня");
        }

        private void logOutBtn_Click(object sender, RoutedEventArgs e)
        {
            stajer1 = null;
            NavigationService.Navigate(new AuthorizationPage());
        }

        private void productslv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var t = ((sender as ListView).SelectedItem as Data.Task);
            Steps2Window stepsWindow = new Steps2Window(t, stajer1);
            stepsWindow.Show();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new CabinetUserPage(stajer1));
        }
    }
}
