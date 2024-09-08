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
    /// GetControlTemplateDemo.xaml 的交互逻辑
    /// </summary>
    public partial class GetControlTemplateDemo : Window
    {
        public GetControlTemplateDemo()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            TextBox tb_1 =this.myUc.Template.FindName("tb1",myUc) as TextBox;
            tb_1.Text = "WPF";
            StackPanel sp=tb_1.Parent as StackPanel;
            (sp.Children[1] as TextBox).Text = "WPF2";
            (sp.Children[2] as TextBox).Text = "WPF3";

        }
    }
}
