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
                Title = "Простой калькулятор";
                WriteLine($"{Title} \n", ForegroundColor = ConsoleColor.Green);
                WriteLine(
                    "Выполняемые операции:\nДеление:\t/\nУмножение:\t*\nПрибавление:\t+\nВычитание:\t-\nЭкспоненцирование:\t^\n",
                    ForegroundColor = ConsoleColor.DarkYellow);
                WriteLine("Введите значения для вычислений:", ForegroundColor = ConsoleColor.White);
                try
                {
                    Write("а: ");
                    a = double.Parse(ReadLine());
                    Write("в:");
                    b = double.Parse(ReadLine());
                    WriteLine("Виберите операцию:");
                    key = ReadLine();
                }
                catch (Exception)
                {
                    WriteLine("Ошибка ввода!", ForegroundColor = ConsoleColor.Red);
                    ReadLine();
                    return;
                }
                string result = Calculation(a, b, key, ref oper);
                WriteLine($"Результат операции {oper} с входными данными а: {a} и в: {b} равен:{result}");
                WriteLine($"Для проболжения нажмите - Enter, Для выхода - х", ForegroundColor = ConsoleColor.Green);
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
                        oper = OperationsEnum.Вычитание.ToString();
                        return calc.Divide(firstVal, secondVal);
                }

                case "*":
                {
                        oper = OperationsEnum.Умножение.ToString();
                        return calc.Multiplication(firstVal, secondVal);
                }

                case "+":
                {
                        oper = OperationsEnum.Прибавление.ToString();
                        return calc.Addition(firstVal, secondVal);
                }

                case "-":
                {
                        oper = OperationsEnum.Деление.ToString();
                        return calc.Subtraction(firstVal, secondVal);
                }

                case "^":
                {
                        oper = OperationsEnum.Экспоненцирование.ToString();
                        return calc.Exponentiation(firstVal, secondVal);
                }

                default:
                    return "Операция не выбрана или выбрана не верно!";
            }
        }
    }
}
