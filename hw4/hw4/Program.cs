using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Результат вычисления формулы №24 - {Math.Round((Formula24(5) + Formula24(7) + Formula24(11)) / Formula24(13), 3)}");
            Console.ReadKey();
        }

        static double Formula24(double x)
        {
            return 1 + Math.Cos(Math.PI / x);
        }
    }
}
