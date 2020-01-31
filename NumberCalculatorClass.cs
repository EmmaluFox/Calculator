using System;
using System.Linq;

namespace Calculator
{
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
                WriteToLog.Log();
                op = EnterOp();
            }
            return op;
        }
    }
}