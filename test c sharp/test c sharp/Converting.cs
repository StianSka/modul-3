using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_c_sharp
{
    internal class Converting
    {
        static void Somthing()
        {
            // to string
            // anta variabel x - uansett datatype (av våre valgte datatyper)
            bool x = true;
            string s = "" + x;
            double d = 99.999;
            string s2 = d.ToString();
            // to int
            int i = Convert.ToInt32(d);
            // to float
            float f = Convert.ToSingle(i);
            float f2 = Convert.ToSingle(d);
            // to double
            double d2 = Convert.ToDouble(s2);


        }
    }
}
