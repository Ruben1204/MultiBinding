using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiBinding.Interfaces
{
    public class ConvertidorFamiliar : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
           if (values != null && targetType.IsAssignableFrom(typeof(string)) && parameter != null) 
            {
                if (values.Contains(parameter))
                    return $"Hola Familiar {string.Join(", ", values)}";
                else 
                    return $"Hola {string.Join(", ", values)}";
            }
            return "Hola Desconocido";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
