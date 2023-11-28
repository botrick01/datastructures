using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Stack
{
    public class Palindrom
    {
        public static CustomStack<char> Stack = new CustomStack<char>();
        public static bool CheckPalindrom(string word)
        {
            if (word == null) return false;
            string wordLowercase = word.ToLower();
            char[] wordReverse = new char[wordLowercase.Length];
            for(int i = 0; i < wordLowercase.Length; i++)
            {
                Stack.push(wordLowercase[i]);
            }
            for(int i = 0; i < wordLowercase.Length; i++)
            {
                wordReverse[i] = Stack.pop();
            }
            if(new string(wordReverse) == wordLowercase) return true;
            else return false;
        }
    }
}
