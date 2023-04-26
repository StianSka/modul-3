using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPUke6
{
    internal class Boat : Vehicle
    {
        public int GrossTonnage { get; set; }

        public Boat(string registrationNumber, int power, int maxSpeed, int grossTonnage) : base(registrationNumber, power, maxSpeed)
        {
            GrossTonnage = grossTonnage;


        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Regnr: {RegisterationNumber}  Effekt: {Power}   Maksfart: {TopSpeed} knop.  Bruttotonnasje: {GrossTonnage} kg");

        }



        public override void Run()
        {
            Console.WriteLine("Båt kjører");
        }

    }
}
