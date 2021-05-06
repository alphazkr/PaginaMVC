namespace Practica2.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("usuario")]
    public partial class usuario
    {
        public int id { get; set; }

        [StringLength(50)]
        public string cNombre { get; set; }

        [StringLength(50)]
        public string cPassword { get; set; }

        [StringLength(50)]
        public string dFecha { get; set; }
    }
}
