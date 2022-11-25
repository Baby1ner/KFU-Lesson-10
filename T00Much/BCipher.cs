using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    internal class BCipher : ICipher
    {
        public string decode()
        {
            Console.WriteLine("Введите строку которую надо зашифровать (на английском языке)");
            string text = Console.ReadLine();
            StringBuilder list = new StringBuilder();
            foreach (char c in text)
            {
                if (Char.IsUpper(c))
                {
                    list.Append((char)(155 - c));
                }
                else
                {
                    list.Append((char)(219 - c));
                }
            }
            return list.ToString();
        }

        public string encode()
        {
            return decode();
        }
    }
}
