using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static DateTime ToHalfHour(this DateTime dateTime)
        {
            if (dateTime.Minute > 15 && dateTime.Minute <= 45)
            {
                return new DateTime(
                    dateTime.Year, 
                    dateTime.Month, 
                    dateTime.Day, 
                    dateTime.Hour, 
                    30, 
                    00);
            }

            if (dateTime.Minute >= 0 && dateTime.Minute <= 15)
            {
                return new DateTime(
                    dateTime.Year,
                    dateTime.Month,
                    dateTime.Day,
                    dateTime.Hour,
                    00,
                    00);
            }

            if (dateTime.Minute > 45)
            {
                return dateTime.AddMinutes(60 - dateTime.Minute);
            }

            return DateTime.Now;
        }
    }
}
