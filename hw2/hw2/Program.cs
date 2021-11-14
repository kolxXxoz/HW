using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sphereSquare, sphereValue;
            var sphereRadius = Convert.ToDouble(Console.ReadLine());
            sphereSquare = 4 * Math.PI * Math.Pow(sphereRadius, 2);
            sphereValue = 4 / 3 * Math.PI * Math.Pow(sphereRadius, 3);
            Console.WriteLine("Площадь сферы радиуса " + sphereRadius + " равна " + sphereSquare);
            Console.WriteLine("Объём шара радиуса " + sphereRadius + " равен " + sphereValue);
            Console.ReadKey();
        }
    }
}