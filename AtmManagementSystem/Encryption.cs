using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmManagementSystem
{
    internal class Encryption
    {
        public static string Encrypt(string text, int key)
        {
            char[] chars = text.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    char baseChar = char.IsUpper(chars[i]) ? 'A' : 'a';
                    chars[i] = (char)((chars[i] - baseChar + key) % 26 + baseChar);
                }
            }

            return new string(chars);
        }

        public static string Decrypt(string text, int key)
        {
            return Encrypt(text, 26 - key);
        }
    }
}
