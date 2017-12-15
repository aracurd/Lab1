using System;
using System.Globalization;

namespace Lab1_Calc
{
    public sealed class Operations : IOperations
    {
        public string Divide(double a, double b)
        {
            if (b == 0)
                return "You can not divide by zero!";
            return (a/b).ToString(CultureInfo.InvariantCulture);
        }

        public string Multiplication(double a, double b)
        {
          return (a * b).ToString(CultureInfo.InvariantCulture);
        }

        public string Addition(double a, double b)
        {
            return (a + b).ToString(CultureInfo.InvariantCulture);
        }

        public string Subtraction(double a, double b)
        {
            return (a - b).ToString(CultureInfo.InvariantCulture);
        }

        public string Exponentiation(double a, double b)
        {
            return Math.Pow(a, b).ToString(CultureInfo.InvariantCulture);
        }

        public double Factorial(double num)
        {
            return (num == 0) ? 1 : num * Factorial(num - 1);
        }
    }
}

