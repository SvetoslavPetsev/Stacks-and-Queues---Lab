using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            var reversed = new Stack<string>();
            foreach (var symbol in text)
            {
               reversed.Push(symbol.ToString());
            }
            while (reversed.Any())
            {
                Console.Write(reversed.Pop());
            }
        }
    }
}
