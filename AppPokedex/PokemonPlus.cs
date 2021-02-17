using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokedex
{
    public class PokemonPlus:Pokemon
    {
        public PokemonPlus():base()
        {
            this.Power = 0;
        }
        public PokemonPlus(String nome, String descricao, int power) : base(nome, descricao)
        {
            this.Power = power;
        }
        public int Power { get; set; }

        public void ShowDataPokemonPlus()
        {
            Console.WriteLine("Name: " + this.Nome);
            Console.WriteLine("Description: " + this.Descricao);
            Console.WriteLine("Power: " + this.Power);
        }
    }
}
