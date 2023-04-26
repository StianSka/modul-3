using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPUke6
{
    abstract class Vehicle
    {
        public string RegisterationNumber { get; private set; }
        protected int Power;
        protected int TopSpeed;

        protected Vehicle(string registrationNumber, int power, int topSpeed)
        {
            RegisterationNumber = registrationNumber;
            Power = power;
            TopSpeed = topSpeed;
        }
        protected Vehicle(string registrationNumber, int power)
        {
            RegisterationNumber = registrationNumber;
            Power = power;
        }

        public virtual void PrintInfo()
        {

        }

        public override bool Equals(object obj)
        {
            //return Equals(obj as Vehicle);
            return object.ReferenceEquals(this, obj);
        }

        public virtual void Run()
        {
            
        }

    }
}
