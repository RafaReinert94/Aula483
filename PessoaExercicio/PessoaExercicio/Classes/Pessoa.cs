using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaExercicio.Classes
{
    class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Felicidade { get { return PodeSerFeliz(); } }

            

        private string PodeSerFeliz()
        {
            //int ano = DateTime.Now.Year;
            //int anoNascimento = DataDeNascimento.Year;
            //if (ano - anoNascimento >= 18)
            if (DateTime.Now.Year - DataDeNascimento.Year >= 18)
            {
                return "Pode beber e ser feliz";
            }
            else
            {
                return "Não pode beber, porém não chore pois exite Coca-Cola";
            }
        }    
    }
}
