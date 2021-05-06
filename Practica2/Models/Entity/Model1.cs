using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Practica2.Models.Entity
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ModeloPruebaUsuario")
        {
        }

        public virtual DbSet<usuario> usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<usuario>()
                .Property(e => e.cNombre)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.cPassword)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.dFecha)
                .IsUnicode(false);
        }
    }
}
