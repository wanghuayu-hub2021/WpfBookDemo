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
    /// RelativeSouce.xaml 的交互逻辑
    /// 当不知道source是什么,但清楚其与binding的目标对象有层级关系时
    /// </summary>
    public partial class RelativeSouceDemo : Window
    {
        public RelativeSouceDemo()
        {
            InitializeComponent();

            /*RelativeSource rs =new RelativeSource(RelativeSourceMode.FindAncestor);//RelativeSourceMode.Self 绑定自身属性

            //从当前层向上找到第二个Grid
            rs.AncestorLevel = 2;
            rs.AncestorType = typeof(Grid);

            Binding binding = new Binding("Name") { RelativeSource = rs };
            this.tb1.SetBinding(TextBox.TextProperty, binding);*/
        }
    }
}
