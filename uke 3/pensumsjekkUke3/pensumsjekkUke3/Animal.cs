using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pensumsjekkUke3
{
    internal class Animal
    {
        private string _name;
        private string _type;
        private string _favoritFood;
        private int _age;

        public Animal (string name, string type, string favorit, int age)
        {
            _name = name;
            _type = type;
            _favoritFood = favorit;
            _age = age;
        }
        public void Feed()
        {
            Console.WriteLine("8 / 10");
        }
        public void Feed(string fav)
        {
            Console.WriteLine("10 / 10 jeg elsker " + fav);
        }
        public void Summary()
        {
            Console.WriteLine($"Thiss is {_name} the {_type} they like {_favoritFood} and are {_age} years old");
        }
        public string Fav() { return _favoritFood; }
        public int Age() { return _age; }
        public string Name() { return _name; }
        public string Type() { return _type; }
    }
}
