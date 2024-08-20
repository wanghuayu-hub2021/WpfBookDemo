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
using System.Xml;
using System.Xml.Linq;

namespace BindingSysDemo
{
    /// <summary>
    /// LinqBindingDemo.xaml 的交互逻辑
    /// </summary>
    public partial class LinqBindingDemo : Window
    {
        public LinqBindingDemo()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            //操作List
            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee(){Id=1,Name="Tom",Age="20" },
            //    new Employee(){Id=2,Name="Shoyn",Age="20" },
            //    new Employee(){Id=3,Name="Timi",Age="20" },
            //    new Employee(){Id=4,Name="Jack",Age="20" }
            //};
            //this.listView1.ItemsSource = from stu in employees where stu.Name.Contains("T") select stu;
            XDocument xmlDoc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "StudentList2.xml");
            //适用linq操作xml Descendants可以跨越层级
            this.listView1.ItemsSource = from eml in xmlDoc.Descendants("Student")
                                         where eml.Attribute("Name").Value.StartsWith("T")
                                         select new Employee
                                         {
                                             Id = int.Parse(eml.Attribute("Id").Value),
                                             Name = eml.Attribute("Name").Value,
                                             Age = eml.Attribute("Age").Value
                                         };

        }
    }
}
