using System;
using System.Globalization;
using static System.Console;

namespace Lab1_Calc
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var repeat = String.Empty;
            var a = default(double); ;
            var b = default(double); ;
            var key = String.Empty;

            while (repeat != "x")
            {
                Clear();
                Title = "Simple calculator";
                WriteLine($"{Title} \n", ForegroundColor = ConsoleColor.Green);
                WriteLine(
                    $"The operations to be performed:\n{OperationsEnum.Divide}:\t/\n{OperationsEnum.Multiplication}:\t*\n{OperationsEnum.Addition}:\t+\n{OperationsEnum.Subtraction}:\t-\n{OperationsEnum.Exponentiation}:\t^\n{OperationsEnum.Factorial}:\tf\n",
                    ForegroundColor = ConsoleColor.DarkYellow);
                WriteLine("Enter the values for the calculations:", ForegroundColor = ConsoleColor.White);
                try
                {
                    WriteLine("Select an operation:");
                    key = ReadLine();
                   
                    Write("а: ");
                    a = double.Parse(ReadLine());

                    if (key != "f")
                    {
                        Write("b: ");
                        b = double.Parse(ReadLine());
                    }
                    
                }
                catch (Exception)
                {
                    WriteLine("Input Error!", ForegroundColor = ConsoleColor.Red);
                    ReadLine();
                    return;
                }
                WriteLine(Calculation(a, b, key));
                WriteLine($"To continue, press - Enter, To exit - х", ForegroundColor = ConsoleColor.Green);
                repeat = ReadLine();
            }
        }

        private static string Calculation(double firstVal, double secondVal, string key)
        {
            var calc = new Operations();
            var oper = string.Empty;
            var res = string.Empty;
            switch (key)
            {
                case "/":
                {
                        oper = OperationsEnum.Divide.ToString();
                        res = calc.Divide(firstVal, secondVal);
                        break;
                    }

                case "*":
                {
                        oper = OperationsEnum.Multiplication.ToString();
                        res = calc.Multiplication(firstVal, secondVal);
                        break;
                }

                case "+":
                {
                        oper = OperationsEnum.Addition.ToString();
                        res = calc.Addition(firstVal, secondVal);
                        break;
                    }

                case "-":
                {
                        oper = OperationsEnum.Subtraction.ToString();
                        res = calc.Subtraction(firstVal, secondVal);
                        break;
                    }

                case "^":
                {
                        oper = OperationsEnum.Exponentiation.ToString();
                        res = calc.Exponentiation(firstVal, secondVal);
                        break;
                    }
                case "f":
                    {
                        oper = OperationsEnum.Factorial.ToString();
                        res = calc.Factorial(firstVal).ToString(CultureInfo.InvariantCulture);
                        break;
                    }

                default:
                    return "Operation not selected or selected incorrectly!";
            }
            return key == "f" ? $"Result of operation {oper} entered number а: {firstVal}  is: {res}" : $"Result of operation {oper} with input data а: {firstVal} и b: {secondVal} is: {res}";
        }
    }
}
