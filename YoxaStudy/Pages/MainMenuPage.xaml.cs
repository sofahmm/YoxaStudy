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

namespace YoxaStudy.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenuPage.xaml
    /// </summary>
    public partial class MainMenuPage : Page
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }

        private void firstDayBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FirstDayFabricPage());
        }

        private void secondDay_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SecondDayMashinePages());
        }

        private void thirdDay_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ThirdDayTshortsPages());
        }

        private void forthDay_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ForthDayPantsPages());
        }

        private void fivethDayBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FivesDayBuilsingsPages());
        }

        private void sixthDayBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SixthDayTestPages());
        }

        private void logOutBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
