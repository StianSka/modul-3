namespace puzzels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //toDashOne();
            //toDashTwo();
            //toDashThree();
            string input = Console.ReadLine();
             if (input != null)
             {
                 statistics(input);
             }
        }

        static void statistics(string input)
        {
            int wordLength = 0;
            int numOfWords = 0;
            int currentLongestWord = 0;
            string currentLongestWordSTR = "";
            string currenWord = "";
            char lastChar = 'a';
            
            foreach (var arg in input)
            {
                if (IsLetter(arg) == true)
                {
                    wordLength++;
                    currenWord = currenWord + arg;
                }
                else
                {
                    if (arg == ' ' && lastChar != ' ')
                    {
                        numOfWords = numOfWords +1;
                    }    
                    if (wordLength > currentLongestWord)
                    {
                        currentLongestWord = wordLength;
                        wordLength = 0;
                        currentLongestWordSTR = currenWord;
                        currenWord = "";
                    }
                    else { wordLength = 0; currenWord = ""; }
                }
                lastChar = arg;
            }
            if (lastChar!= ' ') { numOfWords++; }
            Console.WriteLine();
            Console.WriteLine("antal ord skrevet er: " + numOfWords);
            Console.WriteLine("lengste ordet skrevet var \""+ 
                currentLongestWordSTR + "\" og er " +
                currentLongestWord + " bokstaver langt");
            Console.WriteLine();

        }
        static bool IsLetter(char arg)
        {
            char[] letter = {'a','b','c','d','e','f','g','h','i',
                   'j','k','l','m','n','o','p','q','r','s','t','u',
                   'v','w','x','y','z','æ','ø','å',
                   'A','B','C','D','E','F','G','H','I','J',
                   'K','L','M','N','O','P','Q','R','S','T',
                   'U','V','W','X','Y','Z','Æ','Ø','Å'};

            for (int i = 0; i < letter.Length; i++)
            {
                if (arg == letter[i])
                {
                    return true;
                }
            }
            return false;
        }

        static void toDashThree()
        {
            for (int i = 0; i < 4; i++)
            {
                amountSpace(i);
                amountHash(i+1);
                amountSpace(12 - 4 * i);
                amountHash(i+1);
                newLine();
            }
            for (int i = 3; i >= 0; i--)
            {
                amountSpace(i);
                amountHash(i + 1);
                amountSpace(12 - 4 * i);
                amountHash(i + 1);
                newLine();
            }

        }
        static void toDashTwo()
        {
            for (int i = 3; i >= 0; i--)
            {
                amountSpace(i);
                amountHash(8 - 2 * i);
                newLine();
            }

            for (int i = 0; i < 4; i++)
            {
                amountSpace(i);
                amountHash(8 - 2 * i);
                newLine();
            }
        }
        static void toDashOne() 
        {
            for (int i = 0; i < 4; i++)
            {
                amountSpace(i);
                amountHash(8 - 2 * i);
                newLine();  
            }
        }

        static void amountHash(int count)
        {
            for (int i = 0; i < count; i++)
            {
                writeHash();
            }
        }

        static void amountSpace(int count)
        {
            for (int i = 0; i < count; i++)
            {
                writeSpace();
            }
        }
        static void writeHash() 
        {
            Console.Write("#");
        }
        static void writeSpace()
        {
            Console.Write(" ");
        }
        static void newLine()
        {
            Console.WriteLine();
        }
    }
}