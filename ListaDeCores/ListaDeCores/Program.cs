using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCores
{
    class Program
    {
       static List<string> ListaPrincipal = new List<string>();
        static void Main(string[] args)
        {
            ApresentacaoDoSistema();

            var numeroInformado = "0";

            while (numeroInformado != "3")
            {

                numeroInformado = MostrarMenu();

                switch (numeroInformado)
                {

                    case "1":
                        AdicionarCores();
                        break;
                    case "2":
                        ListarCores();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.Clear();
            }

        }

        private static void ApresentacaoDoSistema()
        {
            Console.WriteLine("Bem vindo ao rainbow");
            Console.WriteLine("-=-=-=-=--=-=-=-=-=-");
            Console.WriteLine("");
        }

        private static string MostrarMenu()
        {
            Console.WriteLine("1 - Adicionar uma fantastica cor no Rainbow");
            Console.WriteLine("2 - Listar as Rainbow's colors");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("Digite a opção desejada");
            return Console.ReadLine();
            

        }

        static void AdicionarCores()
        {
            Console.WriteLine("Digite a fantastica cor a ser adicionada");

            ListaPrincipal.Add(Console.ReadLine());

            Console.WriteLine("Cor adicionada ao Rainbow");

            Console.ReadKey(true);
        }

        static void ListarCores()
        {
            Console.WriteLine("Rainbow Abaixo");
            ListaPrincipal.ForEach(x => Console.WriteLine(x));

            Console.ReadKey(true);
      
        }
    }
}
