using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_reservation
{
    public class Calculatedays
    {
        public (int,int) Count()
        {
            int weekDayCount = 0;
            int weekEndCount = 0;
            string format = "ddMMMyyyy";
            CultureInfo culture = CultureInfo.InvariantCulture;
            Console.WriteLine("Reservation Date");
            Console.WriteLine("enter string Date 10Jan2021");
            DateTime start= DateTime.ParseExact(Console.ReadLine(), format, culture);
            Console.WriteLine("enter end date 12Jan2021");
            DateTime end= DateTime.ParseExact(Console.ReadLine(), format,culture);

            if (start > end)
            {
                return (-1, -1);
            }
            for (DateTime date = start; date <= end; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                {
                    weekEndCount++;
                }
                else
                {
                    weekDayCount++;
                }
            }
            return (weekDayCount, weekEndCount);

        }
    }
}
