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
    /// Логика взаимодействия для FivesDayBuilsingsPages.xaml
    /// </summary>
    public partial class FivesDayBuilsingsPages : Page
    {
        public FivesDayBuilsingsPages()
        {
            InitializeComponent();
        }

        private void firstDayBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FirstDayFabricPage());
        }

        private void secondDayBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SecondDayMashinePages());
        }

        private void thirdDayBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ThirdDayTshortsPages());
        }

        private void forthDayBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ForthDayPantsPages());
        }

        private void fivethDayBtn_Click(object sender, RoutedEventArgs e)
        {

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
