using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbersStack = new Stack<int>(numbers);
            string input;
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                var command = input.Split();
                if (command[0] == "add")
                {
                    int num1 = int.Parse(command[1]);
                    int num2 = int.Parse(command[2]);
                    numbersStack.Push(num1);
                    numbersStack.Push(num2);
                }
                else if (command[0] == "remove")
                {
                    int num = int.Parse(command[1]);
                    if (num <= numbersStack.Count)
                    {
                        while (num > 0)
                        {
                            numbersStack.Pop();
                            num--;
                        }
                    }
                }
            }
            int sum = numbersStack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
