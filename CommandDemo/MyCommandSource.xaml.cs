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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CommandDemo
{
    /// <summary>
    /// MyCommandSource.xaml 的交互逻辑
    /// </summary>
    public partial class MyCommandSource : UserControl, ICommandSource
    {
        public MyCommandSource()
        {
            InitializeComponent();
        }

        public ICommand Command { get; set; }

        public object CommandParameter { get; set; }

        public IInputElement CommandTarget { get; set; }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            if (this.CommandTarget != null) { 
            this.Command.Execute(this.CommandTarget);
            }
        }
    }
}
