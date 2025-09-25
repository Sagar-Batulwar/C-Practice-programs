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
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 0;
            bool run = true;
            while (run)
            {
                Console.Write("\n====Welcome To Bank OF Sagar====" +
                "\nChoose from the services;" +
                "\n1.Deposit Money" +
                "\n2.Withdraw Money" +
                "\n3.CheckBalance" +
                "\nChoose option 1 to 3: ");
                int option = int.Parse(Console.ReadLine());
                
                if (option == 1)
                {
                    Console.Write("Enter amount you want to deposit: ");
                    int money = int.Parse(Console.ReadLine());
                    Deposit(money, ref balance);

                }
                else if (option == 2)
                {
                    Console.Write("Enter money you want to withdraw: ");
                    int money = int.Parse(Console.ReadLine());
                    Withdraw(money, ref balance);
                   

                }
                else if (option == 3)
                {
                    Balance(ref balance);
                 
                }
                else
                {
                    Console.WriteLine("Invalid input");

                }
            }
            
        }
        static void Deposit(int money, ref int balance)
        {
            
            if (money > 0)
            {
                balance += money;
                Console.WriteLine($"\nRs.{money} added successfully:)");
                Console.WriteLine($"Your balance amount is Rs.{balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }
        static void Withdraw(int money, ref int balance)
        {
            if (money <= 0)
            {
                Console.WriteLine($"\nRs.{money} withdraw successfully");
                Console.WriteLine($"Your balance amount is Rs.{balance}");
            }
            else if (money > balance)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                balance -= money;
                Console.WriteLine($"Rs.{money} withdraw successfully");
                Console.WriteLine($"Your balance amount is Rs.{balance}");
            }
        }
        static void Balance(ref int balance)
        {
            Console.WriteLine($"Your balance amount is Rs.{balance}");
        }

    }
}
