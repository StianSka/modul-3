using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPUKE3
{
    internal class ElectronicItem : InventoryItem, ISellable, IDetails
    {

        private string _insuranceInfo;
        private int _current;

        public ElectronicItem(string insuranceInfo, int current, string name, int count, double price)
        {
            _insuranceInfo = insuranceInfo;
            _current = current;
            Name = name;
            Count = count;
            Price = price;
        }

        public double CalculatePrice()
        {
            return Count * Price;   
        }

        public string ItemDetails()
        {
            return  $"Navn: {Name}. Spenning: {_current} volt. Pris: {Price}. Forsikringsinformasjon: {_insuranceInfo} ";
            
        }
    }
}
