using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число k");
            var k = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число m");
            var m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число n");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(Logic24(k, m, n));

            Console.ReadKey();
        }

        static bool Logic24(int k, int m, int n)
        {
            return (k % 2 == 0) && (m % 2 == 0) && (n % 2 == 0) && ((k <= m) || (m > n));
        }
    }
}
