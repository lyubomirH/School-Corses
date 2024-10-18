namespace Class_Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();

            Card cardOne = new Card() { Face = "A", Suite = "Spades" };
            Card cardTwo = new Card() { Face = "J", Suite = "Dimonds" };
            Card cardTree = new Card() { Face = "Q", Suite = "Clubs" };
            Card cardFour = new Card() { Face = "10", Suite = "Harts" };

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardTree);
            cards.Add(cardFour);
        }
    }
}
