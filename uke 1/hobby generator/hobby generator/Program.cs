
namespace hobby_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who would like a new hobby?");
            var name = Console.ReadLine();
            string hobbyText= newHobby();
            Console.WriteLine("So " + name + " " + hobbyText);
        }
        static string newHobby() 
        {
            string hobby;
            Random rng = new Random();
             int rng1 = rng.Next(1, 6);
            

            switch (rng1)
            {
                case 1:
                    hobby = "you`r new hobby is acroyoga";
                    break;
                case 2:
                    hobby = "you`r new hobby is amateur radio";
                    break;
                case 3:
                    hobby = "you`r new hobby is macramé";
                    break;
                case 4:
                    hobby = "you`r new hobby is fingerpainting ";
                    break;
                case 5:
                    hobby = "you`r new hobby is lapidary";
                    break;
                default:
                    hobby = "you`r new hobby cannot be decided";
                    break;
            }

            return hobby;
        }
    }
}