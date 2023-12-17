using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class DateTimeExtentions
    {
        public static PersianDate ToPersianDate(this DateTime date)
        {
            var persianCalendar = new PersianCalendar();
            return new PersianDate()
            {
                Year = persianCalendar.GetYear(date),
                Month = persianCalendar.GetMonth(date),
                Day = persianCalendar.GetDayOfMonth(date),
                DayOfWeek = persianCalendar.GetDayOfWeek(date),
            };
        }
    }
}
