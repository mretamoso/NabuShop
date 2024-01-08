using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NabuShop.Models
{
    public class Usuario
    {
        public Usuario()
        {
            Pedidos=new List<Pedido>();
            FechaRegistro=DateTime.Now;
        }

        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(50)]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(50)]
        public string? Apellido { get; set;}

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(15)]
        public int? Telefono { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(50)]
        public string? NombreUsuario { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [MaxLength(20, ErrorMessage = "La contraseña debe tener como máximo {1} caracteres.")]
        [MinLength(15, ErrorMessage = "La contraseña debe tener como mínimo {1} caracteres.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9]).{15,20}$", ErrorMessage = "La contraseña no cumple con los requisitos.")]
        public string? Contrasenia { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "La dirección de correo electrónico no es válida")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(100)]
        public string? Direccion { get; set; }

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

        public DateTime FechaRegistro { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int RolId { get; set; }

        [ForeignKey("RolId")]
        public Rol? Rol { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

        [InverseProperty("Usuario")]
        public ICollection<Direccion>? Direcciones { get; set; }
        
    }
}
