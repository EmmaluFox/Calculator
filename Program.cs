using System;

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

            Console.WriteLine("Enter the first number:");
            string x = Console.ReadLine();
            int myInt = int.Parse(x);
            Console.WriteLine("Enter the second number:");
            string y = Console.ReadLine();
            int myIntTwo = int.Parse(y);
            string message = $@"{myInt} {op} {myIntTwo} = ";
            if (op == "+")
            {
                Console.Write($@"{message}");
                Console.Write(myInt + myIntTwo);
            } else if (op == "-")
            {
                Console.Write($@"{message}");
                Console.Write(myInt - myIntTwo);
            } else if (op == "/") {
                Console.Write($@"{message}");
                Console.Write(myInt / myIntTwo);
            } else if (op == "*") {
                Console.Write($@"{message}");
                Console.Write(myInt * myIntTwo);
            }
        }
    }
}