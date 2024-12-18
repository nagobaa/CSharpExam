using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating a dictionary
            Dictionary<string, string> Items = new Dictionary<string, string>();
            
            //creating the while-loop
            while (true)
            {
                //menu
                Console.WriteLine("1. Add an item and its definition");
                Console.WriteLine("2. Remove an item");
                Console.WriteLine("3. Show all items and their definitions");
                Console.WriteLine("4. Exit");

                //asking the user for choice
                Console.Write("Please enter number: ");
                string UserInput = Console.ReadLine();

                //converting string datatype to integer
                int choice = Convert.ToInt32(UserInput);

                //choice 1
                if (choice == 1)
                {
                    Console.Write("What is the item? ");
                    string item = Console.ReadLine();

                    //if the item already exists
                    if(Items.ContainsKey(item))
                    {
                        while (true)
                        {
                            Console.Write("This item already exists. Do you want to overwrite it? (yes / no) ");
                            string choice1 = Console.ReadLine();

                            //the user chooses 'yes'
                            if (choice1 == "yes")
                            {
                                //the user enters the description
                                Console.Write("What is its description? ");
                                string description = Console.ReadLine();

                                //adding key (item) and value (descrption) to the dictionary
                                Items.Add(item, description);
                                break;
                            }
                            //the user chooses 'no'
                            else if (choice1 == "no")
                            {
                                //the loop for asking 'yes' or 'or' no is broken
                                break;
                            }
                            //neither 'yes' nor 'no'
                            else
                            {
                                //the user has to either write 'yes' or 'no'
                                Console.WriteLine("Please choose either 'yes' or 'no'");
                            }
                        }
                    }
                    else
                    {
                    Console.Write("What is its description? ");
                    string description = Console.ReadLine();

                    //adding key (item) and value (descrption) to the dictionary
                    Items.Add(item, description);
                    }
                }
                //choice 2
                else if (choice == 2)
                {
                    //asking the user what item to remove
                    Console.Write("What is the item to be removed? ");
                    string key = Console.ReadLine();

                    //the item exists
                    if (Items.ContainsKey(key))
                    {
                        //removal of item
                        Items.Remove(key);

                        //confirmation message
                        Console.WriteLine("The item is removed");
                    }
                    //the item does not exist
                    else
                    {
                        //informatning the user item not existing
                        Console.WriteLine("Item not found");
                    }
                                       
                }
                //choice 3
                else if (choice == 3)
                {
                    //all items and their descriptions
                    foreach (var x in Items)
                        Console.WriteLine($"Item: {x.Key} Description: {x.Value}");
                }
                //choice 4
                else if (choice == 4)
                {
                    //exiting the program
                    break;
                }
                else
                {
                    //informing the user of choosing something else than 1-4
                    Console.WriteLine("Invalid output");
                }
            }
        }
    }
}
