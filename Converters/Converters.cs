using System;
using System.Globalization;
using System.Windows.Data;
using lab6_new.Models;

namespace lab6_new
{
    // Конвертер для відображення середнього балу
    public class StudentToAverageConverter : IValueConverter //дозволяє кастомізувати як дані відображаються
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Student student)
            {
                return student.GetAverageScore().ToString("F1");
            }
            return "0.0";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    // Конвертер для відображення статусу сесії
    public class StudentToPassedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Student student)
            {
                return student.PassedSessionSuccessfully();
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}