using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt = 1;
            Pokedex pokedex = new Pokedex();
            while (opt != 0)
            {
                opt = Menu();
                if (opt == 1)
                {
                    pokedex.ListPokemons();
                }
                if (opt == 2)
                {
                    pokedex.ListPokemons();
                    Console.WriteLine("Choose Pokémon ID to battle");
                    int id = Convert.ToInt32(Console.ReadLine());
                    PokemonPlus pPlayer = pokedex.Pokemons[id];
                    Console.WriteLine(pPlayer.Nome + " I Choose You!");

                    Random r = new Random();
                    int rID = r.Next(0, pokedex.Pokemons.Count);
                    PokemonPlus pNPC = pokedex.Pokemons[rID];
                    Console.WriteLine("Wild " + pNPC.Nome + " appeared!");

                    if (pPlayer.Power >= pNPC.Power)
                    {
                        Console.WriteLine("You won!");
                    }
                    else
                    {
                        Console.WriteLine("You lost!");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        static int Menu()
        {
            Console.WriteLine("|||  Pokémon Battle  |||");
            Console.WriteLine("0 - Close Pokédex");
            Console.WriteLine("1 - List Pokedex");
            Console.WriteLine("2 - Battle");
            Console.WriteLine("Choose an option: ");
            int opt = Convert.ToInt32(Console.ReadLine());
            return opt;
        }
    }
}