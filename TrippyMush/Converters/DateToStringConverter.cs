using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace TrippyMush.Converters
{
    internal class DateToStringConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            DateTime d = (DateTime)value;
            string month = d.Month.ToString();
            if (month.Length == 1)
            {
                month = "0";
                month += d.Month.ToString();
            }
            string day = d.Day.ToString();
            if (day.Length == 1)
            {
                day = "0";
                day += d.Day.ToString();
            }

            return d.Year.ToString().Substring(2) + "-" + month + "-" + day;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        #endregion
    }
}

