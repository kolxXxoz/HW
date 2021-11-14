using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введиты координату по x");
            var x = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введиты координату по y");
            var y = Double.Parse(Console.ReadLine());

            Console.WriteLine(IsInDom(x, y));

            Console.ReadKey();
        }

        static bool IsInDom(double x, double y)
        {
            return ((x >= 2) && (y >=0)) || ((x >= 1) && (y <= -1));
        }
    }
}
