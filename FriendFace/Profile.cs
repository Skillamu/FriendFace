using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    public class Profile
    {
        public string Name { get; private set; }
        private List<Profile> Friends { get; set; }

        public Profile(string name)
        {
            Name = name;
            Friends = new List<Profile>();
        }

        public void AddToFriendList(Profile user)
        {
            Friends.Add(user);
        }

        public void RemoveFromFriendList(Profile user)
        {
            Friends.Remove(user);
        }

        public void ShowFriends()
        {
            foreach (Profile user in Friends)
            {
                Console.WriteLine(user.Name);
            }
        }

        public Profile GetRequestedFriend(string userInput)
        {
            return Friends.Find(x => x.Name == userInput);
        }
    }
}
