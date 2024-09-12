using System.ComponentModel.DataAnnotations;

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
        public int Id { get; set; }
        public int Cantidad { get; set; }
        [Required] // Exije que el dato pedido sea obligatorio
        public string Nombre { get; set; }
        public float precioActual { get; set; }
        public float precioCompra {  get; set; }
        [Required] // Exije que el dato pedido sea obligatorio
        public string Simbolo { get; set; }
        public TipoAccion TipoAccion { get; set; } // Clase enumerativa creada con anterioridad
    }
}
