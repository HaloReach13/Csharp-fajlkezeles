using C_fajlkezeles.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_fajlkezeles
{
    public class Program
    {
        static string fileName = "records.txt";

        static void Main(string[] args)
        {
            Methods.Menu.menu(fileName);

            Console.ReadKey();
        }
    }
}
