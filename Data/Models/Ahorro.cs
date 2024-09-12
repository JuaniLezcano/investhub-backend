using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace investhub_backend.Data.Models
{
    public class Ahorro
    {
        [Key] // Clave primaria
        public int Id { get; set; }

        public float Cantidad { get; set; } = 0;

        public bool FlagUsd {  get; set; }
        [Required] // Exije que el dato pedido sea obligatorio
        public Portafolio Portafolio {  get; set; }
    }
}
