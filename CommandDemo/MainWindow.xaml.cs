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

namespace CommandDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeCommand();
        }
        //1.声明并定义命令
        private RoutedCommand clearCommand = new RoutedCommand("Clear", typeof(MainWindow));

        private void InitializeCommand()
        {
            //将命令赋给命令源(发送者)
            this.btn1.Command = clearCommand;
            this.clearCommand.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));

            //指定命令目标
            this.btn1.CommandTarget = this.tb1;
            
            //进行命令关联
            CommandBinding binding = new CommandBinding();
            binding.Command = this.clearCommand;
            binding.CanExecute += Binding_CanExecute;
            binding.Executed += Binding_Executed;

            //把命令关联放到外围控件上
            this.sp1.CommandBindings.Add(binding); 
        }

        //命令发送到目标后 被调用
        private void Binding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.tb1.Text = "";
            e.Handled = true;
        }

        //探测命令是否可以被执行时调用
        private void Binding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (this.tb1.Text.Trim() == "")
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
            e.Handled = true;
        }
    }
}