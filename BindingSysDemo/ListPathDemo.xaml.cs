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
    /// ListPathDemo.xaml 的交互逻辑
    /// </summary>
    public partial class ListPathDemo : Window
    {
        public ListPathDemo()
        {
            InitializeComponent();
            //List<string> strList = new List<string>() { "Tim", "Tom", "John" };
            //this.tb1.SetBinding(TextBox.TextProperty, new Binding("/") { Source = strList });
            //this.tb2.SetBinding(TextBox.TextProperty, new Binding("/Length") { Source = strList, Mode = BindingMode.OneWay });
            //this.tb3.SetBinding(TextBox.TextProperty, new Binding("/[2]") { Source = strList, Mode = BindingMode.OneWay });

            List<Country> countryList = new List<Country>(){new Country()
            {
                Name = "美国",
                ProvinceList = new List<Province> { new Province { Name="德克萨斯洲",CityList=new List<City>
            {
                new City{Name="纽约"},
                new City{Name="哈萨克"}
            } } }
            } };
            this.tb1.SetBinding(TextBox.TextProperty, new Binding("/Name") { Source = countryList });
            this.tb2.SetBinding(TextBox.TextProperty, new Binding("/ProvinceList/Name") { Source = countryList, Mode = BindingMode.OneWay });
            this.tb3.SetBinding(TextBox.TextProperty, new Binding("/ProvinceList/CityList/Name") { Source = countryList, Mode = BindingMode.OneWay });
        }
    }
    class City
    {
        public string Name { get; set; }
    }

    class Province
    {
        public string Name { get; set; }
        public List<City> CityList { get; set; }
    }

    class Country
    {
        public string Name { get; set; }
        public List<Province> ProvinceList { get; set; }
    }
}
