using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Practica2.Models.Entity
{
    public partial class Model3 : DbContext
    {
        public Model3()
            : base("name=Model3")
        {
        }

        public virtual DbSet<TblUbicacion> TblUbicacion { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblUbicacion>()
                .Property(e => e.cPais)
                .IsUnicode(false);

            modelBuilder.Entity<TblUbicacion>()
                .Property(e => e.cCiudad)
                .IsUnicode(false);

            modelBuilder.Entity<TblUbicacion>()
                .Property(e => e.cTipoAvistamiento)
                .IsUnicode(false);

            modelBuilder.Entity<TblUbicacion>()
                .Property(e => e.cDescripción)
                .IsUnicode(false);

            modelBuilder.Entity<TblUbicacion>()
                .Property(e => e.cEstatus)
                .IsUnicode(false);
        }
    }
}
