using System;
using System.Collections.Generic;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            char[] temp = URLify(str, 13);
            
            for(int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i]);
            }

        }

        public static char[] URLify(string s, int tam)
        {
            int n = 0;          

            for (int i = 0; i < tam; i++)
            {
                if (s[i].Equals(' '))
                    n++;                    
            }

            char[] newStr = new char[tam + 2*n];
            int index = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i].Equals(' '))
                {
                    newStr[i + index] = '%';
                    newStr[i + index + 1] = '2';
                    newStr[i + index + 2] = '0';
                    index += 2;
                }
                else 
                {
                    newStr[index+i] = s[i];
                }
            }
            return newStr;
        }
    }
}
