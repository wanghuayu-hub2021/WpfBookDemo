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

namespace PanelDemo
{
    /// <summary>
    /// ItemControlDemo.xaml 的交互逻辑
    /// </summary>
    public partial class ItemControlDemo : Window
    {
        public ItemControlDemo()
        {
            InitializeComponent();
        }

        private void btnVictor_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            DependencyObject level1=VisualTreeHelper.GetParent(button);
            DependencyObject level2 = VisualTreeHelper.GetParent(level1);
            DependencyObject level3 = VisualTreeHelper.GetParent(level2);
            MessageBox.Show(string.Format("{0},{1},{2}",level1.GetType().ToString(),level2.GetType().ToString(),level3.GetType().ToString()));
        }
    }
}
