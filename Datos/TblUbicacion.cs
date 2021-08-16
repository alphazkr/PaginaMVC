namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblUbicacion")]
    public partial class TblUbicacion
    {
        [Key]
        [StringLength(50)]
        public string cPais { get; set; }

        [StringLength(50)]
        public string cCiudad { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dFecha { get; set; }

        public int? nHora { get; set; }

        [StringLength(50)]
        public string cTipoAvistamiento { get; set; }

        [StringLength(500)]
        public string cDescripción { get; set; }

        [StringLength(50)]
        public string cEstatus { get; set; }

        public int? nId_Usuario { get; set; }
    }
}
