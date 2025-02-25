using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week1ClassLibrary1
{
    public class ParkingException
    {
        private const double HourlyRate = 2.0;
        public int hours;
        public double cost = 0; 

        public ParkingException(int hours) 
        {
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine($"The cost information of customer parking {hours:F2} hours");
      

            if (hours == 1)
            {
                cost = HourlyRate;
                Console.WriteLine($"The total cost is $ {cost:F2}");
            }
            else if (hours > 1 && hours < 25)
            {
                cost = HourlyRate * hours;
                Console.WriteLine($"The total cost is $ {cost:F2}");
            }
            else
            {
                Console.WriteLine("You have exceeded 24 hours! Your car has been towed away");
                cost = 0;
            }

        }
    }
}