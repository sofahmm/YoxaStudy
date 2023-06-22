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
    /// Логика взаимодействия для Quest5Page.xaml
    /// </summary>
    public partial class Quest5Page : Page
    {
        public static Stajer stajer1 = new Stajer();
        public static Stajer stajer2 { get; set; }
        public Quest5Page(Stajer stajer)
        {
            InitializeComponent();
            stajer1 = stajer;
            stajer2 = stajer;
            this.DataContext = this;
        }

        private void UnRightCb2_Checked(object sender, RoutedEventArgs e)
        {
            stajer2.Counter = stajer2.Counter + 1;
            DbConnection.diplomEntities.SaveChanges();
            NavigationService.Navigate(new Quest6Page(stajer1));
        }

        private void RightCb_Checked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Quest6Page(stajer1));
        }

        private void UnRightCb_Checked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Quest6Page(stajer1));
        }
    }
}
