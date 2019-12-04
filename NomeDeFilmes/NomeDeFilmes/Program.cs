using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeDeFilmes
{
    class Program
    {
        static List<string> NomeDeFilmes = new List<string>();
        static void Main(string[] args)
        {

            Console.WriteLine("--------------------");
            Console.WriteLine("Top Movies");
            Console.WriteLine("--------------------");


            var opcaoSelecionada = "0";

            while (opcaoSelecionada != "5")
            {

                Console.WriteLine("Digite o numero da opção desejada");
                Console.WriteLine("1 - Adicionar Filmes");
                Console.WriteLine("2 - Listar Filmes");
                Console.WriteLine("3 - Editar os Filmes");
                Console.WriteLine("4 - Excluir um Filme");
                Console.WriteLine("5 - Sair do Sistema");

                opcaoSelecionada = Console.ReadLine();

                switch (opcaoSelecionada)
            {
                case "1":
                    Console.WriteLine("Digite o nome do Melhor Filme");
                    var filmeDigitado = Console.ReadLine();
                    NomeDeFilmes.Add(filmeDigitado);
                    Console.WriteLine("Filme adicionado com sucesso");
                    Console.ReadKey(true);
                    break;
                case "2":
                    Console.WriteLine("Listagem do melhores filmes");
                    NomeDeFilmes.ForEach(x => Console.WriteLine(x));
                    Console.WriteLine("Lista carregada com sucesso");
                    Console.ReadKey(true);
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
                Console.Clear();
            }


        }
    }
}
