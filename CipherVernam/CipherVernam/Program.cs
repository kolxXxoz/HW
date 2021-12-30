using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherVernam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine().ToUpper().Replace(" ", "");

            var key = GenerateKey(text);
            Console.WriteLine($"Ваш ключ: {key}");

            string cipher = Encrypt(text, key);
            Console.WriteLine(cipher);

            Console.WriteLine(Decrypt(cipher, key));

            Console.ReadKey();
        }

        static string GenerateKey(string text)
        {
            string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            var alphabetLenght = alphabet.Length;
            string key = "";
            Random rand = new Random();

            for (var i = 0; i < text.Length; i++)
                key += alphabet[rand.Next(0, alphabetLenght)];

            return key;
        }

        static string Encrypt(string text, string key)
        {
            string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            var alphabetLenght = alphabet.Length;
            var cipher = "";

            for (int i = 0; i < text.Length; i++)
            {
                var textIndex = alphabet.IndexOf(text[i]);
                var keyIndex = alphabet.IndexOf(key[i]);

                if (textIndex < 0)
                    cipher += text[i];

                else
                {
                    var cipherIndex = (alphabetLenght + textIndex + keyIndex) % alphabetLenght;
                    cipher += alphabet[cipherIndex];
                }
            }

            return cipher;
        }

        static string Decrypt(string cipher, string key)
        {
            while (key.Length < cipher.Length)
                key += key;

            string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            var alphabetLenght = alphabet.Length;
            var text = "";

            for (int i = 0; i < cipher.Length; i++)
            {
                var cipherIndex = alphabet.IndexOf(cipher[i]);
                var keyIndex = alphabet.IndexOf(key[i]);

                if (cipherIndex < 0)
                    text += cipher[i];

                else
                {
                    var textIndex = (alphabetLenght + cipherIndex - keyIndex) % alphabetLenght;
                    text += alphabet[textIndex];
                }
            }

            return text;
        }
    }
}
