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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AhorroId { get; set; }

        public float Cantidad { get; set; } = 0;

        public Moneda tipoMoneda {  get; set; }
        public int PortafolioId { get; set; } // Clave foranea a Portafolio
        [ForeignKey("PortafolioId")]
        public virtual Portafolio Portafolio {  get; set; }
    }
}
