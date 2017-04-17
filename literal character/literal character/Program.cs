using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace literal_character
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar     = -100;
            uint myuVar   = 1000u;
            float myflvar = 1.5f;
            double mydvar = 100.5;
            decimal mydecvar = 100.5m;
            Console.WriteLine("{0}{1}", myVar, myuVar);
            Console.WriteLine($"{mydecvar}{mydvar}");
            Console.ReadKey();
        }
    }
}
