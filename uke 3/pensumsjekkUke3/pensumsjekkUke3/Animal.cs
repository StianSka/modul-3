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
        private string _favoritFood;
        private int _age;

        public Animal (string name, string favorit, int age)
        {
            _name = name;
            _favoritFood = favorit;
            _age = age;
        }

        public void AgeUp()
        {
            Console.WriteLine(_age);
            _age += 1;
        }
        public void Feed()
        {
            Console.WriteLine("8 / 10");
        }
        public void Feed(string fav)
        {
            Console.WriteLine("10 / 10 jeg elsker " + fav);
        }
        public string Fav() { return _favoritFood; }
        public int Age() { return _age; }
        public string Name() { return _name; }
    }
}
