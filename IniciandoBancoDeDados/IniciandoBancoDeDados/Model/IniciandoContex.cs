namespace IniciandoBancoDeDados.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class IniciandoContex : DbContext
    {

        public IniciandoContex()
            : base("name=IniciandoContex")
        {

        }

        public virtual DbSet<Bebida> Bebidas { get; set; }

    }


}