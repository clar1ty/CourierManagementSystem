using System;
using System.Collections.Generic;

namespace CourierManagementSystem
{
    class Program
    {
        //main interface
        static void Main(string[] args)
        {
            

            do
            {
                Console.WriteLine("Welcome! What can I help you with?\n\n(a)View list of Couriers.\n(b)Create new courier profile.\n(c)Delete an existing account.\n(d)Exit program.");
                Console.Write("Your choice: ");
                var optionselected = Console.ReadLine().ToLower();
                Console.Clear();
                if (optionselected.Equals("a"))
                {
                    DisplayCourierList();
                    Console.WriteLine();
                    Console.WriteLine("Please press enter to return to main page.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (optionselected.Equals("b"))
                {
                    CreateNewProfile();
                    Console.WriteLine();
                    Console.WriteLine("Please press enter to return to main page.");
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (optionselected.Equals("c"))
                {
                    DeleteAnAccount();
                    Console.WriteLine();
                    Console.WriteLine("Please press enter to return to main page.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (optionselected.Equals("d"))
                {
                    Console.WriteLine("Thanks for visiting.");
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input. Please Try again.");
                    Console.ReadLine();
                    Console.Clear();
                    
                }
            } while (true);Console.Clear();
        }

        
        //method to display the list of couriers
        static void DisplayCourierList ()
        {
            var couriers = new List<string>() 
            {"Name\t Age\t Proficiency\n",
             "Moriarty 26\t Solid\n",
             "Holmes\t 26\t Solid\n",
             "Clarke\t 20\t AMateur\n"};
            foreach (var name in couriers)
            {
                Console.Write(name);
            }
        }
        //method to display interface for account creation
        static void CreateNewProfile ()
        {
            Console.WriteLine("Please fill all the data:");
            Console.Write("Name: ");
            var NewName = Console.ReadLine(); 
            Console.Write("Age: ");
            var NewAge = Console.ReadLine(); 
            Console.Write("Proficiency: ");
            Console.WriteLine();
            var NewProficiency = Console.ReadLine();
            Console.WriteLine("Account for "+NewName+ " age " + NewAge + " proficiency of "+NewProficiency+ " has been created successfully." );
            
        }
        //method to display interface for account deactivation
        static void DeleteAnAccount()
        {
            Console.Write("Input name of target account: ");
            var TargetName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Account for "+TargetName+" has been successfully deleted.");
        }
            
        }
    }

