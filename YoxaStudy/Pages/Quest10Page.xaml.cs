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
    /// Логика взаимодействия для Quest10Page.xaml
    /// </summary>
    public partial class Quest10Page : Page
    {
        public static Stajer stajer1 = new Stajer();
        public static Stajer stajer2 { get; set; }
        
        public Quest10Page(Stajer stajer)
        {
            InitializeComponent();
            stajer1 = stajer;
            stajer2 = stajer;
            this.DataContext = this;
        }

        private void RightCb_Checked(object sender, RoutedEventArgs e)
        {
            stajer1.Counter = stajer1.Counter + 1;
            DbConnection.diplomEntities.SaveChanges();
            StajerDay stajerDay = new StajerDay();
            if(stajer1.Counter >= 6)
            {
                MessageBox.Show("Поздравляем! Ты прошел тест. Теперь можно приступить к практике");
                stajerDay.IdStajer = stajer1.ID;
                stajerDay.IdDay = 7;
                stajerDay.Counter = 50;
                DbConnection.diplomEntities.StajerDay.Add(stajerDay);
                DbConnection.diplomEntities.SaveChanges();
            }
                
            else if(stajer1.Counter <= 5)
            {
                MessageBox.Show("Вы не прошли тест.");
                stajerDay.IdStajer = stajer1.ID;
                stajerDay.IdDay = 7;
                stajerDay.Counter = 0;
                DbConnection.diplomEntities.StajerDay.Add(stajerDay);
                DbConnection.diplomEntities.SaveChanges();
            }
                
        }

        private void UnRightCb_Checked(object sender, RoutedEventArgs e)
        {
            StajerDay stajerDay = new StajerDay();
            if (stajer1.Counter >= 6)
            {
                MessageBox.Show("Поздравляем! Ты прошел тест. Теперь можно приступить к практике");
                stajerDay.IdStajer = stajer1.ID;
                stajerDay.IdDay = 7;
                stajerDay.Counter = 50;
                DbConnection.diplomEntities.StajerDay.Add(stajerDay);
                DbConnection.diplomEntities.SaveChanges();
            }

            else if (stajer1.Counter <= 5)
            {
                MessageBox.Show("Вы не прошли тест.");
                stajerDay.IdStajer = stajer1.ID;
                stajerDay.IdDay = 7;
                stajerDay.Counter = 0;
                DbConnection.diplomEntities.StajerDay.Add(stajerDay);
                DbConnection.diplomEntities.SaveChanges();
            }
        }

        private void UnRightCb2_Checked(object sender, RoutedEventArgs e)
        {
            StajerDay stajerDay = new StajerDay();
            if (stajer1.Counter >= 6)
            {
                MessageBox.Show("Поздравляем! Ты прошел тест. Теперь можно приступить к практике");
                stajerDay.IdStajer = stajer1.ID;
                stajerDay.IdDay = 7;
                stajerDay.Counter = 50;
                DbConnection.diplomEntities.StajerDay.Add(stajerDay);
                DbConnection.diplomEntities.SaveChanges();
            }

            else if (stajer1.Counter <= 5)
            {
                MessageBox.Show("Вы не прошли тест.");
                stajerDay.IdStajer = stajer1.ID;
                stajerDay.IdDay = 7;
                stajerDay.Counter = 0;
                DbConnection.diplomEntities.StajerDay.Add(stajerDay);
                DbConnection.diplomEntities.SaveChanges();
            }
        }
    }
}
