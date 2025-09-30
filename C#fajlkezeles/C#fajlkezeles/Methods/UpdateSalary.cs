using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_fajlkezeles.Methods
{
    public class UpdateSalary
    {
        public static void Updatesalary(string fileName)
        {
            var records = Methods.ReadRecords.ReadFromFile(fileName);

            Console.Write("Enter the code of the record to modify: ");
            int code = int.Parse(Console.ReadLine());

            var record = records.FirstOrDefault(r => r.Code == code);
            if (record == null)
            {
                Console.WriteLine("No such record!");
                return;
            }

            Console.Write("New salary: ");
            int newSalary = int.Parse(Console.ReadLine());
            record.Salary = newSalary;

            File.WriteAllLines(fileName, records.Select(r => r.ToString()));
            Console.WriteLine("Salary updated!");
        }
    }
}
