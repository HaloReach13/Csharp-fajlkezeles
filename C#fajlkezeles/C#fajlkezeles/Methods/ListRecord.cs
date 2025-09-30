using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_fajlkezeles.Methods
{
    public class ListRecord
    {
        public static void Listrecords(string fileName)
        {
            var records = Methods.ReadRecords.ReadFromFile(fileName);
            foreach (var record in records)
            {
                Console.WriteLine(record.ToString());
            }
        }
    }
}
