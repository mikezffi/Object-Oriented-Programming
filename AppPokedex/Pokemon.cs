using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokedex
{
    public class Pokemon
    {
        //Construtores (constructors)
        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }

        public Pokemon(String nome, String descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

        //Atributos (Properties)
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private String descricao;

        public String Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }

        //Métodos (Methods)
        public void ShowDataPokemon()
        {
            Console.WriteLine("Name: " + this.Nome);
            Console.WriteLine("Description: " + this.Descricao);
        }
        public void ShowDataPokemon(Boolean formatado)
        {
            if (formatado == true)
            {
                Console.WriteLine("Pokémon " + this.Nome + ": " + this.Descricao);
            }
            else
            {
                Console.WriteLine("Name: " + this.Nome);
                Console.WriteLine("Description: " + this.Descricao);
            }
        }
    }
}
