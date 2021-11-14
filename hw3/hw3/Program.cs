using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;

            Console.WriteLine("Введите число и узнайте, чему равно знвчение функции №24 от этого числа!!!");
            x = Double.Parse(Console.ReadLine());
            Console.WriteLine("y = " + Function24(x));
            Console.ReadKey();
        }

        private static double Function24(double x)
        {
            return Math.Abs((2 - Math.Log10(x)) / Math.Pow(Math.Tan(x), 2));
        }
    }
}