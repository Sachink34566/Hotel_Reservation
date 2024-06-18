using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_reservation
{
    public class Hotel
    {
        public string HotelName { get; set; }
        public int WeekDayRegular { get; set; }
        public int WeekEndRegular { get; set; }
        public int TotalPrice { get; set; }
        public int Rating { get; set; }


        public Hotel(string name, int weekdayRegular, int weekendRegular,  int rating)
        {
            HotelName = name;
            WeekDayRegular = weekdayRegular;
            WeekEndRegular = weekendRegular;
            Rating = rating;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Hotel {HotelName} with regular customer rate for Week Day is $ {WeekDayRegular} and Week End is $ {WeekEndRegular} and Rating {Rating}.");
        }
        public static void BestRegular(List<Hotel>  hotels, int weekDays, int weekEnds)
        {
            int BestRating = hotels.Max((hotel) => hotel.Rating);
            Hotel BestHotel = hotels.Single((hotel) => hotel.Rating == BestRating);
            BestHotel.TotalPrice = (weekDays * BestHotel.WeekDayRegular) + (weekEnds * BestHotel.WeekEndRegular);
            Console.WriteLine($"{BestHotel.HotelName}, Total Price = ${BestHotel.TotalPrice}");
        }
        public static void ChepeastRate(List<Hotel> hotels, int weekday, int weekend)
        {
            foreach (Hotel hotel in hotels)
            {
                int weekdayPrice = weekday * hotel.WeekDayRegular;
                int weekendPrice = weekend * hotel.WeekEndRegular;
                hotel.TotalPrice = weekdayPrice + weekendPrice;
            }

            int minPrice = hotels.Min(h => h.TotalPrice);


            var cheapestHotels = hotels.Where(h => h.TotalPrice == minPrice);
            int bestRating=cheapestHotels.Max((h=>h.Rating));

            cheapestHotels=from hotel in hotels
                           where hotel.Rating == bestRating
                           select hotel;

            Console.WriteLine("Cheapest Hotels with the best rating are:");
            foreach (var hotel in cheapestHotels)
            {
                Console.WriteLine($"{hotel.HotelName}, Rating = {hotel.Rating}, Total Price = ${hotel.TotalPrice}");
            }
        }
    }
}
