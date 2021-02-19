using System;

namespace AppSeries
{
    public class Filme : EntidadeBase
    {
        // Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Diretor { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        //Metodos
        //Construtor
        public Filme (int id, Genero genero, string titulo, string diretor, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Diretor = diretor;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }


      public override string ToString()
      {
         string retorno = "";
         retorno += "Genero: " + this.Genero + Environment.NewLine;
         retorno += "Título: " + this.Titulo + Environment.NewLine;
         retorno += "Diretor: " + this.Diretor + Environment.NewLine;
         retorno += "Descrição: " + this.Descricao + Environment.NewLine;
         retorno += "Ano: " + this.Ano + Environment.NewLine;
         retorno += "Excluido: " + this.Excluido;
         return retorno;
      }
    }
}