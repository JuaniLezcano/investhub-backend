using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace investhub_backend.Data.Models
{
    public class Portafolio
    {
        [Key] // Clave primaria
        public int Id {  get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<Accion> Acciones { get; set; }
        public List<Ahorro> Ahorros { get; set; }
    }
}
