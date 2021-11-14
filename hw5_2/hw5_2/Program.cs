using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("А теперь - смертельный трюк под куполом цирка!");
            var inputWord = "парапсихолог";
            Console.WriteLine($"Мановением руки {inputWord} превращается в...");
            var outputWord1 = "" + inputWord[0] + inputWord[6] + inputWord[2] + inputWord.Substring(10, 2);
            var outputWord2 = "" + inputWord[7] + inputWord.Substring(2, 3);
            Console.WriteLine($"...{outputWord1} и {outputWord2}");
            Console.ReadLine();
        }
    }
}