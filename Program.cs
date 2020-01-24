using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("Enter a number:");
            string x = Console.ReadLine();
            int myInt = int.Parse(x);
            
            Console.WriteLine("Enter another number:");
            string y = Console.ReadLine();
            int myIntTwo = int.Parse(y);
            
            Console.Write(myInt +" multiplied by " +myIntTwo +" = " +(myInt*myIntTwo));
        }
    }
}