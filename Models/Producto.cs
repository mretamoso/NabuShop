using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NabuShop.Models
{
    public class Producto
    {
        [Key]
        public int? ProductoId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(50)]
        public string? Codigo { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(255)]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(255)]
        public string? Modelo { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(1000)]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(255)]
        public string? Imagen { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria? Categoria { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(100)]
        public string? Marca { get; set; }

        [Required]
        public bool Estado { get; set; }

        public ICollection<Detalle_Pedido>? DetallesPedido {  get; set; }
    }
}
