namespace test_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // deklarering av variabler forskjelige datatyper 

            bool b1, b2, b3;
            int i;
            float f;
            double d;
            string s;

            // tilordning

            b1 = true;
            b2 = false;
            b3 = false;
            i = 50;
            f = 10.5f;      //må ha med en f for å si at det er en float hvis ikke blir det tolket som en double
            d = 1.345;
            s = "Yaho";

            //kan også dekalere og tilordne verdi samtidig

            bool b4 = false;
            int i2 = 46;
            float f2 = 3.9f;    //må ha med en f for å si at det er en float hvis ikke blir det tolket som en double
            double d2 = 4.57;
            string s2 = "WEEEEEE";

            var b5 = true;
            var i3 = 19;
            var f3 = 5.5f;  //må ha med en f for å si at det er en float hvis ikke blir det tolket som en double
            var d3 = 5.5;
            var s3 = "Shalom";

            //if (args.Length == 0)
            //{
            //    Console.WriteLine("Shalom ingen parametere gitt ");
            //}
            //else
            //{
            //    Console.WriteLine("Shalom her kommer paramterene dine ");
            //}
            //for (int i = 0; i<args.Length; i++)
            //{
            //    var parameterNo = i + 1;
            //    Console.WriteLine("Shalom "+parameterNo+": " + args[i]);
            //}
            //foreach (string text in args)
            //{
            //    Console.WriteLine("Shalom "+text);
            //}
        }
    }
}