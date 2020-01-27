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
            
            Console.WriteLine("Enter the first number:");
            string gamma = Console.ReadLine();
            int initialNum = int.Parse(gamma);
          
            string message = @"The answer is: ";
            int answer = initialNum;
            
            for (int i = 1; i < numN; i++)
            {
                Console.WriteLine("Enter a number:");
                string beta = Console.ReadLine();
                int newNum = int.Parse(beta);
                
                if (op == "+")
                {
                    answer = answer + newNum;
                } else if (op == "-")
                {
                    answer = answer - newNum;
                } else if (op == "/") {
                    answer = answer / newNum;
                } else if (op == "*") {
                    answer = answer * newNum;
                }
            }
            Console.Write($@"{message}{answer}");
            Console.ReadLine();
            }
            
       
            
            
    }
}