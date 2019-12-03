using System;
using System.Collections.Generic;

namespace ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> minhaLista = new List<string>
            {
                "Felipe",
                "Rafael",
                "Bruno",
                "Bruna",
                "Dilceu",
                "Eduardo"
            };


            minhaLista.ForEach(x => Console.WriteLine(x));

            Console.ReadKey(true);
        }
    }
}
