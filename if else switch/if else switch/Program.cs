using System.Diagnostics.CodeAnalysis;

namespace if_else_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kan du gi meg ett tall ?");
            var num1 = Console.ReadLine();
            Console.WriteLine("Kan du gi meg enda et tall");
            var num2 = Console.ReadLine();
            int one = int.Parse(num1);
            int two = int.Parse(num2);
            //bool result = compareNumbers(num1, num2);
            //int result = mathStuff(one, two);
            bool result = is30(one, two);
            Console.WriteLine(result);
        }
        static bool compareNumbers(string num1, string num2)
        {

            bool result = false;
            if (num1 == num2)
            {
                result = true;
            }
            return result;
        }
        static int mathStuff(int num1, int num2) 
        {
            int sum = 0;
           
            if (num1 != num2)
            {
                sum = num1 + num2;
            }
            else
            {
                sum = num1 * num2;
            }

            return sum;
        }
        static bool is30(int one, int two)
        {
            bool result = false;
            if (one == 30 || two == 30 || one + two == 30) 
            {
                result = true;
            }
            return result;
        }
    }
}