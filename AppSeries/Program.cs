//Desafio: Fazer Classe filme e Repositorio Filme

using System;

namespace AppSeries
{
    class Program
    {
        static SerieRepositorio repositorioSerie = new SerieRepositorio();
        static FilmeRepositorio repositorioFilme = new FilmeRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        Console.ReadKey();
                        break;
                    case "2":
                        InserirSerie();
                        Console.ReadKey();
                        break;
                    case "3":
                        AtualizarSerie();
                        Console.ReadKey();
                        break;
                    case "4":
                        ExcluirSerie();
                        Console.ReadKey();
                        break;
                    case "5":
                        VizualizarSerie();
                        Console.ReadKey();
                        break;
                    case "6":
                        ListarFilmes();
                        Console.ReadKey();
                        break;
                    case "7":
                        InserirFilme();
                        Console.ReadKey();
                        break;
                    case "8":
                        AtualizarFilme();
                        Console.ReadKey();
                        break;
                    case "9":
                        ExcluirFilme();
                        Console.ReadKey();
                        break;
                    case "10":
                        VizualizarFilme();
                        Console.ReadKey();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.WriteLine();
        }

        //FILMES
        private static void ListarFilmes()
        {
            Console.WriteLine("Listar filmes");

            var lista = repositorioFilme.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado.");
                return;
            }

            foreach (var filme in lista)
            {
                var excluido = filme.retornaExcluido();
                Console.WriteLine("#ID {0}: - {1} {2}", filme.retornaId(), filme.retornaTitulo(), excluido ? "Excluido*" : "");
            }
        }
        private static void InserirFilme()
        {
            Console.WriteLine("Inserir novo filme");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("#ID: {0} - {1}", i, Enum.GetName(typeof(Genero), i) );
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o nome do Diretor: ");
            string entradaDiretor = Console.ReadLine();

            Console.Write("Digite o Ano ddo Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme novoFilme = new Filme(id: repositorioFilme.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        diretor: entradaDiretor,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioFilme.Insere(novoFilme);
        }
        private static void AtualizarFilme()
        {
            Console.WriteLine("Atualizar filme");
            Console.Write("Digite o id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o nome do Diretor: ");
            string entradaDiretor = Console.ReadLine();

            Console.Write("Digite o Ano do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme atualizaFilme = new Filme(id: indiceFilme,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        diretor: entradaDiretor,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioFilme.Atualiza(indiceFilme, atualizaFilme);
        }
        private static void ExcluirFilme()
        {
            Console.WriteLine("Excluir filme");
            Console.Write("Digite o id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());
            var filme = repositorioFilme.RetornaPorId(indiceFilme);

            Console.WriteLine("Tem certeza que deseja excluir o filme {0}?", filme.retornaTitulo());
            Console.WriteLine();
            Console.Write("Digite Y para confirmar ou N para confirmar a exclusão: ");
            string input = Console.ReadLine().ToUpper();

            if (input == "N")
            {
                return;
            }
            if (input == "Y")
            {
                repositorioFilme.Exclui(indiceFilme);   
            }
        }
        private static void VizualizarFilme()
        {
            Console.WriteLine("Vizualizar filme");
            Console.Write("Digite o id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            var filme = repositorioFilme.RetornaPorId(indiceFilme);

            Console.WriteLine(filme);
        }

        //SERIES
        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = repositorioSerie.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), excluido ? "Excluido*" : "");
            }
        }
        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("#ID: {0} - {1}", i, Enum.GetName(typeof(Genero), i) );
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorioSerie.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioSerie.Insere(novaSerie);
        }
        private static void AtualizarSerie()
        {
            Console.WriteLine("Atualizar série");
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioSerie.Atualiza(indiceSerie, atualizaSerie);
        }
        private static void ExcluirSerie()
        {
            Console.WriteLine("Excluir série");
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            var serie = repositorioSerie.RetornaPorId(indiceSerie);

            Console.WriteLine("Tem certeza que deseja excluir a série {0}?", serie.retornaTitulo());
            Console.WriteLine();
            Console.Write("Digite Y para confirmar ou N para confirmar a exclusão: ");
            string input = Console.ReadLine().ToUpper();

            if (input == "N")
            {
                return;
            }
            if (input == "Y")
            {
                repositorioSerie.Exclui(indiceSerie);   
            }
        }
        private static void VizualizarSerie()
        {
            Console.WriteLine("Vizualizar série");
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorioSerie.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("CMD-FLIX a seu dispor!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine();

            Console.WriteLine("Séries --------------------");
            Console.WriteLine("1 - Listar Séries");
            Console.WriteLine("2 - Inserir nova Série");
            Console.WriteLine("3 - Atualizar Série");
            Console.WriteLine("4 - Excluir Série");
            Console.WriteLine("5 - Vizualizar Série");
            Console.WriteLine();

            Console.WriteLine("Filmes --------------------");
            Console.WriteLine("6 - Listar Filmes");
            Console.WriteLine("7 - Inserir nova Filme");
            Console.WriteLine("8 - Atualizar Filme");
            Console.WriteLine("9 - Excluir Filme");
            Console.WriteLine("10 - Vizualizar Filme");
            Console.WriteLine();

            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}