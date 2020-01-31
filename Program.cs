﻿using System;
using System.Linq;

namespace Calculator
{
    class Program
    {
        private const int NumberCalculator = 1;
        private const int DateCalculator = 2;
        private const int TwoDates = 1;
        private const int Days = 2;
        private const int TwoDateDays = 3;
        private const int DateDays = 4;
        private const int MainMenu = 5;
        
        static void Main(string[] args)
        {
            MyCalculator();
        }
        static void MyCalculator()
        {
            PrintWelcomeMessage();
            while (true)
            {
                int calculationMode = AskForCalculationMode();
                if (calculationMode == NumberCalculator)
                {
                    NumberCalculatorClass.PerformOneNumberCalculation();
                }
                else if (calculationMode == DateCalculator)
                {
                    DateCalculatorClass.PerformOneDateCalculation();
                }
            }
        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine(@"Welcome to the calculator!
************************************");
        }
        
        static int AskForCalculationMode()
        {
            Console.WriteLine("Choose a calculation mode:");
            Console.Write(@"1: Number Mode
2: Date Mode
");
            int modeX = int.Parse(Console.ReadLine());
            if (modeX == NumberCalculator)
            {
                Console.WriteLine("Number mode selected");
            }
            else if (modeX == DateCalculator)
            {
                Console.WriteLine("Date mode selected");
            }
            else
            {
                Console.WriteLine(@"Invalid selection. 
Please choose between:
1) for Number mode
2) for Date mode");
                modeX = int.Parse(Console.ReadLine());
            }

            return modeX;
        }
        
    class NumberCalculatorClass
    {
        private static string EnterANumber()
        {
            string number = Console.ReadLine();
            int numX;
            bool check = int.TryParse(number, out numX);
            if (!check)
            {
                Console.WriteLine("Sorry, I don't understand... Please try again:");
                numX = int.Parse(EnterANumber());
            }
            number = numX.ToString();
            return number;
        }
        
        public static int ConvertNum()
        {
            string number = EnterANumber();
            int numX = int.Parse(number);
            return numX;
        }
        public static void PerformOneNumberCalculation()
        {
            string op = EnterOp();

            Console.WriteLine($@"How many numbers would you like to {op}?");
            int numN = ConvertNum();

            Console.WriteLine("Enter the first number:");
            int initialNum = ConvertNum();

            string message = @"The answer is: ";
            int answer = initialNum;

            for (int i = 1; i < numN; i++)
            {
                Console.WriteLine("Enter a number:");
                int newNum = ConvertNum();

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
            Console.WriteLine($@"{message}{answer}
");

        }
        static string EnterOp()
        {
            Console.WriteLine("Please enter the operator:");
            string opTemp = Console.ReadLine();
            string op = opTemp;
            if (new[] {"+", "-", "/", "*"}.Contains(opTemp))
            {
                Console.WriteLine("Thank you!");
            }
            else
            {
                op = EnterOp();
            }
            return op;
        }
    }

    class DateCalculatorClass
    {
        public static void PerformOneDateCalculation()
        {
            while (true)
            {
                int dateMode = AskForDateMode();
                if (dateMode == TwoDates)
                {
                    CalcTwoDates();
                }
                else if (dateMode == Days)
                {
                    CalcDays();
                }
                else if (dateMode == TwoDateDays)
                {
                    CalcTwoDateDays();
                }
                else if (dateMode == DateDays)
                {
                    CalcDateDays();
                }
                else if (dateMode == MainMenu)
                {
                    MyCalculator();
                }
                else
                {
                    PerformOneDateCalculation();
                }

            }
        }


        private static string EnterADate()
        {
            Console.WriteLine("Enter a date:");
            string dateOne = Console.ReadLine();
            DateTime dateX;
            bool check = DateTime.TryParse(dateOne, out dateX);
            if (!check)
            {
                Console.WriteLine("Sorry, I don't understand... Please try again:");
                dateX = DateTime.Parse(EnterADate());
            }

            dateOne = dateX.ToString();
            return dateOne;
        }


        private static DateTime ConvertDate()
        {
            string dateOne = EnterADate();
            DateTime dateX = DateTime.Parse(dateOne);
            return dateX;
        }

        private static int AskForDateMode()
        {
            Console.WriteLine("What would you like to calculate?");
            Console.Write(@"Please choose between:
            1) Number of days between two dates
            2) Number of days between a date and now
            3) Date x days from date entered
            4) Date x days from now
            5) Return to the main menu
");
            int modeX = int.Parse(Console.ReadLine());
            if (modeX == TwoDates)
            {
                Console.WriteLine("Calculate the number of days between two dates");
            }
            else if (modeX == DateDays)
            {
                Console.WriteLine("Calculate what date it will be in x days");
            }
            else if (modeX == Days)
            {
                Console.WriteLine("Calculate the number of days to a date from now");
            }
            else if (modeX == TwoDateDays)
            {
                Console.WriteLine("Calculate what date it will be x days from any date");
            }
            else if (modeX == MainMenu)
            {
                Console.WriteLine(@"See you later!
");
            }
            else
            {
                Console.WriteLine(@"Invalid selection. 
Please choose between:
1) Number of days between two dates
2) Number of days between a date and now
3) Date x days from date entered
4) Date x days from now
5) Return to the main menu
");
                modeX = int.Parse(Console.ReadLine());
            }

            return modeX;
        }

        private static TimeSpan CalcTwoDates()
        {
            DateTime dateX = ConvertDate();
            string dateXStr = dateX.ToShortDateString();
            DateTime dateY = ConvertDate();
            string dateYStr = dateY.ToShortDateString();
            TimeSpan dateSpan = dateY.Subtract(dateX);
            double daysX = (dateSpan.TotalDays);
            double daysY = (daysX * -1);
            if (daysX >= 0)
            {
                Console.Write($@"{dateYStr} is {daysX} days after {dateXStr}
");
            }
            else
            {
                Console.WriteLine($@"{dateYStr} is {daysY} days before {dateXStr}
");
            }

            return dateSpan;
        }

        private static TimeSpan CalcDays()
        {
            DateTime dateX = ConvertDate();
            string dateXStr = dateX.ToShortDateString();
            DateTime dateY = DateTime.Now;
            TimeSpan dateSpan = dateY.Subtract(dateX);
            int daysX = (dateSpan.Days);
            int daysY = (daysX * -1);
            if (daysX >= 0)
            {
                Console.Write($@"{dateXStr} was {daysX} days ago
");
            }
            else
            {
                Console.WriteLine($@"{dateXStr} is in {daysY} days
");
            }

            return dateSpan;
        }

       private static DateTime CalcTwoDateDays()
        {
            DateTime dateY = ConvertDate();
            Console.WriteLine("Please enter the number of days: (To subtract, just enter a negative number e.g. -10)");
            int daysX = NumberCalculatorClass.ConvertNum();
            string dateYStr = dateY.ToShortDateString();
            DateTime daysCalc = dateY.AddDays(daysX);
            string daysDate = daysCalc.ToShortDateString();

            if (daysX >= 0)
            {
                Console.Write($@"{daysX} days after {dateYStr} is {daysDate}
");
            }
            else
            {
                Console.WriteLine($@"{daysX} days before {dateYStr} is {daysDate}
");
            }

            return daysCalc;
        }
        private static DateTime CalcDateDays()
        {
            Console.WriteLine(@"Please enter the number of days.
To subtract, just enter a negative number e.g. -10");
            int daysX = NumberCalculatorClass.ConvertNum();
            DateTime daysCalc = DateTime.Now.AddDays(daysX);
            string daysDate = daysCalc.ToShortDateString();
            int daysY = daysX * -1;

            if (daysX >= 0)
            {
                Console.Write($@"The date {daysX} days from now will be {daysDate}
");
            }
            else
            {
                Console.WriteLine($@"The date {daysY} days ago was {daysDate}
");
            }
            return daysCalc;
        }
    }
    }
}