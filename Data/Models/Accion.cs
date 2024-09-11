using System.ComponentModel.DataAnnotations;

namespace investhub_backend.Data.Models
{
    public class Accion
    {
        [Key]
        public int Id { get; set; }
        public int Cantidad { get; set; }
        [Required]
        public string Nombre { get; set; }
        public float precioActual { get; set; }
        public float precioCompra {  get; set; }
        [Required]
        public string Simbolo { get; set; }
        public TipoAccion TipoAccion { get; set; }
    }
}
