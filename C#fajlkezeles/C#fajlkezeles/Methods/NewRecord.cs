using C_fajlkezeles.Class;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_fajlkezeles.Methods
{
    public class NewRecord
    {
        public static void WriteToFile(string fileName)
        {
            Console.Write("Code (3 digits): ");
            int code = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Birth date (yyyy-MM-dd): ");
            string inputDate = Console.ReadLine();
            DateTime birthDate;
            while (!DateTime.TryParse(inputDate, out birthDate))
            {
                Console.Write("Invalid format! Try again: ");
                inputDate = Console.ReadLine();
            }

            Console.Write("Salary: ");
            int salary = int.Parse(Console.ReadLine());

            var newRecord = new Record(code, name, birthDate, salary);
            File.AppendAllText(fileName, "\n" + newRecord.ToString());

            Console.WriteLine("Record successfully added!");
        }
    }
}
