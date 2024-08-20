using System;
using System.Collections.Generic;
using System.Data;
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
    /// DatatableDemo.xaml 的交互逻辑
    /// </summary>
    public partial class DatatableDemo : Window
    {
        public DatatableDemo()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(string));

            for (int i = 0; i < 5; i++)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["Id"] = i;
                dataRow["Name"] = "Name" + i.ToString();
                dataRow["Age"] = 20 + i;
                dt.Rows.Add(dataRow);
            }

            this.listView1.ItemsSource = dt.DefaultView;
            this.listView1.DisplayMemberPath = "Name";
        }
    }
}
