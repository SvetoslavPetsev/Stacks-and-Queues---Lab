using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main()
        {
            var names = Console.ReadLine().Split();
            var queueNames = new Queue<string>(names);
            var target = int.Parse(Console.ReadLine());

            while (queueNames.Count > 1)
            {
                var counter = 1;
                while (counter != target)
                {
                    var name = queueNames.Dequeue();
                    queueNames.Enqueue(name);
                    counter++;
                }
                if (counter == target)
                {
                    Console.WriteLine($"Removed {queueNames.Dequeue()}"); ;
                }
            }
            Console.WriteLine($"Last is {queueNames.Dequeue()}");
        }
    }
}
