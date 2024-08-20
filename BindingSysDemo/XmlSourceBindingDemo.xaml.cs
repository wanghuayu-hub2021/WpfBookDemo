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
using System.Xml;

namespace BindingSysDemo
{
    /// <summary>
    /// XmlSourceBindingDemo.xaml 的交互逻辑
    /// </summary>
    public partial class XmlSourceBindingDemo : Window
    {
        public XmlSourceBindingDemo()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            string xmlPath = AppDomain.CurrentDomain.BaseDirectory + "StudentList.xml";
            xmlDocument.Load(xmlPath);
            XmlDataProvider xdp = new XmlDataProvider();
            //xdp.Document = xmlDocument;
            xdp.Source=new Uri(xmlPath);
            xdp.XPath = @"/StudentList/Student";

            this.listView1.DataContext = xdp;
            this.listView1.SetBinding(ListView.ItemsSourceProperty, new Binding());

        }
    }
}
