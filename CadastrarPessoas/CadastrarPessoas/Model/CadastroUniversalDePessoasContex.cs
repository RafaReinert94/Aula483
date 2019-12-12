namespace CadastrarPessoas.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CadastroUniversalDePessoasContex : DbContext
    {

        public CadastroUniversalDePessoasContex()
            : base("name=CadastroUniversalDePessoasContex1")
        {
        }

        public virtual DbSet<Pessoa> Pessoas { get; set; }
    }

    
}