namespace ppUke2
{
    internal class Program
    {
        //Oppgave - Social Media

        //Lag applikasjon FriendFace.
        //Det er tiltenkt at dette skal bli det nyeste kule sosiale mediet som tar verden med storm.
        //Her trenger en bruker en profilside med diverse info om seg(ta gjerne inspirasjon fra andre sosiale medier),

        //Du må lage en metode som heter “AddFriend” og en metode “RemoveFriend”.

        //Når programmet starter opp skal du lage en hovedbruker som er “innlogget”.
        //Du må også opprette flere forskjellige brukere som lever på det sosiale mediet.

        //    Lag et kommandbasert meny i konsollen der du kan:

        //Legge til forskjellige brukere som venn(på den som er innlogget)
        //Fjerne brukere som venn
        //Printe ut en liste av alle man har lagt til som venn
        //Velge en av vennene og printe ut profilinformasjonen deres.
        static void Main(string[] args)
        {

            User[] users = new[]
            {
                new User("Kurt", new List<string>(){"Bosted: Viken", "Favorittfarge: Grilla", "Kjeledyr: Nei, men gryte" }),
                new User("Kåre", new List<string>(){"Bosted: Harstad", "Favorittfarge: Blågul", "Kjeledyr: Kattestrofe i C-dur" }),
                new User("Willy", new List<string>(){"Bosted: Svartedal", "Favorittfarge: Rainbow, bitches", "Kjeledyr: Stein" }),
                new User("Eva", new List<string>(){"Bosted: Rævland", "Favorittfarge: Lysebeige", "Kjeledyr: Vrengt polvått" }),
                new User("Kristin", new List<string>(){"Bosted: Transylvania", "Favorittfarge: Blodrødt", "Kjeledyr: Flaggermus" }),

            };
            Console.WriteLine("Hvem er du?");
            var userName = Console.ReadLine();
            var mainUser = new User(userName, new List<string>());
            Console.WriteLine("Hallo " + userName);
            WaitingForUser(users, mainUser);
        }

        private static void WaitingForUser(User[] users, User mainUser)
        {
            Console.WriteLine("Skriv inn 1 for å se andre brukere eller 2 bare venner 3 for å legge til venner eller 4 for å fjerne venner eller 5 for å velge noen å se informasjonen til");
            string command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    ListUsers(users);
                    break;
                case "2":
                    mainUser.ListMyFriends();
                    break;
                case "3":
                    mainUser.AddFriend(users, mainUser);
                    break;
                case "4":
                    mainUser.RemoveFriend(mainUser);
                    break;
                case "5":
                    mainUser.ShowFriendProfile(users, mainUser);
                    break;
                default:
                    Console.WriteLine("Ugyldig command, prøv igjen.");
                    break;
            }
            WaitingForUser(users, mainUser);
        }


        static void ListUsers(User[] users)
        {
            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }
        }
    }
}
