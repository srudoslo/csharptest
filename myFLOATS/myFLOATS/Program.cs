using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFLOATS
{
    class Program
    {
        static void Main(string[] args)
        {
            float flMin = float.MinValue;
            float flMax = float.MaxValue;
            Console.WriteLine("min Value = {0}Max Val = {1}", flMin, flMax);
            Console.ReadKey();

            float flVar = 1f / 3;
            double dlVar = 1D / 3;
            decimal dcVar = 1M / 3;

            Console.WriteLine("\nfloat value = {0}\ndoubel value ={1}\ndeciaml value ={2}",flVar, dlVar, dcVar);
            Console.ReadKey();








        }
    }
}
