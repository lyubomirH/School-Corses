using Class_Card;

namespace Randomize_Cards
{
    internal class Program
    {
        static void Main(string[] args)    
        {
            string[] faces = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K" };
            string[] suites = new string[4] { "Spedes", "Diamonds", "Clubs", "Hearts" };

            List<Card> cards = new List<Card>();

            for (int i = 0; i < faces.Count(); i++)
            {
                foreach (string suite in suites)
                {
                    cards.Add(new Card {Face = faces[i], Suite = suite});
                }
            }

            Random r = new Random(5);

            for(int i = 0; i < cards.Count; i++)
            {
                int rIdx = r .Next(0,cards.Count);
                Card oldCard = cards[i];
                cards[i] = cards[rIdx];
                cards[rIdx] = oldCard;
            }

            foreach (Card card in cards)
            {
                card.Print();
            }
        }
    }
}

