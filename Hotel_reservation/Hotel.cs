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
        public int RegularCustomerRate { get; set; }

        public Hotel(string name,int rate)
        {
            HotelName = name;
            RegularCustomerRate = rate;

        }
        public void Display()
        {
            Console.WriteLine($"Hotel '{HotelName}' with regular customer rate $ {RegularCustomerRate}.");
        }
    }
}
