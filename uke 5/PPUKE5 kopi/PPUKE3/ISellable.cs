using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPUKE3
{
    internal interface ISellable
    {
        double CalculatePrice();
        string ItemDetails();
    }
}
