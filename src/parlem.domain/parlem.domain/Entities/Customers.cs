using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace parlem.domain.Entities
{
    public class Customers : Audit
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Tipo de documento")]
        public string DocType { get; set; }
        [DisplayName("Documento")]
        public string DocNum { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("CustomerId")]
        public int CustomerId { get; set; }

        [ForeignKey("Secciones")]
        public int IdSeccion { get; set; }

        [DisplayName("Nombre")]
        public string GivenName { get; set; }
        [DisplayName("Apellido")]
        public string FamilyName { get; set; }
        [DisplayName("Teléfono")]
        public string phone { get; set; }
    }

}
