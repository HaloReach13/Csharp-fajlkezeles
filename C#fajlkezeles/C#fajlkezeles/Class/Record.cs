using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_fajlkezeles.Class
{
    public class Record
    {
        public int code;
        public string name;
        public DateTime birthDate;
        public double salary;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Record(int code, string name, DateTime birthDate, double salary)
        {
            Code = code;
            Name = name;
            BirthDate = birthDate;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Code};{Name};{BirthDate.ToString("yyyy-MM-dd")};{Salary}Ft";
        }
    }
}
