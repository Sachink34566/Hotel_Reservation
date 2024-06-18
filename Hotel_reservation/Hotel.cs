using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_reservation
{
    public class Hotel
    {
        public string HotelName {  get; set; }
        public int WeekDayRegular {  get; set; }
        public int WeekEndRegular { get; set; }

        public Hotel(string name,int weekdayregular,int weekendregular)
        {
            HotelName = name;
            WeekDayRegular = weekdayregular;
            WeekEndRegular = weekendregular;
            Display();

        }
        public void Display()
        {
            Console.WriteLine($"Hotel '{HotelName}' with regular customer rate for Week Day is $ {WeekDayRegular} and Week End is $ {WeekEndRegular}.");
        }

        public static void cheapestregular(List<Hotel> hotels,int days)
        {
            int cheapestprice = hotels.Min ((hotel) => hotel.WeekDayRegular);

            Hotel cheapesthotel=hotels.Single((hotel)=> hotel.WeekDayRegular == cheapestprice);
            Console.WriteLine($"{cheapesthotel.HotelName}, hotel price $ {cheapesthotel.WeekDayRegular} ");
        }
    }
}
