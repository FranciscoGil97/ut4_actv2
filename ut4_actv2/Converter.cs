﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace ut4_actv2
{
    class Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType.Name == "Visibility")
                return !(bool)value ? Visibility.Hidden : Visibility.Visible;
            else if (targetType.Name == "Double")
                return !(bool)value ? 0d : 60d;
            else
                return (bool)value ? Brushes.PaleGreen: Brushes.IndianRed;
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
