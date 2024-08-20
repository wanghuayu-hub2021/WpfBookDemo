using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace PanelDemo
{
    /// <summary>
    /// ListboxDemo.xaml 的交互逻辑
    /// </summary>
    public partial class ListboxDemo : Window
    {
        public ListboxDemo()
        {
            InitializeComponent();

            List<Employee> empList = new List<Employee>()
            {
                new Employee() { Id=1,Name="Time",Age=30 },
                new Employee() { Id=2,Name="Tom",Age=30 },
                new Employee() { Id=3,Name="Jack",Age=30 },
                new Employee() { Id=4,Name="John",Age=30 }
            };
            this.listBoxEmployee.DisplayMemberPath = "Name";
            this.listBoxEmployee.SelectedValuePath = "Age";
            this.listBoxEmployee.ItemsSource = empList;
            this.listBoxEmployee.SelectedIndex = -1;

        }
    }
}
