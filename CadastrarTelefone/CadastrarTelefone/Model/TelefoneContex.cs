namespace CadastrarTelefone.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TelefoneContex : DbContext
    {

        public TelefoneContex()
            : base("name=TelefoneContex")
        {
        }

        public virtual DbSet<Telefone> Telefones {get;set;}
    }

}