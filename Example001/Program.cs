using System.Security.Cryptography;
using System.Data;
//using Internal;
using System;

namespace Example001
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           /*Console.WriteLine("Как тебя зовут?");
           string username = Console.ReadLine();
           Console.WriteLine("Привет,");
           Console.WriteLine(username);*/
           int s = new Random().Next(20,80);
           int a = 5;
           int b = 54;
           int result = a+b*s;
           Console.WriteLine(result);
        }
    }
}
