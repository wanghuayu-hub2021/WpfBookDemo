using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BindingSysDemo
{
    public class Category2SourceConverter : IValueConverter
    {
        //将Category转换成Uri
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Category category = (Category)value;
            switch (category)
            {
                case Category.Fighter:
                    return @"\Icon\Fighter.png";
                case Category.Bomber:
                    return @"\Icon\Bomber.png";
                default:
                    return null;
            }
        }

        //不会被调用
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class State2NullableBoolConverter : IValueConverter
    {
        //将State转换成bool
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            State state = (State)value;
            switch (state)
            {
                case State.Locked:
                    return false;
                case State.Available:
                    return true;
                case State.Unknown:
                default:
                    return null;
            }
        }

        //不会被调用
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? nb = (bool?)value;
            switch (nb)
            {
                case true:
                    return State.Available;
                case false:
                    return State.Locked;
                case null:
                default:
                    return State.Unknown;
            }
        }
    }
}
