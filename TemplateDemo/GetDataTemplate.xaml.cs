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
    /// GetDataTemplate.xaml 的交互逻辑
    /// </summary>
    public partial class GetDataTemplate : Window
    {
        public GetDataTemplate()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox text=this.cp1.ContentTemplate.FindName("tb1",cp1) as TextBox;
            MessageBox.Show(text.Text);

            Student stu2=this.cp1.Content as Student;
            MessageBox.Show(stu2.Skill);
        }
    }
}
