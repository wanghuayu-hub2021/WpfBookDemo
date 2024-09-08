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

namespace ResourceDemo
{
    /// <summary>
    /// DynamicAndStaticDemo.xaml 的交互逻辑
    /// </summary>
    public partial class DynamicAndStaticDemo : Window
    {
        public DynamicAndStaticDemo()
        {
            InitializeComponent();
            //使用uri加载资源文件
            Uri uri = new Uri(@"pack://application:,,,/ResourceImage/screen1.png", UriKind.Absolute);
            //Uri uri = new Uri(@"/ResourceImage/screen1.png", UriKind.Relative);
            this.img1.Source=new BitmapImage(uri);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["str1"] = new TextBlock() { Text = "ABCD" };
            this.Resources["str2"] = new TextBlock() { Text = "efgh" };
            //代码中访问二进制资源
            string str3 = Resource1.str1;
        }
    }
}
