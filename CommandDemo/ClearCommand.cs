using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CommandDemo
{
    public class ClearCommand : ICommand
    {
        //当命令执行状态改变时应当被激发
        public event EventHandler? CanExecuteChanged;

        //判断是否执行
        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        //用于执行
        public void Execute(object? parameter)
        {
            IView view=parameter as IView;
            if (view != null)
            {
                view.Clear();
            }
        }
    }
}
