using System.IO;
namespace inputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // var path = @"C:\Users\stian\Documents\GitHub\modul-3-stuff\uke 3\inputOutput\inputOutput\data.txt";
            // var text = File.ReadAllText(path);
            // Console.WriteLine(text);
            // text = text + text;
            // File.WriteAllText(path, text);
            var path = @"C:\Users\stian\Documents\GitHub\modul-3-stuff\uke 3\inputOutput\inputOutput\data.txt";
            var allLines = File.ReadAllLines(path);

            using (var streamReader = File.OpenText(path))
            {
                string line = null;
                int lineNum = 1;

                do
                {
                    line = streamReader.ReadLine();
                    if (line != null)
                    {
                        Console.WriteLine(lineNum.ToString().PadLeft(7, '0') + ": " + line);
                        lineNum++;
                    }
                } while (line != null);
            }

            /*
            for (int i = 0; i < allLines.Length; i++)
            {
                var line = allLines[i];
                //var lineNum = i + 1;
                var lineNum = (i + 1).ToString().PadLeft(7,'0');
                Console.WriteLine(lineNum + ": " + line);
            }
            */

        }
    }
}