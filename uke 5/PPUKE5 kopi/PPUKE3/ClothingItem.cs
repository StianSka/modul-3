using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPUKE3
{
    internal class ClothingItem : InventoryItem, ISellable, IDetails
    {

        private string _color;
        private int _size;

        public ClothingItem(string color, int size, string name, int count, double price)
        {
            Name = name;
            Count = count;
            Price = price;
            _color = color;
            _size = size;
        }

        public double CalculatePrice()
        {
            return Price * Count;
        }

        public string ItemDetails()
        {
            return @$"This is a {Name} costing {Price} has the color {_color} and has a size of {_size}";
        }

    }
}

