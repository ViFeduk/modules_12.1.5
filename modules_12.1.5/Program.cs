namespace modules_12._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>() 
            { new User("lol", "Игорь"), 
                new User("kol", "Лёха", true)
            };
            ShowAdvertising(users);

        }
        static void ShowAdvertising(List<User> users)
        {
            foreach (var user in users)
            {
                if (!user.IsPremium)
                {
                    user.ShowAds();
                }
            }
        }
    }
}
