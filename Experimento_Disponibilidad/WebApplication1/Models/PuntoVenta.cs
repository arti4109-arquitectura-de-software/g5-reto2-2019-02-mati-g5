namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PuntoVenta")]
    public partial class PuntoVenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPunto { get; set; }

        [Required]
        [StringLength(50)]
        public string NombrePunto { get; set; }
    }
}