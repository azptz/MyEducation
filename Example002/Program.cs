using System;

namespace Example002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, как тебя зовут?");
            string username = Console.ReadLine();
            if(username.ToLower() == "миша")
            {
                Console.WriteLine("Ура, это же Миша!");
            }
            else
            {
                Console.WriteLine("Привет, ", username);
            }
        }
    }
}
