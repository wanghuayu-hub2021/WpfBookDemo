using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBookDemo
{
    public class HumanTypeConverter : TypeConverter
    {
        public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
        {
            if (value is string)
            {
                Human human = new Human();
                human.Name = value as string;
                return human;
            }
            return ConvertFrom(context, culture, value);
        }
    }
}
