using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите желаемое количество чисел");

            int n = int.Parse(Console.ReadLine());

            Console.Write($"a1 = ");
            
            double summa = double.Parse(Console.ReadLine());
            double temp = summa;

            for (var i = 1; i < n; i++)
            {
                Console.Write($"a{i+1} = ");
                temp *= double.Parse(Console.ReadLine());
                summa += temp;
            }

            Console.WriteLine($"x = {summa}");

            Console.ReadKey();
        }
    }
}
