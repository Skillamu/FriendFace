namespace FriendFace
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myProfile = new Profile("Åmund");

            List<Profile> allProfiles = new List<Profile>();
            allProfiles.Add(new Profile("Alex"));
            allProfiles.Add(new Profile("Emma"));
            allProfiles.Add(new Profile("Jennie"));

            myProfile.AddFriend(allProfiles[1]);

            myProfile.PrintFriends();

            myProfile.RemoveFriend(allProfiles[1]);

            myProfile.PrintFriends();

            Console.ReadLine();
        }
    }
}
