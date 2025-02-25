using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class StaffParking : ParkingType
    {
        private const double FirstTenHoursRate = 2.0;
        private const double AdditionalHoursRate = 2.0;
        private const int MaxHours = 24;

        public StaffParking(int hours) : base(hours) { }

        public string CalculateParkingFee(int hours)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Staff Parking");
            result.AppendLine("Pay $2 for first ten hours");
            result.AppendLine("Pay $2 for each hour in excess of 10 hours");
            result.AppendLine("Maximum Limit = 24 hours");

            if (hours > MaxHours)
            {
                result.AppendLine("Your car has been towed away");
            }
            else
            {
                double totalCost;
                if (hours <= 10)
                {
                    totalCost = hours * FirstTenHoursRate;
                }
                else
                {
                    totalCost = (10 * FirstTenHoursRate) + ((hours - 10) * AdditionalHoursRate);
                }
                result.AppendLine($"The total cost is: ${totalCost:F2}");
            }

            return result.ToString();
        }

    }
}