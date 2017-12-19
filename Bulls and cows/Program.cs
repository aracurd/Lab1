using System;
using System.Linq;
using static System.Console;

namespace Bulls_and_cows
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var gLogics = new GameLogics();
            Title = "Bulls and Cows";
            WriteLine(Title + "\n", ForegroundColor = ConsoleColor.DarkGreen);
            WriteLine("Enter your 4-digit number");
            gLogics.ProposNumber = ReadLine();

            if (gLogics.ProposNumber?.Length > 4 || gLogics.ProposNumber?.Length < 4)
            {
                WriteLine("Error! You entered an invalid number!", ForegroundColor = ConsoleColor.DarkRed);
                ReadLine();
                return;
            }
            WriteLine("", ForegroundColor = ConsoleColor.White);
            var variety = gLogics.SetGenerator(gLogics.Revers(4)).ToList();

            while (variety.Count > 1)
            {
                var guess = variety[0];
                var bulls = default(int);
                var cows = default(int);
                Write($"My guess is {guess}.");
                ReadLine();
                gLogics.Checking(out bulls, out cows, gLogics.ProposNumber, guess);
                for (var i = variety.Count - 1; i >= 0; i--)
                {
                    var totalBulls = default(int);
                    var totalCows = default(int);

                    for (var j = 0; j < 4; j++)
                        if (variety[i][j] == guess[j])
                            totalBulls++;
                        else if (variety[i].Contains(guess[j]))
                            totalCows++;
                    if ((totalBulls != bulls) || (totalCows != cows))
                        variety.RemoveAt(i);
                }

                WriteLine($"Bulls = {bulls}, Cows = {cows}");

            }
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine();
            WriteLine(variety.Count == 1 ? $"Number is {variety[0]}!" : "No possible answer.");

            ReadLine();
        }
    }
}
