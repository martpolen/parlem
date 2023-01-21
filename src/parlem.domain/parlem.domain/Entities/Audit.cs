using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace parlem.domain.Entities
{
    public class Audit
    {
        public virtual ApplicationUser CreadoPor { get; set; }

        public virtual ApplicationUser ModificadoPor { get; set; }

        public virtual ApplicationUser BorradoPor { get; set; }

        [DisplayName("Fecha creación")]
        [Column(TypeName = "datetime")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy hh:mm}")]
        public DateTime? FechaInsert { get; set; }

        [DisplayName("Fecha Modificación")]
        [Column(TypeName = "datetime")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy hh:mm}")]
        public DateTime? FechaUpdate { get; set; }


        [Column(TypeName = "datetime")]
        public DateTime? FechaDelete { get; set; }

        [DisplayName("Creado por")]
        [StringLength(450)]
        [ForeignKey(nameof(CreadoPor))]
        public string UserInsert { get; set; }

        [DisplayName("Modificado por")]
        [StringLength(450)]
        [ForeignKey(nameof(ModificadoPor))]
        public string UserUpdate { get; set; }
    }
}
