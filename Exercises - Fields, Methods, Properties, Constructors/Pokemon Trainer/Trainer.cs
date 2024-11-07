using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Trainer
{
    internal class Trainer
    {
        public string Name { get; set; }
        public int Badges { get; private set; }
        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name)
        {
            Name = name;
            Badges = 0;
            Pokemons = new List<Pokemon>();
        }

        public void AddPokemon(Pokemon pokemon)
        {
            Pokemons.Add(pokemon);
        }

        public void CheckForElement(string element)
        {
            if (Pokemons.Any(pokemon => pokemon.Element == element))
            {
                Badges++;
            }
            else
            {
                foreach (var pokemon in Pokemons)
                {
                    pokemon.Health -= 10;
                }
                Pokemons.RemoveAll(pokemon => pokemon.Health <= 0);
            }
        }
    }
}
