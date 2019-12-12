using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletim.Classe
{
    class Materia
    {
        public string Nome { get; set; }
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }
        public decimal Media { get { return MediaNotas(); } }
        public string Situacao { get { return Morte();} }

        public decimal MediaNotas()
        {
           return (Nota1 + Nota2 + Nota3) / 3;
        }

        private string Morte()
        {
            var media = MediaNotas();
            if (media >= 7)
            {
                return "Aprovado";
            }
            else
            {
                if (media >= 5)
                {
                    return "Exame";
                }
                else
                {
                    return "Reprovado";
                }
            }

        }
    }

}
