namespace readWriteToFile
{
    internal class Program
    {
        static string path = "C:\\Users\\stian\\Documents\\GitHub\\modul-3-stuff\\uke 4\\readWriteToFile\\test.txt";
        static void Main(string[] args)
        {
            MakeCreature();
        }
        static void MakeCreature()
        {
            string[] names = {"Kåre", "Pål", "Trude", "Mia"};
            string[] species = {"Elefant", "Spekkhogger", "Kenguru" };
            string name = names[RandomNum(0,names.Length)];
            string thispecies = species[RandomNum(0, species.Length)];
            int age  = RandomNum(0, 15);
            int result = RandomNum(0, 2);
            string gender = result == 1 ? "han" : "hun";
            Creature creature = new Creature(name, thispecies, age, gender);
            //ReadCreature();
            //ReadSpecificLine(4);
            //EditFile(path, "test");
            PrintCreatureDeets(creature);
        }
        static void PrintCreatureDeets(Creature creatue)
        {
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(creatue.Name);
            writer.WriteLine(creatue.Species);
            writer.WriteLine(creatue.Age);
            writer.WriteLine(creatue.Gender);
            writer.WriteLine();
            writer.Close();
        }
        //static void EditFile(string filePath, string newContent)
        //{
        //    using (StreamWriter writer = new StreamWriter(filePath, false))
        //    {
        //        writer.Write(newContent);
        //        writer.Close();
        //    }
        //}
        static void ReadCreature()
        {
            StreamReader reader = new StreamReader(path);
            string line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
            reader.Close();
        }
        static void ReadSpecificLine(int lineNumber)
        {
            StreamReader reader = new StreamReader(path);
            string line;
            int currentLine = 1;

            while ((line = reader.ReadLine()) != null)
            {
                if (currentLine == lineNumber)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    break;
                }
                currentLine++;
            }
            reader.Close();
        }
        static int RandomNum(int min, int max)
        {
            Random random = new Random();
            int rng = random.Next(min, max);
            return rng;
        }
    }
}