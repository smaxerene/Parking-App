using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week1ClassLibrary1
{
    public class CustomerParking : ParkingType 
    {
        private const double HourlyRate = 2.0;
        public double cost = 0;
        public CustomerParking(int hours) : base(hours)
        {
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine($"The cost information of customer parking {hours:F2} hours");
            Console.WriteLine("\nCustomer Parking \nPay $2 for each hour \nMaximum limit = 24 hours\n\n");
           
            if(hours == 1)
            {
                cost = HourlyRate;
            }
            else if (hours > 1 && hours < 25)
            {
                cost = HourlyRate * hours;
            }
            else
            {
                Console.WriteLine("You have exceeded 24 hours! Your car has been towed away");
                cost = 0;
            }
            Console.WriteLine($"The total cost is $ {cost:F2}");
        }

    }
}