using System;
using System.Windows.Data;
using System.Globalization;
using System.Windows;

namespace View.Converters;

/// <summary>
/// Конвертирует значения для поля Visibility
/// </summary>
public class VisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return !(bool)value ? Visibility.Hidden : (object)Visibility.Visible;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
