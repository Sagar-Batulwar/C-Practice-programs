using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Security;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter operation to perform: " +
                "\n 1.Add" +
                "\n 2.Sub" +
                "\n 3.Mul" +
                "\n 4.Div" +
                "\n Choose option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Add(num1, num2);
                    break;
                case 2:
                    Sub(num1, num2);
                    break;
                case 3:
                    Mul(num1, num2);
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannon divide by 0");
                    }
                    else
                    {
                        Div(num1, num2);
                    }
                        break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }
            
        }
        static void Add(int a, int b)
        {
            Console.WriteLine($"Addition of {a} & {b} is {a+b}");
        }
        static void Sub(int a, int b)
        {
            Console.WriteLine($"Subtraction of {a} & {b} is {a-b}");
        }
        static void Mul(int a, int b)
        {
            Console.WriteLine($"Multiplication of {a} & {b} is {a*b}");
        }
        static void Div(int a, int b)
        {
            Console.WriteLine($"Division of {a} & {b} is {a/b}");
        }

    }
}
