using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPUKE3
{
    internal class Food : InventoryItem, ISellable
    {
        private string _type;
       

        public Food(string type, string name, int count, double price)
        {
            Name = name;
            Count = count;
            Price = price;
            _type = type;
        }

        public double CalculatePrice()
        {
            return Price * Count;
        }

        public string ItemDetails()
        {
            return @$"This is a {Name} costing {Price} has the type {_type}";
        }
    }
}
