namespace Pokemon_Trainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            string input;

            while ((input = Console.ReadLine()) != "Tournament")
            {
                var parts = input.Split();
                string trainerName = parts[0];
                string pokemonName = parts[1];
                string pokemonElement = parts[2];
                int pokemonHealth = int.Parse(parts[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = new Trainer(trainerName);
                }

                trainers[trainerName].AddPokemon(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
            }

            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers.Values)
                {
                    trainer.CheckForElement(input);
                }
            }

            foreach (var trainer in trainers.Values
                                              .OrderByDescending(t => t.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
