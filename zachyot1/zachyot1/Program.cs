using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachyot1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");

            int x = int.Parse(Console.ReadLine());
            int xClone = x;
            int count = 0;

            string answer = $"{x} = ";

            for (var i = 2; i <= x / 2; i++)
                if (IsPrime(i))
                {
                    while (xClone % i == 0)
                    {
                        xClone /= i;
                        count++;
                    }

                    if (count == 0)
                        continue;

                    else if (count == 1)
                        answer += $"{i} * ";

                    else
                        answer += $"{i}^{count} * ";

                    xClone = x;
                    count = 0;
                }

            if (IsPrime(x))
                Console.WriteLine($"{x} - простое число");
            
            else
                Console.WriteLine(answer.Remove(answer.Length - 1).Remove(answer.Length - 2).Remove(answer.Length - 3));

            Console.ReadKey();
        }

        static bool IsPrime(int x)
        {
            var answer = true;

            for (var i = 2; i <= x / 2; i++)
                if (x % i == 0)
                    return !answer;

            return answer;
        }
    }
}
