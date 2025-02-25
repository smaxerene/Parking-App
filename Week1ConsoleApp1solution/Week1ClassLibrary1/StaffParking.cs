using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week1ClassLibrary1
{
    public class StaffParking : ParkingType
    {
        private const double firstTenHoursRate = 2.0;
        public double cost = 0;

        public StaffParking(int hours) : base( hours)
        {
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine($"The cost information of staff parking {hours:F2} hours");
            Console.WriteLine("\nStaff Parking \nPay $2 for each hour \nPay $2 for each hour in excess of 10 hours \nMaximum limit = 24 hours\n\n");

            if (hours <= 10)
            {
                cost = firstTenHoursRate;
            }
            else if (hours > 10 && hours < 25)
            {
                double additionalHoursCost = (hours - 10) * 2.0;
                cost = firstTenHoursRate + additionalHoursCost;
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