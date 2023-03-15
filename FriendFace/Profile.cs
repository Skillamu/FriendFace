using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    public class Profile
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public string From { get; private set; }

        public Profile(string firstName, string lastName, int age, string from)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            From = from;
        }

        public void AddFriend()
        {

        }

        public void RemoveFriend()
        {

        }

        public void ShowFriends()
        {

        }
    }
}
