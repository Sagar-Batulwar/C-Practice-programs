using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;



namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students entries you wanna do:");
            int entryFinal = 0;
            
            while (!int.TryParse(Console.ReadLine(), out entryFinal) || entryFinal <= 0)
            {
                Console.Write("Wrong input. Enter again:");
            }

            string[] name = new string[entryFinal];
            int[] marks = new int[entryFinal];

            for (int i = 0; i < entryFinal; i++)
            {
                Console.Write("Enter name:");

                while (true)
                {
                    name[i] = Console.ReadLine();
                    if (name[i] == "" || int.TryParse(name[i], out _))
                    {
                        Console.Write("Enter valid name:");
                    }
                    else
                    {
                        break;
                    }
                }

                Console.Write("Enter marks:");
                marks[i] = 0;
                while (!int.TryParse(Console.ReadLine(), out marks[i]) || marks[i] < 0)
                {
                    Console.WriteLine("Enter valid marks:");
                }
            }

            
            bool run = true;
            while (run)
            {

                Console.Write("\n-----Menu-----" +
               "\n1.Show all students and marks" +
               "\n2.Find highest and lowest marks" +
               "\n3.Calculate average marks" +
               "\n4.Search student by name" +
               "\n5.Exit" +
               "\nChoose Option:");

                string option = Console.ReadLine();
                switch(option)
                {
                    case "1":
                        for (int i = 0; i < entryFinal; i++)
                        {
                            Console.WriteLine($"name: {name[i]} & marks: {marks[i]}");
                        }
                        break;

                    case "2":
                        int maxMarks = marks.Max();
                        int indexmax = Array.IndexOf(marks, maxMarks);
                        Console.WriteLine($"Highest: {name[indexmax]} - {marks[indexmax]}");

                        int minMarks = marks.Min();
                        int indexmin = Array.IndexOf(marks, minMarks);
                        Console.WriteLine($"Lowest: {name[indexmin]} - {marks[indexmin]}");
                        break;

                    case "3":
                        int add = 0;
                        for (int i = 0; i < entryFinal; i++)
                        {
                            add += marks[i];
                        }
                        int avg = add / entryFinal;
                        Console.WriteLine($"Avg marks are {avg}");
                        break;

                    case "4":
                        Console.WriteLine("Enter name to search: ");
                        string search = Console.ReadLine();
                        bool found = false;
                        for (int i = 0; i < entryFinal; i++)
                        {
                            if(search == name[i])
                            {
                                Console.WriteLine($"Name:{name[i]}-{marks[i]}");
                                found = true;
                            }
                        }
                        if(found != true)
                        {
                            Console.WriteLine("Not found!");
                        }
                        break;

                    case "5":
                        run = false;
                        Console.WriteLine("Exiting program Bye... :)");
                        break;

                    default: Console.WriteLine("Incorrect input. Try again:");
                        break;
                    
                }
            }

        }
    }
}
