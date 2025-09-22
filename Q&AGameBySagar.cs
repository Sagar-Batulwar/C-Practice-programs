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

            //question1
            int score = 0;
            bool running = true;
            
            while (running)
            {
                Console.WriteLine("\n\n" +
                    "------Welcome To Quiz Game By Sagar------\n");

                Console.Write("Lets start with\n" +
                    "Question no 1\n\n" +
                    "Which bike brand is indian?\n" +
                    "a.Honda, b.Tvs, c.Suzuki\n" +
                    "Choose option: ");
                string inputq1 = Console.ReadLine();
                if (inputq1 == "a" || inputq1 == "b" || inputq1 == "c")
                {
                    switch (inputq1)
                    {
                        case "b":
                            Console.WriteLine("Correct answer.");
                            score+=1;
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Wrong answer, correct one is b.Tvs");
                            running = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Choose only a,b or c");
                }
            }


            //Question2
            while (running == false)
            {
                Console.Write("\n\nQuestion no 2\n\n" +
                   "Which car is japanes?\n" +
                   "a.Honda, b.Tata, c.Mahindra\n" +
                   "Choose option: ");
                string inputq2 = Console.ReadLine();

                if (inputq2 == "a" || inputq2 == "b" || inputq2 == "c")
                {
                    switch (inputq2)
                    {
                        case "a":
                            Console.WriteLine("Correct answer.");
                            score+=1;
                            running = true;
                            break;
                        default:
                            Console.WriteLine("Wrong! Coreect answer is a.Honda");
                            running = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Choose only a,b or c");
                }
            }


            //Question3

            while (running)
            {
                Console.Write("\n\nQuestion no 3\n\n" +
                "Most luxury smartphone brand ?\n" +
                "a.Redmi, b.Vivo, c.Apple\n" +
                "Choose option: ");
                string inputq3 = Console.ReadLine();

                if (inputq3 == "a" || inputq3 == "b" || inputq3 == "c")
                {
                    switch (inputq3)
                    {
                        case "c":
                            Console.WriteLine("Correct answer.");
                            score+=1;
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Wrong! Coreect answer is c.Apple");
                            running = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Choose only a,b or c");
                }
            }

            //Question4
            while (running == false)
            {
                Console.Write("\n\nQuestion no 4\n\n" +
                   "Which is gaming laptop\n" +
                   "a.AsusROG, b.Lenovobook, c.HPbook\n" +
                   "Choose option: ");
                string inputq2 = Console.ReadLine();

                if (inputq2 == "a" || inputq2 == "b" || inputq2 == "c")
                {
                    switch (inputq2)
                    {
                        case "a":
                            Console.WriteLine("Correct answer.");
                            score+=1;
                            running = true;
                            break;
                        default:
                            Console.WriteLine("Wrong! Coreect answer is a.Honda");
                            running = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Choose only a,b or c");
                }
            }


            //final score

            Console.WriteLine($"\n------Game Ended------" +
                $"\nYour final score is {score}");

        }
    }
}
