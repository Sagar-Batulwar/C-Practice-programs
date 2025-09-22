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
            bool running = true;

            while (running)
            {

                Console.Write("Enter first number: ");
                string input1 = Console.ReadLine();

                Console.Write("Enter second number: ");
                string input2 = Console.ReadLine();

                if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
                {
                    Console.Write("What operation you want to perform: \n" +
                    "1.Addition\n" +
                    "2.Substraction\n" +
                    "3.Multiplication\n" +
                    "4.Division\n" +
                    "Choose option: ");

                    string input3 = Console.ReadLine();
                    int option = int.Parse(input3);

                    if (option == 1)
                    {
                        int answer = num1 + num2;
                        Console.WriteLine($"The answer for {num1} + {num2} is {answer}");
                        running = false;
                    }
                    else if (option == 2)
                    {
                        int answer = num1 - num2;
                        Console.WriteLine($"The answer for {num1} - {num2} is {answer}");
                        running = false;
                    }
                    else if (option == 3)
                    {
                        int answer = num1 * num2;
                        Console.WriteLine($"The answer for {num1} x {num2} is {answer}");
                        running = false;
                    }
                    else if (option == 4)
                    {
                        int answer = num1 / num2;
                        Console.WriteLine($"The answer for {num1} / {num2} is {answer}");
                        running = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entery ! choose valid option");
                    }
                }
                else
                {
                    Console.WriteLine("Enter Valid Number! Enter Number Only !");
                }
            }

        }
    }
}
