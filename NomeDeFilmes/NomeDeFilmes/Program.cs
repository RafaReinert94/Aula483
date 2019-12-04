using System;
using System.Collections.Generic;

namespace NomeDeFilmes
{
    class Program
    {
        static List<string> NomeDeFilmes = new List<string>();
        static void Main(string[] args)
        {
            MensagemInicial();

            var opcaoSelecionada = "0";

            while (opcaoSelecionada != "5")
            {
                opcaoSelecionada = MostrarMenu();

                switch (opcaoSelecionada)
                {
                    case "1":
                        DigitarFilme();
                        break;
                    case "2":
                        ListarFilmes();
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                Console.Clear();
            }


        }

        private static string MostrarMenu()
        {
            Console.WriteLine("Digite o numero da opção desejada");
            Console.WriteLine("1 - Adicionar Filmes");
            Console.WriteLine("2 - Listar Filmes");
            Console.WriteLine("3 - Editar os Filmes");
            Console.WriteLine("4 - Excluir um Filme");
            Console.WriteLine("5 - Sair do Sistema");

            return Console.ReadLine(); ;
        }

        private static void MensagemInicial()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Top Movies");
            Console.WriteLine("--------------------");
        }

        private static void ListarFilmes()
        {
            Console.WriteLine("Listagem do melhores filmes");
            NomeDeFilmes.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Lista carregada com sucesso");
            Console.ReadKey(true);
        }

        private static void DigitarFilme()
        {
            Console.WriteLine("Digite o nome do Melhor Filme");
            var filmeDigitado = Console.ReadLine();
            NomeDeFilmes.Add(filmeDigitado);
            Console.WriteLine("Filme adicionado com sucesso");
            Console.ReadKey(true);
        }
    }
}
