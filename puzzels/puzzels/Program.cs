namespace puzzels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //toDashOne();
            //toDashTwo();
            toDashThree();
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