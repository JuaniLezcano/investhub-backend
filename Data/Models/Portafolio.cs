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
        [Key]
        public int Id {  get; set; }
        public int ClienteId { get; set; }
        [ForeignKey(nameof(ClienteId))]
        [Required]
        public Cliente Cliente { get; set; }
    }
}
