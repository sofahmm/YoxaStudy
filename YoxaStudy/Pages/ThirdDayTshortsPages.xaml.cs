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
    /// Логика взаимодействия для ThirdDayTshortsPages.xaml
    /// </summary>
    public partial class ThirdDayTshortsPages : Page
    {
        public static List<Clothes> productsTShorts { get; set; }
        public static List<Clothes> productsSvitshot { get; set; }
        public static List<Clothes> productsLongsliv { get; set; }
        public ThirdDayTshortsPages()
        {
            InitializeComponent();
            productsTShorts = new List<Clothes>(DbConnection.diplomEntities.Clothes.Where(i => i.ID == 1).ToList());
            productsSvitshot = new List<Clothes>(DbConnection.diplomEntities.Clothes.Where(i => i.ID == 2).ToList());
            productsLongsliv = new List<Clothes>(DbConnection.diplomEntities.Clothes.Where(i => i.ID == 3).ToList());
            this.DataContext = this;
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

        }

        private void forthDayBtn_Click(object sender, RoutedEventArgs e)
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
