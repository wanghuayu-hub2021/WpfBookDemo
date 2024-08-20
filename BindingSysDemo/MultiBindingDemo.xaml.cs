using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// MultiBindingDemo.xaml 的交互逻辑
    /// </summary>
    public partial class MultiBindingDemo : Window
    {
        public MultiBindingDemo()
        {
            InitializeComponent();
            this.SetMultiBinding();
        }

        private void SetMultiBinding()
        {
            //准备基础binding
            Binding b1 = new Binding("Text") { Source = this.tb1 };
            Binding b2 = new Binding("Text") { Source = this.tb2 };
            Binding b3 = new Binding("Text") { Source = this.tb3 };
            Binding b4 = new Binding("Text") { Source = this.tb4 };

            //multibinding
            MultiBinding mb = new MultiBinding();
            mb.Bindings.Add(b1);
            mb.Bindings.Add(b2);
            mb.Bindings.Add(b3);
            mb.Bindings.Add(b4);
            mb.Converter = new LoginMultiBindingConverter();

            this.btn1.SetBinding(Button.IsEnabledProperty, mb);
        }
    }

    public class LoginMultiBindingConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (!values.Cast<string>().Any(o => string.IsNullOrEmpty(o)) && values[0].ToString() == values[2].ToString()
                && values[1].ToString() == values[3].ToString())
            {

                return true;
            }
            return false;
        }

        public object[] ConvertBack(object value, Type[] targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
