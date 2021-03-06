﻿using System;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace WpfValueConverters
{
    public class NameMultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            StringBuilder result = new StringBuilder();
            foreach (object obj in values)
                result.Append(obj.ToString() + " ");
            return result.ToString();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
