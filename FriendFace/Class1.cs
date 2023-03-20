using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    public class Class1
    {
        private Profile LoggedInUser { get; set; }
        private List<Profile> Users { get; set; }

        public Class1()
        {
            LoggedInUser = new Profile("Åmund");

            Users = new List<Profile>();
            Users.Add(new Profile("Per"));
            Users.Add(new Profile("Anita"));
            Users.Add(new Profile("Frank"));
            Users.Add(new Profile("Bente"));

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
                    FriendProfileInfo();
                    break;
            }
        }

        public void AddFriend()
        {
            Console.Clear();
            Console.WriteLine("--- Add Friend ---\n");
            foreach (Profile user in Users)
            {
                Console.WriteLine($"{user.Name}");
            }
            Console.Write("\nEnter the user you want to add: ");
            var userInput = Console.ReadLine();
            var requestedUser = Users.Find(x => x.Name == userInput);

            if (requestedUser != null)
            {
                LoggedInUser.AddToFriendList(requestedUser);
            }
            HomeMenu();
        }

        public void RemoveFriend()
        {
            Console.Clear();
            Console.WriteLine("--- Remove Friend ---\n");
            LoggedInUser.ShowFriends();
            Console.Write("\nEnter the friend you want to remove: ");
            var userInput = Console.ReadLine();
            var requestedFriend = LoggedInUser.GetRequestedFriend(userInput);

            if (requestedFriend != null)
            {
                LoggedInUser.RemoveFromFriendList(requestedFriend);
            }
            HomeMenu();
        }

        public void FriendList()
        {
            Console.Clear();
            Console.WriteLine("--- Friend List ---\n");
            LoggedInUser.ShowFriends();
            Console.WriteLine("\nPress ENTER to go back to the home menu...");
            var input = Console.ReadKey(true);

            while (input.Key != ConsoleKey.Enter)
            {
                input = Console.ReadKey(true);
            }
            HomeMenu();
        }

        public void FriendProfileInfo()
        {
            Console.Clear();
            Console.WriteLine("--- Friend Profile Info ---\n");
            LoggedInUser.ShowFriends();
            Console.Write("\nEnter the friend you want to see the profile of: ");
            var userInput = Console.ReadLine();
            var requestedFriend = LoggedInUser.GetRequestedFriend(userInput);

            if (requestedFriend != null)
            {
                Console.Clear();
                Console.WriteLine($"--- {requestedFriend.Name} ---\n");
                Console.WriteLine("\nPress ENTER to go back to the home menu...");
                var input = Console.ReadKey(true);
                while (input.Key != ConsoleKey.Enter)
                {
                    input = Console.ReadKey(true);
                }
            }
            HomeMenu();
        }
    }
}

