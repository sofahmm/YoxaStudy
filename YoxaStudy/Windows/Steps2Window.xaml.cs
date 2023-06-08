using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using YoxaStudy.Data;

namespace YoxaStudy.Windows
{
    /// <summary>
    /// Логика взаимодействия для Steps2Window.xaml
    /// </summary>
    public partial class Steps2Window : Window
    {
        public static Steps stps { get; set; }
        public static List<Steps> steps { get; set; }
        public static List<StepTask> stepTasks { get; set; }
        public static Data.Task step1 { get; set; }
        public static StajerTask stajerTask = new StajerTask();
        public static Stajer stajer1 = new Stajer();
        int test = 0;
        public Steps2Window(Data.Task step, Stajer stajer)
        {
            InitializeComponent();
            stepTasks = new List<StepTask>(DbConnection.diplomEntities.StepTask.Where(i => i.IdTask == step.ID).ToList());
            MiniDescTb.Text = step.MiniDescription;
            step1 = step;
            stajer1 = stajer;
            this.DataContext = this;
        }

        private void doneCb_Checked(object sender, RoutedEventArgs e)
        {
            //if (doneCb.IsChecked == true)
            //{
            //    stajerTask.IdStajer = 1;
            //    stajerTask.IdTask = test;
            //    stajerTask.IsDone = true;
            //    DbConnection.diplomEntities.StajerTask.Add(stajerTask);
            //    DbConnection.diplomEntities.SaveChanges();
            //    MessageBox.Show("HAPPY!");
            //    this.Close();
            //}
            //else
            //    MessageBox.Show(":(");

        }

        private void doneCb_Checked_1(object sender, RoutedEventArgs e)
        {
            if(doneCb.IsChecked == true)
            {
                stajerTask.IdStajer = stajer1.ID;
                stajerTask.IdTask = step1.ID;
                stajerTask.Counr = 5;
                DbConnection.diplomEntities.StajerTask.Add(stajerTask);
                DbConnection.diplomEntities.SaveChanges();
                this.Close();
            }
        }
    }
}
