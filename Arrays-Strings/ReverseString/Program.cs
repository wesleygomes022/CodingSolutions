using System;
using System.IO;
using System.Collections.Generic;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("ab cd ef"));
        }

        static string Reverse(string s)
        {
            if (s.Length == 1)
            {
                return s;
            }
            else if (s.Length == 0)
            {
                return null;
            }
            else
            {
                char[] s2 = new char[s.Length];

                for (int i = s.Length - 1; i >= 0; i--)
                {
                    s2[s.Length - i - 1] = s[i];
                }

                string re = null;
                foreach (char el in s2)
                {
                    re += el;                   
                }
                
                return re;
            }
        }
    }
}

