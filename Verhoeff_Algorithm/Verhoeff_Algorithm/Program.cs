using System;

namespace Verhoeff_Algorithm
{
    class Program
    {
        static readonly int[,] verhoeffTableD = new int[,]
        {
            {0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
            {1, 2, 3, 4, 0, 6, 7, 8, 9, 5},
            {2, 3, 4, 0, 1, 7, 8, 9, 5, 6},
            {3, 4, 0, 1, 2, 8, 9, 5, 6, 7},
            {4, 0, 1, 2, 3, 9, 5, 6, 7, 8},
            {5, 9, 8, 7, 6, 0, 4, 3, 2, 1},
            {6, 5, 9, 8, 7, 1, 0, 4, 3, 2},
            {7, 6, 5, 9, 8, 2, 1, 0, 4, 3},
            {8, 7, 6, 5, 9, 3, 2, 1, 0, 4},
            {9, 8, 7, 6, 5, 4, 3, 2, 1, 0}
        };

        static readonly int[,] verhoeffTableP = new int[,]
        {
            {0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
            {1, 5, 7, 6, 2, 8, 3, 0, 9, 4},
            {5, 8, 0, 3, 7, 9, 6, 1, 4, 2},
            {8, 9, 1, 6, 0, 4, 3, 5, 2, 7},
            {9, 4, 5, 3, 1, 2, 6, 8, 7, 0},
            {4, 2, 8, 6, 5, 7, 3, 9, 0, 1},
            {2, 7, 9, 3, 8, 0, 6, 4, 1, 5},
            {7, 0, 4, 6, 9, 1, 3, 2, 5, 8}
        };

        static readonly int[] verhoeffTableInv = {0, 4, 3, 2, 1, 5, 6, 7, 8, 9};

        static void Main()
        {
            Console.Write("Введите номер для проверки: ");
            string num = Console.ReadLine();

            Console.WriteLine(new string('-', 32));

            if (ValidateNumber(num))
                Console.WriteLine("Номер валиден");
            else
                Console.WriteLine("Номер не валиден");

            Console.WriteLine($"Контрольная цифра: {GetCheckNumber(num)}");

            Console.ReadKey();
        }

        static bool ValidateNumber(string num)
        {
            int x = 0;
            int[] numArray = new int[num.Length];

            for (var i = 0; i < num.Length; i++)
                numArray[i] = int.Parse(num.Substring(i, 1));

            Array.Reverse(numArray);

            for (var i = 0; i < numArray.Length; i++)
                x = verhoeffTableD[x, verhoeffTableP[(i % 8), numArray[i]]];

            return x == 0;
        }

        static string GetCheckNumber(string num)
        {
            int x = 0;
            int[] numArray = new int[num.Length];

            for (var i = 0; i < num.Length; i++)
                numArray[i] = int.Parse(num.Substring(i, 1));

            Array.Reverse(numArray);

            for (var i = 0; i < numArray.Length; i++)
                x = verhoeffTableD[x, verhoeffTableP[((i + 1) % 8), numArray[i]]];

            return verhoeffTableInv[x].ToString();
        }
    }
}
