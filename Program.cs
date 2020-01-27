using System;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Welcome to the calculator!
************************************");
            Console.WriteLine("Please enter the operator:");
            string op = Console.ReadLine();
            
            Console.WriteLine($@"How many numbers would you like to {op}?");
            string alpha = Console.ReadLine();
            int numN = int.Parse(alpha);
            
            int[] runningTotal = new int[numN];
            for (int i = 0; i < numN; i++)
            {
                Console.WriteLine("Enter a number:");
                string beta = Console.ReadLine();
                int newNum = int.Parse(beta);
                runningTotal[i] = newNum;
            }
            Console.ReadLine();
       
            string message = @"The answer is: ";
            if (op == "+")
            {
                Console.Write($@"{message}");
                Console.Write(runningTotal.Sum());
            } else if (op == "-")
            {
                Console.Write($@"{message}");
                Console.Write("");
            } else if (op == "/") {
                Console.Write($@"{message}");
                Console.Write("");
            } else if (op == "*") {
                Console.Write($@"{message}");
                Console.Write("");
            }
        }
        
        private static void howManyNums()
        {
            
        }
    }
}