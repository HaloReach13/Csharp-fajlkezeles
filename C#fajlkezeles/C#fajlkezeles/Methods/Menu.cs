using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_fajlkezeles.Methods;

namespace C_fajlkezeles.Methods
{
    public class Menu
    {
        public static void menu(string fileName)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- MENU ---");
                Console.WriteLine("1. Add new record");
                Console.WriteLine("2. List all records");
                Console.WriteLine("3. Modify salary");
                Console.WriteLine("4. Query salary range");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": 
                        Methods.NewRecord.WriteToFile(fileName);
                        break;
                    case "2":
                        Methods.ListRecord.Listrecords(fileName);
                        break;
                    case "3": 
                        Methods.UpdateSalary.Updatesalary(fileName);
                        break;
                    case "4": 
                        Methods.SalaryRange.Salaryrange(fileName);
                        break;
                    case "0":
                        Console.WriteLine("Goodbye!");
                        return;
                    default: 
                        Console.WriteLine("Invalid choice!"); 
                        break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadLine();
            }
        }
    }
}
