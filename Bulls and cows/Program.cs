using System;
using System.Linq;
using static System.Console;

namespace Bulls_and_cows
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            var gLog = new GameLogic();
            var enterNumber = new int[4];

            Title = "Игра \"Быки и коровы\"";
            WriteLine($"{Title}\n");
            gLog.RundomNumderGen();
            WriteLine(string.Join("", gLog.RundomNumber));
            do
            {
                WriteLine();
                WriteLine(gLog.ResultShow()); 
                UserEnter(ref enterNumber);
                gLog.Checking(enterNumber);

            } while (gLog.CompleteMach != 4);

            WriteLine("You win");


            ReadLine();
        }

        public static void UserEnter(ref int[] eNumber)
        {
            Write("Введите 4-х значное число: ");
            string value = ReadLine();
            if (value.Length < 4 || value.Length > 4)
            {
                WriteLine("Число должно быть 4-х значное!!");
            }

            eNumber = value?.Select(ch => ch - '0').ToArray();
        }
    }
}
