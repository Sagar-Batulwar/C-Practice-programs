using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            int ageFinal = Convert.ToInt32(age);

            Console.Write("Enter your city: ");
            string city = Console.ReadLine();

            Console.WriteLine($"Your name is {name} and age is {age} and you are from {city}.");
        }
    }
}

