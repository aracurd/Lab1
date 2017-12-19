using System;
using System.Collections.Generic;
using System.Linq;

namespace Testing
{
    class Program
    {
        private const string My = "8765";

        private static void Main()
        {
            var taurs = new TaursAndCows();
            do
            {
                taurs.Try();
            } while (taurs.Answer != My);
            Console.WriteLine("Hi");
            Console.ReadKey();
        }

        public static Tuple<int, int> GetCows(string s)
        {
            int cows = 0, taurs = 0;
            for (int i = 0; i < s.Length; i++)
                if (s[i] == My[i])
                    taurs++;
                else if (My.Contains(s[i]))
                    cows++;
            return new Tuple<int, int>(taurs, cows);
        }
    }

    public class TaursAndCows
    {

        private class Taur
        {
            public readonly int Position;
            public readonly int Value;

            public Taur(int position, int value)
            {
                Position = position;
                Value = value;
            }
        }

        public string Answer { get { return number; } }
        private string number = "0123";
        private int Cows { get { return cowsGuess.Count; } }
        private int Taurs { get { return taurs.Count; } }
        private int modifiedPosition;
        private bool firstTry = true;
        private System.Collections.Generic.List<Taur> taurs = new List<Taur>();

        private int lastGuessedValue;

        private readonly HashSet<int> defaultGuess = new HashSet<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private readonly HashSet<int> cowsGuess = new HashSet<int>();
        private int[] RestGuess { get { return defaultGuess.Except(cowsGuess).Except(number.Skip(1).Select(c => (int)char.GetNumericValue(c))).ToArray(); } }
        private int lastCowGuess = 0;

        public void Try()
        {
            var array = number.ToCharArray();
            if (Cows + Taurs == number.Length)
                RandomizeStrings(array);
            if (cowsGuess.Count > lastGuessedValue)
                array[modifiedPosition] = (char)(cowsGuess.ToArray()[lastGuessedValue] + '0');
            else
            {
                array[modifiedPosition] = (char)(RestGuess[lastGuessedValue - cowsGuess.Count] + '0');
            }
            var newnumber = new string(array);
            AnalyseResponse(newnumber);
        }

        private void AnalyseResponse(string newnumber)
        {
            var tuple = Program.GetCows(newnumber);
            var newtaurs = tuple.Item1;
            var newcows = tuple.Item2;
            if (newtaurs == Taurs)
            {
                lastGuessedValue++;
            }
            else if (newtaurs > Taurs)
            {
                number = newnumber;
                taurs.Add(new Taur(modifiedPosition, (int)char.GetNumericValue(number[modifiedPosition])));
                lastGuessedValue = 0;
                modifiedPosition++;
            }
            if (newcows > Cows)
                cowsGuess.Add((int)char.GetNumericValue(newnumber[modifiedPosition]));
        }

        static Random _random = new Random();

        public static char[] RandomizeStrings(char[] arr)
        {
            List<KeyValuePair<int, char>> list = new List<KeyValuePair<int, char>>();
            foreach (char s in arr)
            {
                list.Add(new KeyValuePair<int, char>(_random.Next(), s));
            }
            var sorted = from item in list
                         orderby item.Key
                         select item;
            char[] result = new char[arr.Length];
            int index = 0;
            foreach (KeyValuePair<int, char> pair in sorted)
            {
                result[index] = pair.Value;
                index++;
            }
            return result;
        }
    }
}