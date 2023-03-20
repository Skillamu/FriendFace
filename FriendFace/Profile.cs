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
        public List<Profile> Friends { get; private set; }

        public Profile(string name)
        {
            Name = name;
            Friends = new List<Profile>();
        }
    }
}
