using System.ComponentModel.DataAnnotations;

namespace NabuShop.Models
{
    public class Rol
    {
        [Key]
        public int RolId { get; set; }
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [StringLength(50)]
        public string? Nombre { get; set; }
    }
}
