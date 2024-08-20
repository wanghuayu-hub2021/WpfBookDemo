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
    /// ObjectDataProviderDemo.xaml 的交互逻辑
    /// 当只想暴漏部分属性的时候
    /// </summary>
    public partial class ObjectDataProviderDemo : Window
    {
        public ObjectDataProviderDemo()
        {
            InitializeComponent();
            this.SetBinding();
        }

        private void SetBinding()
        {
            ObjectDataProvider odp = new ObjectDataProvider();
            //让ObjectDataProvider自行创建对象
            //odp.ObjectType = typeof(Calculator);
            odp.ObjectInstance = new Calculator();
            odp.MethodName = "Add";
            //ObjectDataProvider通过参数数量来区分重载方法
            //MethodParameters并非依赖属性
            odp.MethodParameters.Add("0");
            odp.MethodParameters.Add("0");

            Binding binding2Arg1 = new Binding("MethodParameters[0]")
            {
                Source = odp,
                //直接写若obp对象而不是Calculator
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            Binding binding2Arg2 = new Binding("MethodParameters[1]")
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            Binding binding2Res = new Binding(".") { Source = odp };

            this.tbArg1.SetBinding(TextBox.TextProperty, binding2Arg1);
            this.tbArg2.SetBinding(TextBox.TextProperty, binding2Arg2);
            this.tbRes.SetBinding(TextBox.TextProperty, binding2Res);

        }
    }
}
