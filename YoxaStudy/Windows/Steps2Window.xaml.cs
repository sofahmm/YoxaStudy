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
        public Steps2Window(Data.Task step)
        {
            InitializeComponent();
            steps = new List<Steps>(DbConnection.diplomEntities.Steps.Where(i => i.IdTask == step.ID).ToList());
            //Image1.Source = steps;
            //steps.IdTask = step;
            //foreach(Steps i in s)
            //{
            //   if(step.ID == i.IdTask)
            //    {
            //        testTb.Text = i.IdTask.ToString();
            //    }
            //}
            this.DataContext = this;
        }
    }
}
