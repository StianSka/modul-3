namespace pasword_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValid = true;
            if (args.Length != 2)
            {
                isValid = false;
            } 
            else
            {
                isValid = isLengthValid(args[0]);
                isValid = isOptionsValid(args[1]);
            }
            if (!isValid)
            {
                giveInstuctions();
                return;
            }
            else
            {
                string newPassword = getPassword(args[0], args[1]);
                Console.Write(newPassword);
            }
        }
        static string getPassword(string args, string args1 )
        {
            int pasLength = int.Parse(args);
            var options = args1;
            string pattern = options.PadRight(pasLength, 'l');
            string password = string.Empty;
            foreach (var category in pattern)
            {
                if (category == 'l') password += getRandomLetter('a','z');
                else if (category == 'L') password += getRandomLetter('A', 'Z');
                else if (category == 'd') password += getRandomDigit();
                else if (category == 's') password += getRandomSpecialCharacter();
            }
            return password;
        }

       
        static char getRandomLetter(char min, char max)
        {
            var random = new Random();
            return (char) random.Next(min, max);
        }
        static char getRandomDigit()
        {
            var random = new Random();
            return random.Next(0, 10).ToString()[0];
        }
        //!\"#¤%&/(){}[]
        static char getRandomSpecialCharacter()
        {
            var allSpecialChars = "!\"#¤%&/(){}[]";
            var random = new Random();
            var index = random.Next(0, allSpecialChars.Length);
            return allSpecialChars[index];
        }

        static bool isLengthValid(string s)
        {
            // return s.All(c => char.IsDigit(c));
            //  linja over skal gjøre det samme som alt under her 
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
            
        }
        static bool isOptionsValid(string s)
        {
            foreach (char c in s)
            {
                if (c != 'l' && c != 'L' && c != 'd' && c != 's')
                {                 
                    return false; ;
                }
            }
            return true; ;
        }
        static void giveInstuctions()
        {
            Console.WriteLine("PasswordGenerator ");
            Console.WriteLine("Options:");
            Console.WriteLine("- l = lower case letter ");
            Console.WriteLine("- L = upper case letter ");
            Console.WriteLine("- d = digit ");
            Console.WriteLine("- s = special character (!\"#¤%&/(){}[] ");
            Console.WriteLine("Example: PasswordGenerator 14 lLssdd");
            Console.WriteLine("Min. 1 lower case ");
            Console.WriteLine("Min. 1 upper case ");
            Console.WriteLine("Min. 2 special characters ");
            Console.WriteLine("Min. 2 digits ");
        }
    }
}