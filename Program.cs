using System;

namespace Calculator
{
    class Program
    {
        private const int NumberCalculator = 1;
        private const int DateCalculator = 2;
        static void Main(string[] args)
        {
            MyCalculator();
        }
        public static void MyCalculator()
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
    }
}