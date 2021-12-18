using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите необходимое количество чисел в массиве");

            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                PrintWithDivision("Отрицательная длина массива! Какая подлость!");
                Console.ReadKey();
                return;
            }

            PrintWithDivision("Введите два целых числа в диапазоне от -20 до 20");
            Console.WriteLine("(первое число должно быть меньше второго)");
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if ((Math.Abs(a) > 20) || (Math.Abs(b) > 20))
            {
                PrintWithDivision("Как минимум одно из чисел находится вне допустимого диапазона");
                Console.ReadKey();
                return;
            }

            if (a >= b)
            {
                PrintWithDivision("Что непонятного в фразе \"первое число должно быть меньше второго\"?");
                Console.ReadKey();
                return;
            }

            int[] array = new int[n];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(a, b);

            //метод вывода элементов массива целыхна консоль через запятую
            PrintArray(array);

            //метод, меняющий знак каждого элемента массива
            PrintArray(ChangeArraySigns(array));

            //метод, вычисляющий квадратный корень из суммы квадратов элементов массива
            PrintWithDivision($"Квадратный корень из суммы квадратов: {GetRootFromSumOfSquares(array)}");

            //метод, получающий массив факториалов модулей элементов исходного массива
            PrintArray(GetArrayOfFactorials(array));

            Console.ReadKey();
        }

        static void PrintWithDivision(string text)
        {
            Console.WriteLine(new string('-', 32));
            Console.WriteLine(text);
            return;
        }

        static void PrintArray(int[] array)
        {
            PrintWithDivision(String.Join(", ", array));
            return;
        }

        static int[] ChangeArraySigns(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = -array[i];

            return array;
        }

        static double GetRootFromSumOfSquares(int[] array)
        {
            double x = 0.0;

            for (int i = 0; i < array.Length; i++)
                x += array[i] * array[i];

            return Math.Sqrt(x);
        }

        static int[] GetArrayOfFactorials(int[] array)
        {
            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = 1;

                for (int j = 1; j <= Math.Abs(array[i]); j++)
                    newArray[i] *= j;
            }

            return newArray;
        }
    }
}
