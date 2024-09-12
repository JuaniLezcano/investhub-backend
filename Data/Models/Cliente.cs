using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace investhub_backend.Data.Models
{
    public class Cliente
    {
        [Key] // Clave primaria
        public int Id { get; set; }
        [Required] // Exije que el dato pedido sea obligatorio
        public string Usuario { get; set; }
        [Required] // Exije que el dato pedido sea obligatorio
        public string Password { get; set; }
        public int EmailId { get; set; }
        public Email Email { get; set; }
        public int PortafolioId { get; set; }
        public Portafolio Portafolio { get; set; }

    }
}
