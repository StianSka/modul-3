using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readWriteToFile
{
    internal class Creature
    {
        public string Name { get;}
        public string Species { get; }
        public int Age { get; }
        public string Gender { get; }
        public Creature(string name, string species, int age, string gender)
        {
            Name = name;
            Species = species;
            Age = age;
            Gender = gender;
        }


    }
}
