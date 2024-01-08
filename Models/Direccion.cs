using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NabuShop.Models
{
    public class Direccion
    {
        [Key]
        public int DireccionId { get; set; }

        [Required]
        [StringLength(50)]
        public string? Addres { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(100)]
        public string? Distrito { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(100)]
        public string? Departamento { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(100)]
        public string? Provincia { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(10)]
        public int? CodigoPostal { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set;}
    }
}
