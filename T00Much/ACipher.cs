using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    internal class ACipher : ICipher
    {
        public string encode()
        {
            Console.WriteLine("Введите строку которую надо зашифровать (на английском языке)");
            string text = Console.ReadLine();
            StringBuilder list = new StringBuilder();
            foreach (char c in text)
            {
                if (c != 'z' && c != 'Z')
                    list.Append((char)(c + 1));
                else if (c == 'z')
                    list.Append('a');
                else list.Append('A');
            }
            return list.ToString();
        }
        public string decode()
        {
            Console.WriteLine("Введите строку которую надо расшифровать");
            string text = Console.ReadLine();
            StringBuilder list = new StringBuilder();
            foreach (char c in text)
            {
                if (c != 'a' && c != 'A')
                    list.Append((char)(c - 1));
                else if (c == 'a')
                    list.Append('z');
                else list.Append('Z');
            }
            return list.ToString();
        }
    }
}
