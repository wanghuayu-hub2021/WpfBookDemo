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
    /// ValidationRulesDemo.xaml 的交互逻辑
    /// </summary>
    public partial class ValidationRulesDemo : Window
    {
        public ValidationRulesDemo()
        {
            InitializeComponent();

            Binding binding = new Binding("Value") { Source = this.sld1, UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged };
            RangeValidationRule rule = new RangeValidationRule();
            //此参数用来校验source数据
            rule.ValidatesOnTargetUpdated = true;
            binding.ValidationRules.Add(rule);
            //通过路由事件获取校验的报错信息
            //信号在UI树上传递的过程乘坐路由事件
            binding.NotifyOnValidationError = true;

            this.tb1.SetBinding(TextBox.TextProperty, binding);
            //监听校验失败错误
            this.tb1.AddHandler(Validation.ErrorEvent, new RoutedEventHandler(this.ValidationError));
        }

        private void ValidationError(object sender, RoutedEventArgs e)
        {
            if (Validation.GetErrors(this.tb1).Count > 0)
            {
                this.tb1.ToolTip = Validation.GetErrors(this.tb1)[0].ErrorContent.ToString();
            }
        }
    }
}
