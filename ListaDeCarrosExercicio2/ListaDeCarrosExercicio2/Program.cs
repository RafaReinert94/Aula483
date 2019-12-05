using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCarrosExercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> ListaDeCarros = new List<string>
            {
                "Corsa fodalhão 2004",
                "Celta perdedor pra corsa 2004",
                "HB20 boy 2016",
                "BMW chavoso 2018",
                "Mercedes só que onibus 1990"
            };

            Console.WriteLine("Lista de viaturas");
            ListaDeCarros.ForEach(x => Console.WriteLine(x));

            Console.ReadKey(true);


        }
    }
}
