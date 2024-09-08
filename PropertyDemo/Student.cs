using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RouteEventDemo
{
    public class Student
    {
        public static readonly RoutedEvent NameChangedEvent = EventManager.RegisterRoutedEvent("NameChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Student));

        public static void AddNameChangedHandler(DependencyObject o, RoutedEventHandler h)
        {
            UIElement element = o as UIElement;
            if (element != null)
            {
                element.AddHandler(NameChangedEvent, h);
            }
        }

        public static void RemoveNameChangedHandler(DependencyObject o,RoutedEventHandler h)
        {
            UIElement element = o as UIElement;
            if (element != null)
            {
                element.RemoveHandler(NameChangedEvent, h);
            }
        }

        public string Name { get; set; }

        public int Id { get; set; }

    }
}
