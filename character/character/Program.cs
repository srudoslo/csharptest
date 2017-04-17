using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace character
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = Char.MinValue;
            int charMax = Char.MaxValue;
            Char myVar = 'G';
            int myVarvalue = 'G';
            Console.WriteLine("Min Char = {0} Max char = {1} My character = {2} my variable Number {3}", charMin, charMax, myVar,myVarvalue);
            Console.ReadKey();
        }
    }
}
