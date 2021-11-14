using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine(Function24(x));
            Console.ReadKey();
        }

        static double Function24(double x)
        {
            if (x < 2)
                return Math.Log10(2 - x);
            else if (x > 3)
                return Math.Log10(x - 3);
            else return 1;
        }
    }
}
