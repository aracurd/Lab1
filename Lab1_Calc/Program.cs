using System;
using static System.Console;

namespace Lab1_Calc
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string repeat = "";
            double a =0;
            double b = 0;
            string key = "";
            string oper = "";
            while (repeat != "x")
            {
                Clear();
                Title = "Simple calculator";
                WriteLine($"{Title} \n", ForegroundColor = ConsoleColor.Green);
                WriteLine(
                    $"The operations to be performed:\n{OperationsEnum.Divide}:\t/\n{OperationsEnum.Multiplication}:\t*\n{OperationsEnum.Addition}:\t+\n{OperationsEnum.Subtraction}:\t-\n{OperationsEnum.Exponentiation}:\t^\n",
                    ForegroundColor = ConsoleColor.DarkYellow);
                WriteLine("Enter the values for the calculations:", ForegroundColor = ConsoleColor.White);
                try
                {
                    Write("а: ");
                    a = double.Parse(ReadLine());
                    Write("b: ");
                    b = double.Parse(ReadLine());
                    WriteLine("Select an operation:");
                    key = ReadLine();
                }
                catch (Exception)
                {
                    WriteLine("Input Error!", ForegroundColor = ConsoleColor.Red);
                    ReadLine();
                    return;
                }
                string result = Calculation(a, b, key, ref oper);
                WriteLine($"Result of operation {oper} with input data а: {a} и b: {b} is:{result}");
                WriteLine($"To continue, press - Enter, To exit - х", ForegroundColor = ConsoleColor.Green);
                repeat = ReadLine();
            }
        }

        private static string Calculation(double firstVal, double secondVal, string key, ref string oper)
        {
            var calc = new Operations();

            switch (key)
            {
                case "/":
                {
                        oper = OperationsEnum.Divide.ToString();
                        return calc.Divide(firstVal, secondVal);
                }

                case "*":
                {
                        oper = OperationsEnum.Multiplication.ToString();
                        return calc.Multiplication(firstVal, secondVal);
                }

                case "+":
                {
                        oper = OperationsEnum.Addition.ToString();
                        return calc.Addition(firstVal, secondVal);
                }

                case "-":
                {
                        oper = OperationsEnum.Subtraction.ToString();
                        return calc.Subtraction(firstVal, secondVal);
                }

                case "^":
                {
                        oper = OperationsEnum.Exponentiation.ToString();
                        return calc.Exponentiation(firstVal, secondVal);
                }

                default:
                    return "Operation not selected or selected incorrectly!";
            }
        }
    }
}
