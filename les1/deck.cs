using System.Collections.Generic;

namespace les1
{
    public class Deck
    {
        public Dictionary<string, Cards> CardDeck = new Dictionary<string, Cards>()
        {
            { "red", Cards.six},
            { "red", Cards.seven},
            { "red", Cards.eight},
            { "red", Cards.nine},
            { "red", Cards.ten},
            { "red", Cards.jack},
            { "red", Cards.lady},
            { "red", Cards.king},
            { "red", Cards.ten},
        };
    }

    public struct Card
    {
        public string CardNimber { get; set; }
        public string CardSuit { get; set; }
    }
}
