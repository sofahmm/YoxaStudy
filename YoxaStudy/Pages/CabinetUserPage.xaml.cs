using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для CabinetUserPage.xaml
    /// </summary>
    public partial class CabinetUserPage : Page
    {
        public static Stajer stajer1 = new Stajer();
        public static Stajer sta { get; set; }
        public static List<StajerDay> stajersDay { get; set; }
        public static List<Stajer> stajers { get; set; }
        public static List<Data.Task> task1 { get; set; }
        public static List<Data.Task> task2 { get; set; }
        public static List<StajerTask> stajerTasks1 { get; set; }
        public static List<StajerTask> stajerTasks2 { get; set; }
        public CabinetUserPage(Stajer stajer)
        {
            InitializeComponent();
            stajer1 = stajer;
            sta = stajer1;
            SurnameTb.Text = stajer1.Surname + " " + stajer1.Name + " " + stajer1.Patronymic;
            //UserAvatImg.Source = stajer1.Image;
            task1 = new List<Data.Task>(DbConnection.diplomEntities.Task.Where(i => i.IdDay == 3).ToList());
            task2 = new List<Data.Task>(DbConnection.diplomEntities.Task.Where(i => i.IdDay == 4).ToList());
            stajerTasks1 = new List<StajerTask>(DbConnection.diplomEntities.StajerTask.
                                Where(i => i.IdStajer == stajer.ID && i.Task.IdDay == 3).ToList());
            stajerTasks2 = new List<StajerTask>(DbConnection.diplomEntities.StajerTask.
                                Where(i => i.IdStajer == stajer.ID && i.Task.IdDay == 4).ToList());
            int countTs1 = stajerTasks1.Count;
            int countTs2 = stajerTasks2.Count;
            int countSt1 = task1.Count;
            int countSt2 = task2.Count;
            if( countTs1 == countSt1 )
            {
                done3dCb.IsChecked = true;

            }
            if( countTs2 == countSt2)
            {
                done4dCb.IsChecked = true;
            }
            stajers = new List<Stajer>(DbConnection.diplomEntities.Stajer.Where(i => i.ID == stajer1.ID));
            stajersDay = new List<StajerDay>(DbConnection.diplomEntities.StajerDay.Where(i => i.IdStajer == stajer1.ID).ToList());
            foreach(StajerDay stajerDay in stajersDay)
            {
                if(stajerDay.IdDay == 1)
                    done1dCb.IsChecked = true;
                else if (stajerDay.IdDay == 2)
                    done2dCb.IsChecked = true;
                else if (stajerDay.IdDay == 3)
                    done3dCb.IsChecked = true;
                else if (stajerDay.IdDay == 4)
                    done4dCb.IsChecked = true;
                else if (stajerDay.IdDay == 5)
                    done5dCb.IsChecked = true;
                else if (stajerDay.IdDay == 7)
                    done6dCb.IsChecked = true;
            }
            //StajerPb.Value = Convert.ToDouble();
            int sount = 0;
            if (done1dCb.IsChecked == true)
                sount += 15;
            if (done2dCb.IsChecked == true)
                sount += 15;
            if (done3dCb.IsChecked == true)
                sount += 20;
            if (done4dCb.IsChecked == true)
                sount += 20;
            if (done5dCb.IsChecked == true)
                sount += 15;
            if (done6dCb.IsChecked == true)
                sount += 15;
            StajerPb.Value = sount;
            this.DataContext = this;
        }

        private void ChangePhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "*.png|*.png|*.jpeg|*.jpeg|*.jpg|*.jpg"
            };
            if (ofd.ShowDialog().GetValueOrDefault())
            {
                stajer1.Image = File.ReadAllBytes(ofd.FileName);
                UserAvatImg.Source = new BitmapImage(new Uri(ofd.FileName));
                DbConnection.diplomEntities.SaveChanges();
            }
        }

        private void done1dCb_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FirstDayFabricPage(stajer1));
        }
    }
}
