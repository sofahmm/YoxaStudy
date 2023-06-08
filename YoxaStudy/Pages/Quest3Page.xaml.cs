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
    /// Логика взаимодействия для Quest3Page.xaml
    /// </summary>
    public partial class Quest3Page : Page
    {
        public Quest3Page()
        {
            InitializeComponent();
        }

        private void RightCb_Checked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Quest4Page());
        }
    }
}
