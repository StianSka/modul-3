using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPUke6
{
    internal class AirCraft : Vehicle
    {
        public int Wingspan { get; set; }
        public int LoadCapacity { get; set; }
        public int Weight { get; set; }

        public AirCraft(string registrationNumber, int power, int wingspan, int loadCapacity, int weight) : base(registrationNumber, power)
        {
            Wingspan = wingspan;
            LoadCapacity = loadCapacity;
            Weight = weight;

        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Regnr: {RegisterationNumber}  Effekt: {Power}   Vingespenn: {Wingspan}  Lasteevne: {LoadCapacity}  Egenvekt: {Weight}  I flyklasse jetfly");

        }

        public override void Run()
        {
            Console.WriteLine("Fly flyr");
        }
    }

}
