﻿using System;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWelcomeMessage();
            while (true)
            {
                PerformOneCalculation();
            }

        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine(@"Welcome to the calculator!
************************************");
        }

        static void PerformOneCalculation()
        {
            string op = EnterOp();
            
            Console.WriteLine($@"How many numbers would you like to {op}?");
            int numN = EnterANumber();

            Console.WriteLine("Enter the first number:");
            int initialNum = EnterANumber();

            string message = @"The answer is: ";
            int answer = initialNum;

            for (int i = 1; i < numN; i++)
            {
                Console.WriteLine("Enter a number:");
                int newNum = EnterANumber();

                if (op == "+")
                {
                    answer = answer + newNum;
                }
                else if (op == "-")
                {
                    answer = answer - newNum;
                }
                else if (op == "/")
                {
                    answer = answer / newNum;
                }
                else if (op == "*")
                {
                    answer = answer * newNum;
                }
            }

            Console.WriteLine($@"{message}{answer}");

        }

        static int EnterANumber()
        {
            string number = Console.ReadLine();
            int numX;
            bool check = int.TryParse(number, out numX);
            if (!check)
            {
                Console.WriteLine("Sorry, I don't understand... Please try again:");
                EnterANumber();
            }
            else
            {
                numX = int.Parse(number);
            }
            return numX;
        }

        static string EnterOp()
        {
            Console.WriteLine("Please enter the operator:");
            string opTemp = Console.ReadLine();
            return opTemp;
        }
    }
}