using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modules_12._1._5
{
    internal class User
    {
        public string Login { get; private set; }
        public string Name { get; private set; }
        public bool IsPremium { get; private set; }
        public User(string login, string name, bool isPrime = false)
        {
            Login = login;
            Name = name;
            IsPremium = isPrime;
        }
        public  void ShowAds()
        {
            Console.WriteLine($"{Name}Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine($"{Name} Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine($"{Name} Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
