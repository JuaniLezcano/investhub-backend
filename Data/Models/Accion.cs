using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace investhub_backend.Data.Models
{
    public enum TipoAccion
    {
        Accion,
        ETF,
        Cedear
    }
    public class Accion
    {
        [Key] // Clave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccionId { get; set; }
        public int Cantidad { get; set; }
        [Required] // Exije que el dato pedido sea obligatorio
        public string Nombre { get; set; }
        public float PrecioCompra {  get; set; }
        [Required] // Exije que el dato pedido sea obligatorio
        public string Simbolo { get; set; }
        public TipoAccion TipoAccion { get; set; } // Clase enumerativa creada con anterioridad
        public int PortafolioId { get; set; } // Clave foranea a Portafolio
        [ForeignKey("PortafolioId")]
        public virtual Portafolio Portafolio { get; set; }
    }
}
