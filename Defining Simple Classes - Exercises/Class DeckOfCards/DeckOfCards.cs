using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_DeckOfCards
{
    internal class DeckOfCards
    {
        private List<string> cards = new List<string>();

        public void Add(string card)
        {
            cards.Add(card);
        }

        public void Print()
        {
            if (cards.Count > 0)
            {
                Console.WriteLine(cards[cards.Count - 1]);
            }
            else
            {
                Console.WriteLine("No cards in the deck.");
            }
        }

        public void GetAllCards()
        {
            foreach (var card in cards)
            {
                Console.WriteLine(card);
            }
        }

        public void Shuffle()
        {
            Random r = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int rIdx = r.Next(0, cards.Count);
                string oldCard = cards[i];
                cards[i] = cards[rIdx];
                cards[rIdx] = oldCard;
            }

            foreach (var card in cards)
            {
                Console.WriteLine(card);
            }
        }

        public void Clear()
        {
            cards.Clear();
        }    }
}
