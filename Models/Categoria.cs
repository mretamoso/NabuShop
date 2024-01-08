using System.ComponentModel.DataAnnotations;

namespace NabuShop.Models
{
    public class Categoria
    {
        public Categoria()
        {
            Productos=new List<Producto>();
        }

        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage="El campo {0} es obligatorio")]
        [StringLength(50)]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(1000)]
        public string? Descripcion { get; set; }

        public ICollection<Producto> Productos { get; set; }
    }
}
