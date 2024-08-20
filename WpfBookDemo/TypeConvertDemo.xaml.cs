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

namespace WpfBookDemo
{
    /// <summary>
    /// TypeConvertDemo.xaml 的交互逻辑
    /// </summary>
    public partial class TypeConvertDemo : Window
    {
        public TypeConvertDemo()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Human human=this.FindResource("human") as Human;
            MessageBox.Show(human.Child.Name);
        }
    }
}
