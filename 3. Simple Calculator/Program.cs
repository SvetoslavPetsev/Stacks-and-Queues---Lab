using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main()
        {
            string calculations = Console.ReadLine();
            Stack<string> stack = new Stack<string>(calculations.Split().Reverse());
            int sum = 0;
            while (stack.Count > 1)
            {
                int firstNumber = int.Parse(stack.Pop());
                var expression = stack.Pop();
                int secondNumber = int.Parse(stack.Pop());
                if (expression == "+")
                {
                    sum = firstNumber + secondNumber;
                }
                else if (expression == "-")
                {
                    sum = firstNumber - secondNumber;
                }
                stack.Push(sum.ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
