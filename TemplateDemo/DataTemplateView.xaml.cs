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

namespace TemplateDemo
{
    /// <summary>
    /// DataTemplateView.xaml 的交互逻辑
    /// </summary>
    public partial class DataTemplateView : Window
    {
        public DataTemplateView()
        {
            InitializeComponent();
            GetCarData();
        }

        public void GetCarData()
        {
            List<Car> cars = new List<Car>()
            {
                new Car{Name="avatar1",Year="1998",Automaker="CN",TopSpeed="300"},
                new Car{Name="avatar2",Year="1999",Automaker="CN",TopSpeed="350"},
                new Car{Name="avatar3",Year="2000",Automaker="CN",TopSpeed="400"}
            };
            this.listBoxCar.ItemsSource = cars;
        }
    }
}
