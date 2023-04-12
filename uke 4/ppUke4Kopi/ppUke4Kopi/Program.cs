namespace ppUke4Kopi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 1, 3, 6, 3, 2, 8 };
            bool result = ArrayIsSorted(numbers);
            Console.WriteLine(result);
            //SortDemo();
            string plaintext = Console.ReadLine();
            string cryptedMessage = CipherProblem(plaintext.ToUpper());
            Console.WriteLine(cryptedMessage);
            Console.WriteLine(DeCipher(cryptedMessage));
        }

        private static string CipherProblem(string plaintext)
        {

            // readonly char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string cryptedMessage = "";
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ\"'!#%&()*+<=>[]{},.;:/-"; // \"\' !#%&()*+-:<=>[]{}=,.;/- 
            const string CipherKey = "Q\"W'F!P#G%J&L()U*+Y<A=>R[]S{}T,D.;H:N/E-IOZXCVBKM";

            for (int i = 0; i < plaintext.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (plaintext[i] == alphabet[j])
                    {
                        cryptedMessage += CipherKey[j];
                    }
                }
                if (plaintext[i] == ' ')
                {
                    cryptedMessage += ' ';
                }
            }
            return cryptedMessage;
        }

        private static string DeCipher(string cryptedMessage)
        {
            string DeCipherTxt = "";
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ\"'!#%&()*+<=>[]{},.;:/-"; // \"\' !#%&()*+-:<=>[]{}=,.;/- 
            const string CipherKey = "Q\"W'F!P#G%J&L()U*+Y<A=>R[]S{}T,D.;H:N/E-IOZXCVBKM";

            for (int i = 0; i < cryptedMessage.Length; i++)
            {
                for (int j = 0; j < CipherKey.Length; j++)
                {
                    if (cryptedMessage[i] == CipherKey[j])
                    {
                        DeCipherTxt += alphabet[j];
                    }
                }
                if (cryptedMessage[i] == ' ')
                {
                    DeCipherTxt += ' ';
                }
            }
            return DeCipherTxt;

        }

        private static bool ArrayIsSorted(int[] numbers)
        {
            int[] sortedNums = new int[numbers.Length];
            CopyArray(sortedNums, numbers);
            SortArray(sortedNums);

            if (numbers == sortedNums)
            {
                return true;
            }
            return false;
        }

        private static void CopyArray(int[] sortedNums, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                sortedNums[i] = numbers[i];
            }
        }

        private static void SortArray(int[] sortedNums)
        {
            Array.Sort(sortedNums);
        }
    }
}