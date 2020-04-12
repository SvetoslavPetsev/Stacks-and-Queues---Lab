using System;
using System.Collections.Generic;
using System.Linq;


namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var indexBracket = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == '(')
                {
                    indexBracket.Push(i);
                }
                else if (input[i] == ')')
                {
                    int start = indexBracket.Pop();
                    string substring = input.Substring(start, i - start + 1 );
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
