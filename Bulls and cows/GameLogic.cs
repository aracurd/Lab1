using System;
using System.Linq;

namespace Bulls_and_cows
{
    class GameLogic
    {
        public int CompleteMach { get; set; }
        public int PartialMach { get; set; }
        public int[] RundomNumber=  new int[4];
        private readonly Random rand = new Random();

        public void RundomNumderGen()
        {
            for (var i = 0; i < RundomNumber.Length; i++)
            {
                bool contais;
                int next;
                do
                {
                    next = rand.Next(10);
                    contais = false;
                    for (var j = 0; j < i; j++)
                    {
                        var n = RundomNumber[j];
                        if (n != next) continue;
                        contais = true;
                        break;
                    }
                } while (contais);
                RundomNumber[i] = next;
            }
        }

        public void Checking(int[] enterVal)
        {
            CompleteMach = 0;
            PartialMach = 0;
            for (int i = 0; i < 4; i++)
            {
                if (enterVal.Contains(RundomNumber[i]) )
                {
                    if (enterVal[i] == RundomNumber[i])
                        CompleteMach++;
                    else
                        PartialMach++;
                }
            }
        }

        public string ResultShow() => $"Bulls - {CompleteMach}, Cows - {PartialMach}";
        
    }
}
