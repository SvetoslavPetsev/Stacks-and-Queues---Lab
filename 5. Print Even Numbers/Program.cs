using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main()
        {
            var numbersArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbersArr);
            Console.WriteLine(string.Join(", ", queue.Where(x => x % 2 == 0)));
        }
    }
}
