using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
/*
            int x;
            int y;
            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
*/

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