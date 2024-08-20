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

namespace BindingSysDemo
{
    /// <summary>
    /// ItemSourceDemo.xaml 的交互逻辑
    /// </summary>
    public partial class ItemSourceDemo : Window
    {
        public ItemSourceDemo()
        {
            InitializeComponent();
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=1,Name="Tom",Age="20" },
                new Employee(){Id=2,Name="Shoyn",Age="20" },
                new Employee(){Id=3,Name="Timi",Age="20" },
                new Employee(){Id=4,Name="Jack",Age="20" }
            };
            this.listBoxEmployee.ItemsSource = employees;
            //在listBox获取ItemsSource后会以DisplayMemberPath创建binding
            //this.listBoxEmployee.DisplayMemberPath = "Name";
            Binding binding = new Binding("SelectedItem.Id") { Source = this.listBoxEmployee, 
                Mode = BindingMode.OneWay, UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged };
            this.tbId.SetBinding(TextBox.TextProperty, binding);
        }
    }
}
