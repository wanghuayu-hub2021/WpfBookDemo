using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
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

namespace TemplateDemo
{
    /// <summary>
    /// CarDetail.xaml 的交互逻辑
    /// </summary>
    public partial class CarDetail : UserControl
    {
        public CarDetail()
        {
            InitializeComponent();
        }

        private Car car;

        public Car CarData
        {
            get { return car; }
            set
            {
                CarData = value;
                this.tblName.Text = value.Name;
                this.tblYear.Text = value.Year;
                this.tblAutoMaker.Text = value.Year;
                this.tblTopSpeed.Text = value.TopSpeed;
                string uriStr = string.Format(@"/Resources/{0}.jpeg",value.Name);
                this.img1.Source=new BitmapImage(new Uri(uriStr,UriKind.Relative));
            }
        }

    }
}
