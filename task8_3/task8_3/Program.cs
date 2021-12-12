using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите целые числа. Когда надоест просто введите 0");
            
            int a = 1;
            int summa = 0;
            int sign = -1;
            
            while (a != 0)
            {
                if (sign > 0)
                    sign = -1;

                else
                    sign = 1;
                
                a = int.Parse(Console.ReadLine());
                summa += Math.Sign(sign) * a;
            }

            Console.WriteLine($"x = {summa}");

            Console.ReadKey();
        }
    }
}
