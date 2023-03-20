using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    public class Class1
    {
        private Profile loggedInUser;
        private List<Profile> users;

        public Class1()
        {
            loggedInUser = new Profile("Åmund");

            users = new List<Profile>();
            users.Add(new Profile("Per"));
            users.Add(new Profile("Anita"));
            users.Add(new Profile("Frank"));
            users.Add(new Profile("Bente"));

            HomeMenu();
        }

        public void HomeMenu()
        {
            Console.Clear();
            Console.WriteLine("1: Add friend");
            Console.WriteLine("2: Remove friend");
            Console.WriteLine("3: Show friend list");
            Console.WriteLine("4: Show friend profile info");
            var userInput = Console.ReadLine();
            ActionHandler(userInput);
        }

        public void ActionHandler(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    AddFriend();
                    break;
                case "2":
                    RemoveFriend();
                    break;
                case "3":
                    FriendList();
                    break;
                case "4":
                    Console.WriteLine("Loading action 4...");
                    break;
            }
        }

        public void AddFriend()
        {
            Console.Clear();
            Console.WriteLine("--- Add Friend ---");
            foreach (Profile user in users)
            {
                Console.WriteLine($"{user.Name}");
            }
            Console.Write("\nEnter the person you want to add: ");
            var userInput = Console.ReadLine();
            var requestedUser = users.Find(x => x.Name == userInput);

            if (requestedUser != null)
            {
                loggedInUser.Friends.Add(requestedUser);
            }
            HomeMenu();
        }

        public void RemoveFriend()
        {
            Console.Clear();
            Console.WriteLine("--- Remove Friend ---");
            foreach (Profile friend in loggedInUser.Friends)
            {
                Console.WriteLine(friend.Name);
            }
            Console.Write("\nEnter the person you want to remove: ");
            var userInput = Console.ReadLine();
            var requestedFriend = loggedInUser.Friends.Find(x => x.Name == userInput);

            if (requestedFriend != null)
            {
                loggedInUser.Friends.Remove(requestedFriend);
            }
            HomeMenu();
        }

        public void FriendList()
        {
            Console.Clear();
            Console.WriteLine("--- Friend List ---\n");
            foreach (Profile friend in loggedInUser.Friends)
            {
                Console.WriteLine(friend.Name);
            }
            Console.WriteLine("\nPress ENTER to go back to the home menu...");
            var input = Console.ReadKey(true);

            while (input.Key != ConsoleKey.Enter)
            {
                input = Console.ReadKey(true);
            }
            HomeMenu();
        }

        public void FriendProfileInfo() { }
    }
}
