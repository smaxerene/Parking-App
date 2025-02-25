using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class ParkingType
    {
        public int Hours { get; set; }
        public ParkingType(int hours)
        {
            Hours = hours;
        }

    }
}