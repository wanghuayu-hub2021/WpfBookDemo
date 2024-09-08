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
    /// Miniview.xaml 的交互逻辑
    /// </summary>
    public partial class Miniview : UserControl, IView
    {
        public Miniview()
        {
            InitializeComponent();
        }

        public bool isChanged { get; set; }

        public void Clear()
        {
            this.tb1.Clear();
            this.tb2.Clear();
            this.tb3.Clear();
            this.tb4.Clear();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void SetBinding()
        {
            throw new NotImplementedException();
        }
    }
}
