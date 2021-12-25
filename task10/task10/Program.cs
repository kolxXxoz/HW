using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива, используя числа от 5 до 20");

            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] array = new int[m, n];
            Random rand = new Random();

            for (var i = 0; i < array.GetLength(0); i++)
                for (var j = 0; j < array.GetLength(1); j++)
                    array[i, j] = rand.Next(0, 99);

            PrintArray(array);

            PrintWithDivision("Введите искомое число");
            int x = int.Parse(Console.ReadLine());
            GetNumberIndexes(array, x);

            Console.WriteLine(new string('-', 32));
            GetMultiOfEven(array);

            Console.ReadKey();
        }

        static void PrintWithDivision(string text)
        {
            Console.WriteLine(new string('-', 32));
            Console.WriteLine(text);
            return;
        }

        static void PrintArray(int[,] array)
        {
            PrintWithDivision("Массив:");
            
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + "\t");

                Console.WriteLine();
            }

            return;
        }

        static void GetNumberIndexes(int[,] array, int x)
        {
            for (var i = 0; i < array.GetLength(0); i++)
                for (var j = 0; j < array.GetLength(1); j++)
                    if (array[i, j] % x == 0)
                    {
                        Console.WriteLine($"Один из элементов, которые делятся без остатка на {x}, находится в {i + 1} строке {j + 1} столбце");
                        return;
                    }

            Console.WriteLine($"Элемента, который делится без остатка на {x}, нет в массиве");
            return;
        }

        static void GetMultiOfEven(int[,] array)
        {
            int x;
            
            for (var i = 0; i < array.GetLength(1); i++)
            {
                x = 1;
                
                for (var j = 0; j < array.GetLength(0); j++)
                    if (array[j, i] % 2 == 0)
                        x *= array[j, i];

                if (x == 1)
                    Console.WriteLine($"В {i + 1} столбце нет чётных элементов");
                else
                    Console.WriteLine($"Произведение чётных элементов в {i + 1} столбце равно {x}");
            }

            return;
        }
    }
}
