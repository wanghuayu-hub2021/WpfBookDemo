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

namespace TemplateDemo
{
    /// <summary>
    /// MultiDataTrrigerDemo1.xaml 的交互逻辑
    /// </summary>
    public partial class MultiDataTrrigerDemo1 : Window
    {
        public MultiDataTrrigerDemo1()
        {
            InitializeComponent(); 
            SetData();
        }

        public void SetData()
        {
            List<Student> students = new List<Student>()
            {
                new Student() {Id=1,Name="Jack",Skill="Sales"},
                new Student() {Id=2,Name="Tom",Skill="Sales"},
                new Student() {Id=3,Name="Jack",Skill="Sales"}
            };
            this.listBoxStudent.ItemsSource = students; 
        }
    }
}
