using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");

            int n = int.Parse(Console.ReadLine());
            int i = 2;
            int summa = 1;

            while (n > 1)
            {
                if (n % (i * i) == 0)
                {
                    n /= i * i;
                    summa *= i * i;
                }

                else if (n % i == 0)
                    n /= i;

                else
                    i++;
            }

            Console.WriteLine($"x = {summa}");

            Console.ReadKey();
        }
    }
}
