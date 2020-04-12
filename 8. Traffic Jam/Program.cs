using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main()
        {
            var passNumber = int.Parse(Console.ReadLine());
            var carsQueue = new Queue<string>();
            int passedCounter = 0;
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < passNumber; i++)
                    {
                        if (carsQueue.Any())
                        {
                            passedCounter++;
                            Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        }
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);
                }
            }
            Console.WriteLine($"{passedCounter} cars passed the crossroads.");
        }
    }
}
