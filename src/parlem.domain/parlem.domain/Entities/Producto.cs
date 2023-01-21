using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace parlem.domain.Entities
{
    public class Producto : Audit
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Nombre")]
        public string ProductName { get; set; }
        [DisplayName("Tipo")]
        public string ProductTypeName { get; set; }
        [DisplayName("Numero Terminal")]
        public int numeracioTerminal { get; set; }
        [DisplayName("Fecha Venta")]
        public DateTime SoldAt { get; set; }

        [DisplayName("Cliente")]
        [ForeignKey("Customers")]
        public int CustomerId { get; set; }


        [ForeignKey("Secciones")]
        public int IdSeccion { get; set; }

        [DisplayName("Nomnbre")]
        public string FamilyName { get; set; }
        [DisplayName("Teléfono")]
        public string phone { get; set; }

        public virtual Customers Customers { get; set; }


    }

}
