using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace investhub_backend.Data.Models
{
    public enum Moneda
    {
        Pesos,
        Dolares
    }
    public class Ahorro
    {
        [Key] // Clave primaria
        public int Id { get; set; }

        public float Cantidad { get; set; } = 0;

        public Moneda tipoMoneda {  get; set; }
        [Required] // Exije que el dato pedido sea obligatorio
        public int PortafolioId { get; set; } // Clave foranea a Portafolio
        public Portafolio Portafolio {  get; set; }
    }
}
