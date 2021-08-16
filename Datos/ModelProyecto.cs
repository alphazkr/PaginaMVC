using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Datos
{
    public partial class ModelProyecto : DbContext
    {
        public ModelProyecto()
            : base("name=ProyectoContext")
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
