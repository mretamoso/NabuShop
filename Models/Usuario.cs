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
        [Required]
        [StringLength(50)]
        public string? Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string? Apellido { get; set;}
        [Required]
        [MaxLength(15)]
        public int? Telefono { get; set; }
        [Required]
        [StringLength(50)]
        public string? NombreUsuario { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [MaxLength(20, ErrorMessage = "La contraseña debe tener como máximo {1} caracteres.")]
        [MinLength(15, ErrorMessage = "La contraseña debe tener como mínimo {1} caracteres.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9]).{15,20}$", ErrorMessage = "La contraseña no cumple con los requisitos.")]
        public string? Contrasenia { get; set; }
        [Required]
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "La dirección de correo electrónico no es válida")]
        public string? Correo { get; set; }
        [Required]
        [StringLength(100)]
        public string? Direccion { get; set; }
        [Required]
        [StringLength(100)]
        public string? Distrito { get; set; }
        [Required]
        [StringLength(100)]
        public string? Departamento { get; set; }
        [Required]
        [StringLength(100)]
        public string? Provincia { get; set; }
        [Required]
        [MaxLength(10)]
        public int? CodigoPostal { get; set; }
        [Required]
        public bool? Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        [Required]
        public int RolId { get; set; }
        [ForeignKey("RolId")]
        public Rol? Rol { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
        [InverseProperty("Usuario")]
        public ICollection<Direccion>? Direcciones { get; set; }
        
    }
}
