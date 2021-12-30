using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherCeasar
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine().ToUpper();

            Console.Write("Введите числовой ключ: ");
            int key = int.Parse(Console.ReadLine());

            string cipher = Encrypt(text, key);
            Console.WriteLine(cipher);
            
            Console.WriteLine(Decrypt(cipher, key));

            Console.ReadKey();
        }

        static string Encrypt(string text, int key)
        {
            string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            var alphabetLenght = alphabet.Length;
            var cipher = "";

            for (int i = 0; i < text.Length; i++)
            {
                var index = alphabet.IndexOf(text[i]);

                if (index < 0)
                    cipher += text[i];

                else
                {
                    var newIndex = (alphabetLenght + index + key) % alphabetLenght;
                    cipher += alphabet[newIndex];
                }
            }

            return cipher;
        }

        static string Decrypt(string text, int key)
        {
            return Encrypt(text, -key);
        }
    }
}


