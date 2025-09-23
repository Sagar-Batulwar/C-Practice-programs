using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices.ComTypes;
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
            bool running = true;

            List<string> toDoList = new List<string>();

            while (running)
            {
               

                Console.WriteLine("\n-----TO-DO LIST-----");
                Console.WriteLine("1. View tasks");
                Console.WriteLine("2. Add task");
                Console.WriteLine("3. Remove task");
                Console.WriteLine("4. Mark tasks as done");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string option = Console.ReadLine();
                bool status = false;
                switch (option)
                {
                    case "1":
                        if (toDoList.Count == 0)
                        {
                            Console.WriteLine("No tasks. Add task!");
                        }
                        else
                        {
                            string taskStatus;
                            
                            for (int i = 0; i < toDoList.Count; i++)
                            {
                                if (status)
                                {
                                    taskStatus = "[Done]";
                                }
                                else
                                {
                                    taskStatus = "[Not Done]";
                                }
                                Console.WriteLine(i+1 + toDoList[i] + " Status: " + taskStatus);
                            }
                        }
                        break;

                    case "2":
                        Console.Write("Enter your task to add: ");
                        string task = Console.ReadLine();
                        if (!task.Equals("") && !int.TryParse(task, out _))
                        {
                            toDoList.Add(task);
                            Console.WriteLine("task added:)");
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry!");
                        }
                        break;

                    case "3":
                        Console.Write("Enter task name to remove: ");
                        string removeTask = Console.ReadLine();
                        if (toDoList.Contains(removeTask))
                        {
                            toDoList.Remove(removeTask);
                            Console.WriteLine($"Task {removeTask} removed successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Task not found.");
                        }
                            break;

                    case "4":
                        Console.Write("Enter task no. to mark done: ");
                        string taskNo = Console.ReadLine();
                        int taskNoFinal = 0;

                        if (taskNo != "" && int.TryParse(taskNo, out taskNoFinal)
                        {
                            for (int i = 0; i < toDoList.Count; i++)
                            {
                                if (taskNoFinal == i)
                                {
                                    status = true;
                                    Console.WriteLine("Task marked as done.");
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry!");
                        }


                            break;

                    case "5":
                        running = false;
                        Console.WriteLine("Ok Bye ! Exiting the app...");
                        break;

                    default:
                        Console.WriteLine("Invalid entry.");
                        break;
                }
           
            }   
        }
    }
}
