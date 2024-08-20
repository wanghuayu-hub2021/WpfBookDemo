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

namespace BindingSysDemo
{
    /// <summary>
    /// BindingConverterDemo.xaml 的交互逻辑
    /// </summary>
    public partial class BindingConverterDemo : Window
    {
        public BindingConverterDemo()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            List<Plane> planes = new List<Plane>()
            {
                new Plane(){Category=Category.Bomber,Name="B-1",State=State.Unknown},
                new Plane(){Category=Category.Bomber,Name="B-2",State=State.Unknown},
                new Plane(){Category=Category.Fighter,Name="F-22",State=State.Unknown},
                new Plane(){Category=Category.Fighter,Name="Su-47",State=State.Unknown},
                new Plane(){Category=Category.Bomber,Name="B-52",State=State.Unknown},
                new Plane(){Category=Category.Fighter,Name="J-10",State=State.Unknown}
            };
            this.listBoxPlane.ItemsSource = planes;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Plane p in listBoxPlane.Items)
            {
                sb.AppendLine(string.Format("Category ={0},Name={1},State={2}", p.Category, p.Name, p.State));
            }
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "PlaneList.txt", sb.ToString());
            MessageBox.Show("保存成功!");
        }
    }

    public enum Category
    {
        Bomber,
        Fighter
    }

    public enum State
    {
        Available,
        Locked,
        Unknown
    }

    public class Plane
    {
        public Category Category { get; set; }
        public State State { get; set; }
        public string Name { get; set; }
    }

}
