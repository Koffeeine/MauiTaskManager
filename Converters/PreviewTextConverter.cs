using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MyTask.Converters
{
    public class PreviewTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string text && !string.IsNullOrWhiteSpace(text))
                return $"Preview: {text}";

            return "Preview:";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }

}
