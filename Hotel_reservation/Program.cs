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
                new Hotel("The Oberoi Udaivilas", 600,1000,4),
                new Hotel("The Taj Mahal Palace Mumbai", 700, 1000,5 ),
                new Hotel("The Leela Palace New Delhi", 800, 1100,4),
                new Hotel("The Lodhi New Delhi",1000,1200,5)
            };
            Calculatedays calculatedays = new Calculatedays();

            Console.WriteLine("\n1.Cheapest Hotels 2.BestRated Hotels 3.Exit");
            Console.Write("Enter the choice = ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Finding the Cheapest hotel !");

                    var (weekDays, WeekEnds) = calculatedays.Count();
                    if (weekDays != -1)
                    {
                        Hotel.ChepeastRate(hotels, weekDays, WeekEnds);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Dates");
                    }
                    break;
                case 2:
                    Console.WriteLine("Finding the Best Hotels !");
                    var (BestweekDays, BestWeekEnds) = calculatedays.Count();
                    if (BestweekDays != -1 && BestWeekEnds != -1)
                    {
                        Hotel.BestRegular(hotels, BestweekDays, BestWeekEnds);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Dates");
                    }
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    
}
