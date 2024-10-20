namespace Class_DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards deck = new DeckOfCards();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandParts = input.Split(' ');

                switch (commandParts[0])
                {
                    case "Add":
                        string card = commandParts[1] + " " + commandParts[2];
                        deck.Add(card);
                        break;

                    case "Print":
                        deck.Print();
                        break;

                    case "Get":
                        if (commandParts[1] == "All" && commandParts[2] == "Cards")
                        {
                            deck.GetAllCards();
                        }
                        break;

                    case "Randomize":
                        deck.Shuffle();
                        break;

                    case "Clear":
                        deck.Clear();
                        break;
                }
            }
        }
    }
}
