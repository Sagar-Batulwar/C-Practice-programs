using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
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
            Dictionary<string, int> items = new Dictionary<string, int>();
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n----- Grocery Inventory -----");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Show All Items");
                Console.WriteLine("3. Update Quantity");
                Console.WriteLine("4. Remove Item");
                Console.WriteLine("5. Check Item Stock");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    while (running)
                    {
                        Console.Write("Groceries Name: ");
                        string itemName = Console.ReadLine();
                        if (!itemName.Equals("") && !int.TryParse(itemName, out _))
                        {
                            Console.Write("Enter item qty: ");
                            string inputQty = Console.ReadLine();

                            if (int.TryParse(inputQty, out int itemQty))
                            {
                                items[itemName] = itemQty;
                                Console.WriteLine("Data saved.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input. Enter qty.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input!");
                        }
                    }
                   
                }
                else if (input == "2")
                {
                    Console.WriteLine("====Available Stock====");
                    for (int i = 0; i < items.Count; i++)
                    {
                        var item = items.ElementAt(i);
                        Console.WriteLine($"Name: {item.Key} || Qty: {item.Value} ");
                        
                    }
                }
                else if (input == "3")
                {
                    while (true)
                    {
                        Console.Write("Enter item name to update: ");
                        string updateName = Console.ReadLine();

                        if (items.ContainsKey(updateName))
                        {
                            Console.Write("Update qty to: ");
                            string inputQty = Console.ReadLine();
                            if (int.TryParse(inputQty, out int updateQty) && updateQty >= 0)
                            {
                                items[updateName] = updateQty;
                                Console.WriteLine("Updated successfully.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Enter qty.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Item not found.");
                        }
                    }
                    
                }
                else if (input == "4")
                {
                    while (true)
                    {
                        Console.Write("Enter item name to remove: ");
                        string removeName = Console.ReadLine();

                        if (items.ContainsKey(removeName))
                        {
                            items.Remove(removeName);
                            Console.WriteLine("Item removed successfully!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Enter item name.");
                        }
                    }
                    
                }
                else if (input == "5")
                {
                    while (true)
                    {
                        Console.Write("Enter item name to check: ");
                        string itemCheck = Console.ReadLine();

                        if (items.ContainsKey(itemCheck))
                        {
                            Console.WriteLine("=====Search Result=====");
                            Console.WriteLine($"Name: {itemCheck} qty: {items[itemCheck]} ");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Enter name of the item.");
                        }
                    }
                   
                }
                else if (input == "6")
                {
                    running = false;
                    Console.WriteLine("Exiting the application. Bye...");
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }
        }
    }
}
