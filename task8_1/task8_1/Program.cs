using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите натуральное число k");
            int k = int.Parse(Console.ReadLine());

            double summa = 1;

            for (double i = 1.0; i < k; i++)
                summa += Math.Pow(n, 1 / i);

            Console.WriteLine($"x = {summa}");

            Console.ReadKey();
        }
    }
}