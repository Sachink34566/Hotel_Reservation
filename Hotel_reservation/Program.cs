using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_reservation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation");

            List<Hotel> hotels = new List<Hotel>()
            {
                new Hotel("The Oberoi Udaivilas", 600,1000),
                new Hotel("The Taj Mahal Palace Mumbai", 700, 1000  ),
                new Hotel("The Leela Palace New Delhi", 800, 1100),
                new Hotel("The Lodhi New Delhi",1000,1200)
            };

            Calculatedays calculatedays = new Calculatedays();
            var (weekDays, WeekEnds) = calculatedays.Count();
            if (weekDays != -1)
            {
                Hotel.ChepeastRate(hotels, weekDays, WeekEnds);
            }
            else
            {
                Console.WriteLine("Invalid Dates");
            }
        }
    }
}
