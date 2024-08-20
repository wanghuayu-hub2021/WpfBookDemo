using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBookDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AttributeDemo : Window
    {
        public AttributeDemo()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            //不使用x:Name  只是创建引用对象
            //Grid win = this.Content as Grid;
            //StackPanel sp = win.Children[0] as StackPanel;
            //TextBox tb = sp.Children[0] as TextBox;
            //tb.Text = "Message changed firstly!";
            //使用x:Name 则再ui中注册 即再window对象中创建Button btn1=new Button();  
            this.tb1.Text = "Message changed secondly!";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            //this.tb1.Text = "Message changed secondly!";
            //在后台获取
            //string str = this.FindResource("myStr") as string;
            //MessageBox.Show(str);

            //使用x:Shared="True" 相当于指向同一对象 false则是创建两个对象
            SolidColorBrush brush = this.btn2.Background as SolidColorBrush;
            brush.Color= Colors.Green;
        }
    }
}