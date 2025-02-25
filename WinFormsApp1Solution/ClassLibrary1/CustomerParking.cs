using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class CustomerParking : ParkingType
    {
        private const double HourlyRate = 2.0;
        private const int MaxHours = 24;
        public double cost = 0;

        public CustomerParking(int hours) : base(hours) { }

        public string CalculateParkingFee(int hours)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Customer Parking");
            result.AppendLine("Pay $2 for each hour");
            result.AppendLine("Maximum Limit = 24 hours");

            if (hours > MaxHours)
            {
                result.AppendLine("Your car has been towed away");
            }
            else
            {
                double totalCost = hours * HourlyRate;
                result.AppendLine($"The total cost is: ${totalCost:F2}");
            }

            return result.ToString();
        }

    }
}