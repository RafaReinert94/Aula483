namespace SistemaControleEstoque.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SistemaContext : DbContext
    {

        public SistemaContext()
            : base("name=SistemaContext")
        {
        }


        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Estoque> Estoques { get; set; }
    }


}