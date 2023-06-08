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
    /// Логика взаимодействия для MainMenuPage.xaml
    /// </summary>
    public partial class MainMenuPage : Page
    {
        public static Stajer stajer1 = new Stajer();
        public static Stajer stjr { get; set; }
        public MainMenuPage(Stajer stajer)
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

        private void secondDay_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SecondDayMashinePages(stajer1));
        }

        private void thirdDay_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ThirdDayTshortsPages(stajer1));
        }

        private void forthDay_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ForthDayPantsPages(stajer1));
        }

        private void fivethDayBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FivesDayBuilsingsPages(stajer1));
        }

        private void sixthDayBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SixthDayTestPages(stajer1));
        }

        private void logOutBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
