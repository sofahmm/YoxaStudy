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
    /// Логика взаимодействия для FivesDayBuilsingsPages.xaml
    /// </summary>
    public partial class FivesDayBuilsingsPages : Page
    {
        public static Stajer stajer1 = new Stajer();
        public static List<StajerDay> stajerDays { get; set; }
        public static StajerDay stajerDay = new StajerDay();
        public static Stajer stjr { get; set; }
        public FivesDayBuilsingsPages(Stajer stajer)
        {
            InitializeComponent();
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
            NavigationService.Navigate(new ForthDayPantsPages(stajer1));
        }

        private void fivethDayBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sixthDayBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SixthDayTestPages(stajer1));
        }

        private void logOutBtn_Click(object sender, RoutedEventArgs e)
        {
            stajer1 = null;
            NavigationService.Navigate(new AuthorizationPage());
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new CabinetUserPage(stajer1));
        }

        private void doneCb_Checked(object sender, RoutedEventArgs e)
        {
            stajerDays = new List<StajerDay>(DbConnection.diplomEntities.StajerDay.ToList());
            StajerDay sD = stajerDays.FirstOrDefault(i => i.IdStajer == stajer1.ID && i.IdDay == 5);
            if (doneCb.IsChecked == true)
            {
                if (sD == null)
                {
                    GoodTb.Visibility = Visibility.Visible;
                    stajerDay.IdStajer = stajer1.ID;
                    stajerDay.IdDay = 5;
                    stajerDay.Counter = 50;
                    DbConnection.diplomEntities.StajerDay.Add(stajerDay);
                    DbConnection.diplomEntities.SaveChanges();
                }
                else if (sD != null)
                {
                    MessageBox.Show("Время двигаться дальше!");
                }
            }
            else if (doneCb.IsChecked == false)
                GoodTb.Visibility = Visibility.Hidden;
        }
    }
}
