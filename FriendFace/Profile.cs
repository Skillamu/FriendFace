using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    public class Profile
    {
        private List<Profile> Friends { get; set; }
        public string Name { get; private set; }

        public Profile(string name)
        {
            Name = name;
        }

        public void AddFriend(Profile profile)
        {
            Friends = new List<Profile>();
            Friends.Add(profile);
        }

        public void RemoveFriend(Profile profile)
        {
            int index = Friends.FindIndex(friend => friend.Name == profile.Name);
            if (index != -1)
            {
                Friends.RemoveAt(index);
            }
        }

        public void PrintFriends()
        {
            foreach (var friend in Friends)
            {
                Console.WriteLine(friend.Name);
            }
        }
    }
}
