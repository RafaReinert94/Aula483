using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosLista
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> carrosLoja = new List<string>
            {
                "Corsa",
                "Celta",
                "207",
                "Onix",
                "Gol",
                "Golf",
            };

            carrosLoja.ForEach(x => Console.WriteLine(x));

            Console.ReadKey(true);

        }
    }
}
