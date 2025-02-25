using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class ParkingException
    {
        private const double HourlyRate = 2.0;
        private const int MaxHours = 24;
        public double cost = 0;

        public ParkingException(int hours) { }

        public string CalculateParkingFee(int hours)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Customer Parking");
            result.AppendLine("Pay $2 for each hour");
            result.AppendLine("Maximum Limit = 24 hours");

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

            return result.ToString();
        }
    }
}