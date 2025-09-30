using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_fajlkezeles.Class;

namespace C_fajlkezeles.Methods
{
    public class ReadRecords
    {
        public static List<Record> ReadFromFile(string fileName)
        {
            List<Record> records = new List<Record>();
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 4)
                    {
                        int code = int.Parse(parts[0]);
                        string name = parts[1];
                        DateTime birthDate;
                        if (!DateTime.TryParse(parts[2], out birthDate))
                        {
                            throw new Exception("Invalid format!");
                        }
                        double salary = double.Parse(parts[3].Replace("Ft", ""));
                        Record record = new Record(code, name, birthDate, salary);
                        records.Add(record);
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect line: {line}");
                    }
                }
            }
            return records;
        }
    }
}
