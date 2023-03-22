using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppUke2
{
    internal class User
    {
        public string Name { get; private set; }
        private List<string> _list = new List<string>();

        public User(string name, List<string> list)
        {
            Name = name;
            _list = list;
        }

        public void ListMyFriends()
        {
            if (_list.Count != 0)
            {
                int temp = this._list.Count;
                for (int i = 0; i < temp; i++)
                {
                    Console.WriteLine(this._list[i]);
                }
            }
            else Console.WriteLine("Du har ingen venner");
        }

        public void ShowFriendProfile(User[] users, User mainUser)
        {
            if (_list.Count != 0)
            {
                ListMyFriends();
                Console.WriteLine("skriv navnet til personen du ønsker å se profilen til");
                string friendProfile = Console.ReadLine();
                foreach (var item in mainUser._list)
                {
                    if (item == friendProfile)
                    {
                        WriteProfileItems(item, users);
                        return;
                    }
                }

                Console.WriteLine("Fant ikke venn");
            }
        }

        private void WriteProfileItems(string item, User[] users)
        {
            foreach (var user in users)
            {
                if (user.Name == item)
                {
                    foreach (var stuff in user._list)
                    {
                        Console.WriteLine(stuff);
                    }
                }
            }
        }

        public void AddFriend(User[] users, User mainUser)
        {
            Console.WriteLine("Skriv navnet til din nye venn:");
            var friendToAdd = Console.ReadLine();
            foreach (var user in users)
            {
                if (user.Name.Contains(friendToAdd))
                {
                    mainUser._list.Add(user.Name);
                    Console.WriteLine($"Hurra, {user.Name} er nå din nye venn!");
                    return;
                }
            }
            Console.WriteLine("Fant ikke navnet, prøv igjen.");
        }

        public void RemoveFriend(User mainUser)
        {
            if (_list.Count == 0)
            {
                Console.WriteLine("Her var det tomt.");
                return;
            }

            Console.WriteLine("Skriv navnet til den personen du vil fjerne:");
            var friendToRemove = Console.ReadLine();
            foreach (var user in mainUser._list)
            {
                if (user.Contains(friendToRemove))
                {
                    mainUser._list.Remove(user);
                    Console.WriteLine($"Hade bra, {friendToRemove}.");
                    return;
                }


            }
            Console.WriteLine($"Fant ikke {friendToRemove}.");

        }

    }

}
