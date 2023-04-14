using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pensumsjekkUke4
{
    public class Car
    {
        public string Brand { get; }
        public string PlateNum { get; }
        public int YearMade { get; }
        public int Traveled { get; }

        public Car(string brand, string plateNum, int yearMade, int traveled)
        {
            Brand = brand;
            PlateNum = plateNum;
            YearMade = yearMade;
            Traveled = traveled;
        }
    }
}
