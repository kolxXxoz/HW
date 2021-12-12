using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа (второе должно быть больше первого)");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int summaFinal = int.MaxValue;
            int result = a;
            int summa;

            for (var i = a; i < b; i++)
            {
                summa = 0;
                
                for (var j = 2; j < i / 2; j++)
                    if ((i % j == 0) && (j % 2 != 0))
                        summa += j;

                if (summa < summaFinal)
                {
                    summaFinal = summa;
                    result = i;
                }
            }

            Console.WriteLine($"x = {result}");

            Console.ReadKey();
        }
    }
}
