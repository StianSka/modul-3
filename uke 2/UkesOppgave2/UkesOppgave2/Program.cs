namespace UkesOppgave2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students;
            students = new Student[6];
            CreateStudents(students);
            ShowMenu(students);
        }
        static void ShowMenu(Student[] students)
        {
            Console.WriteLine("Velg et kurs for å se deltakere");
            Console.WriteLine("1: Matte");
            Console.WriteLine("2: Norsk");
            Console.WriteLine("3: Samfunsfag");
            Console.WriteLine("4: Engelsk");
            string selectedCoure = Console.ReadLine();
            string choise = CheckChoise(selectedCoure);
            ListParticapents(choise, students);
        }
        static string CheckChoise(string choise)
        {
            string course = "nope";
            switch (choise)
            {
                case "1":
                    course = ("Matte");
                    break;
                case "2":
                    course = ("Norsk");
                    break;
                case "3":
                    course = ("Samfunsfag");
                    break;
                case "4":
                    course = ("Engelsk");
                    break;
                default:
                    course = ("nope");
                    break;
            }
            return course;
        }
        static void ListParticapents(string choise, Student[] students)
        {
            if(choise == "nope") { return; }
            for (int i = 0; i < students.Length; i++)
            {
               if ( students[i].IsParticapent(choise) == true)
                {
                    students[i].ShowAll();
                }
            }
            ShowMenu(students);
        }
        static void CreateStudents(Student[] students) {
            string[] names = { "Per", "Petter", "Alex", "Mia", "Gunnar", "Trude" };
            int[] ages = { 21, 24, 30, 25, 17, 29 };
            string[] courses = {"Matte","Norsk","Samfunsfag", "Engelsk" };
            
            for (int i = 0; i < names.Length; i++)
            {
                int rng = RngNums(courses);
                students[i] = new Student(names[i], ages[i], courses[rng]);
            }
        }
        static int RngNums(string[] temp)
        {
            Random random = new Random();
            int rng = random.Next(0,temp.Length);
            return rng;
        }
    }
}