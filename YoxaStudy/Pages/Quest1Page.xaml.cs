using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
    /// Логика взаимодействия для Quest1Page.xaml
    /// </summary>
    public partial class Quest1Page : Page
    {
        public static Stajer stajer1 = new Stajer();
        public static Stajer stajer2 { get; set; }
        public static List<StajerDay> stajerDays { get; set; }
        public Quest1Page(Stajer stajer)
        {
            InitializeComponent();
            stajer1 = stajer;
            stajer2 = stajer;
            this.DataContext = this;
        }

        private void RightCb_Checked(object sender, RoutedEventArgs e)
        {
            stajerDays = new List<StajerDay>(DbConnection.diplomEntities.StajerDay.ToList());
            var sD = stajerDays.FirstOrDefault(i => i.IdDay == 7 && i.IdStajer == stajer1.ID);
            if (sD != null)
            {
                MessageBox.Show("Вы уже прошли тест!");
            }
            else
            {
                stajer2.Counter = stajer2.Counter + 1;
                DbConnection.diplomEntities.SaveChanges();
                NavigationService.Navigate(new Quest2Page(stajer1));
            }
        }

        private void UnRightCb_Checked(object sender, RoutedEventArgs e)
        {
            stajerDays = new List<StajerDay>(DbConnection.diplomEntities.StajerDay.ToList());
            var sD = stajerDays.FirstOrDefault(i => i.IdDay == 7 && i.IdStajer == stajer1.ID);
            if (sD != null)
            {
                MessageBox.Show("Вы уже прошли тест!");
            }
            else
            {
                NavigationService.Navigate(new Quest2Page(stajer1));
            }
        }

        private void UnRightCb2_Checked(object sender, RoutedEventArgs e)
        {
            stajerDays = new List<StajerDay>(DbConnection.diplomEntities.StajerDay.ToList());
            var sD = stajerDays.FirstOrDefault(i => i.IdDay == 7 && i.IdStajer == stajer1.ID);
            if (sD != null)
            {
                MessageBox.Show("Вы уже прошли тест!");
            }
            else
            {
                NavigationService.Navigate(new Quest2Page(stajer1));
            }
        }
    }
}
