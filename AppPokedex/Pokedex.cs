using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokedex
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InitList();
        }

        private List<PokemonPlus> pokemons;

        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
        }

        private void InitList()
        {
            PokemonPlus p;
            this.pokemons = new List<PokemonPlus>();
            
            p = new PokemonPlus("Bulbasauro", "Type: Planta", 40);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mew", "Type: Psíquico", 100);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mewtwo", "Type: Psíquico", 95);
            this.pokemons.Add(p);
            p = new PokemonPlus("Giratina", "Type: Fantasma", 90);
            this.pokemons.Add(p);
            p = new PokemonPlus("Flygon", "Type: Dragão", 80);
            this.pokemons.Add(p);
            p = new PokemonPlus("Metagross", "Type: Metal", 90);
            this.pokemons.Add(p);
            p = new PokemonPlus("Muk", "Type: Tóxico", 60);
            this.pokemons.Add(p);
            p = new PokemonPlus("Metagross", "Type: Metal", 90);
            this.pokemons.Add(p);
            p = new PokemonPlus("Lucario", "Type: Lutador", 65);
            this.pokemons.Add(p);
            p = new PokemonPlus("Paras", "Type: Inseto", 70);
            this.pokemons.Add(p);
        }

        public void ListPokemons()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                Console.WriteLine("Pokémon ID: " + i);
                this.Pokemons[i].ShowDataPokemon();
            }
        }

    }
}
