using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPUke6
{
    internal class Car : Vehicle
    {
        public string Color { get; set; }

        public Car(string registrationNumber, int power, int topSpeed, string color) : base(registrationNumber, power, topSpeed)
        {
            Color = color;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Regnr: {RegisterationNumber}  Effekt: {Power}   Maksfart: {TopSpeed} km/t.  Farge: {Color}  Type: Lett kjøretøy ");

        }

        public override void Run()
        {
            Console.WriteLine("Bil kjører");
        }
    }
}
