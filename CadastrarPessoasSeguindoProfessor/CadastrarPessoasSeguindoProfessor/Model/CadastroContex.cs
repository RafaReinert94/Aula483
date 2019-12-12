namespace CadastrarPessoasSeguindoProfessor.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CadastroContex : DbContext
    {

        public CadastroContex()
            : base("name=CadastroContex")
        {

        }


        public virtual DbSet<Pessoa> Pessoas { get; set; }

    }

}