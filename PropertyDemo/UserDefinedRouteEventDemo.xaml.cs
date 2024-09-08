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

namespace RouteEventDemo
{
    /// <summary>
    /// UserDefinedRouteEventDemo.xaml 的交互逻辑
    /// </summary>
    public partial class UserDefinedRouteEventDemo : Window
    {
        public UserDefinedRouteEventDemo()
        {
            InitializeComponent();
        }

        private void ReportTimeHandler(object sender, ReportTimeEventArgs e)
        {
            FrameworkElement frameworkElement = sender as FrameworkElement;
            if (frameworkElement != null)
            {
                string timeStr = e.ClickTime.ToString();
                string content = string.Format("{0}到达{1}", timeStr, frameworkElement.Name);
                this.lb1.Items.Add(content);
            }
            //指定到某个元素停止
            if (frameworkElement.Name == "grd2")
            {
                e.Handled = true;
            }
        }
    }
}
