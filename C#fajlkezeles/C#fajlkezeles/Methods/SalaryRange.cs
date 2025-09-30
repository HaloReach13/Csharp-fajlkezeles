using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_fajlkezeles.Methods
{
    public class SalaryRange
    {
        public static void Salaryrange(string fileName)
        {
            var records = Methods.ReadRecords.ReadFromFile(fileName);

            Console.Write("Lower bound: ");
            int lower = int.Parse(Console.ReadLine());

            Console.Write("Upper bound: ");
            int upper = int.Parse(Console.ReadLine());

            var matches = records.Where(r => r.Salary >= lower && r.Salary <= upper);
            foreach (var item in matches)
            {
                Console.WriteLine($"{item.Name} - {item.Salary}");
            }
        }
    }
}
