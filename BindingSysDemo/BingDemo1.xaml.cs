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
    /// BindingSysDemo1.xaml 的交互逻辑
    /// </summary>
    public partial class BindingSysDemo1 : Window
    {
        Student student = null;
        public BindingSysDemo1()
        {
            InitializeComponent();
            //student = new Student();
            //Binding binding = new Binding();
            //binding.Source = student;
            //binding.Path = new PropertyPath("Name");

            //BindingOperations.SetBinding(this.tb1, TextBox.TextProperty, binding);
            this.tb1.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = student = new Student() });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.student.Name += "Name";
        }
    }
}
