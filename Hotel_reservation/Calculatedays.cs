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
        public int Count()
        {
            string format = "ddMMMyyyy";
            CultureInfo culture = CultureInfo.InvariantCulture;
            Console.WriteLine("Reservation Date");
            Console.WriteLine("enter string Date 10Jan2021");
            DateTime start= DateTime.ParseExact(Console.ReadLine(), format, culture);
            Console.WriteLine("enter end date 12Jan2021");
            DateTime end= DateTime.ParseExact(Console.ReadLine(), format,culture);

            if (start <= end)
            {
                TimeSpan day=end- start;
                int r= day.Days+1;
                return r;
            }
            else
            {
                return -1;
            }

        }
    }
}
