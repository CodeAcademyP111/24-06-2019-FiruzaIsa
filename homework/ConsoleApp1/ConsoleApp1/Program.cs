using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentences = "Salam Sirvan necesen";
            StringBuilder LastResult = ReverseWordInSent(sentences);
            Console.WriteLine(LastResult);

        }

        static StringBuilder ReverseWordInSent(string str)
        {
            string[] words = str.Split(' ');
            StringBuilder result = new StringBuilder();
            foreach (var word in words)
            {
                if (words[0] != word)
               {
                    result.Append(" ");
                }
                for (int i = word.Length-1; i >=0; i--)
                {
                   result.Append(word[i]);
                }

            }
            return result;
        }



    }
}