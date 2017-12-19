using System;
using System.Collections.Generic;
using System.Linq;

namespace Bulls_and_cows
{

    public sealed class GameLogics
    {
        public string ProposNumber { get; set; }

        public IEnumerable<string> Revers(int size)
        {
            var revers = new List<string>();
            if (size > 0)
            {
                revers.AddRange(from s in Revers(size - 1) from n in "123456789" where !s.Contains(n) select s + n);
            }
            else
                revers.Add("");
            return revers;
        }

        public IEnumerable<T> SetGenerator<T>(IEnumerable<T> source)
        {
            var random = new Random();
            var list = source.ToList();
            var nums = new List<T>();
            while (list.Count > 0)
            {
                var ix = random.Next(list.Count);
                nums.Add(list[ix]);
                list.RemoveAt(ix);
            }
            return nums;
        }

        public bool Checking(out int bulls, out int cows, string startNumber, string gesNumber)
        {

            bulls = 0;
            cows = 0;

            if (startNumber.Length < 2)
                return false;
            else
            {
                for (var i = 0; i < 4; i++)
                {
                    if (gesNumber.Contains(startNumber[i]))
                    {
                        if (startNumber[i] == gesNumber[i])
                            bulls++;
                        else
                            cows++;
                    }
                }
                return true;
            }

        }
    }
}
