using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст (кириллицей), чтобы приятно удивиться!");

            var text = Console.ReadLine();
            Console.WriteLine(TranslateToCS(text));

            Console.ReadKey();
        }

        static string TranslateToCS(string text)
        {
            string[] rusUp = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };
            string[] rusLow = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            string[] csAlphabet = { "A", "6", "B", "r", "D", "E", "E", "}|{", "3", "u", "u*", "K", "JL", "M", "H", "O", "n", "P", "C", "T", "Y", "cp", "X", "L|", "4", "LL|", "LLL", "`b", "bI", "b", "-)", "IO", "9I" };

            for (int i = 0; i <= 32; i++)
            {
                text = text.Replace(rusUp[i], csAlphabet[i]);
                text = text.Replace(rusLow[i], csAlphabet[i]);
            }
            
            return text;
        }
    }
}
