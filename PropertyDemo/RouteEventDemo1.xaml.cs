﻿using System;
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

namespace RouteEventDemo
{
    /// <summary>
    /// RouteEventDemo1.xaml 的交互逻辑
    /// </summary>
    public partial class RouteEventDemo1 : Window
    {
        public RouteEventDemo1()
        {
            InitializeComponent();
            //this.gridRoot.AddHandler(Button.ClickEvent, new RoutedEventHandler(btn_Clicked));
        }

        private void btn_Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format("OriginalSource:{0},Source:{1}",(e.OriginalSource as FrameworkElement).Name,(e.Source as FrameworkElement).Name));
        }

        private void gridRoot_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format("OriginalSource:{0},Source:{1}", (e.OriginalSource as FrameworkElement).Name, (e.Source as FrameworkElement).Name));
        }
    }
}