using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace investhub_backend.Data.Models
{
    public class Email
    {
        [Key] // Clave primaria
        public int Id { get; set; }
        [Required] // Exije que el dato pedido sea obligatorio
        [EmailAddress] //Valida que lo que se ingresa es una direccion de email
        public string Direccion { get; set; }
        public Cliente cliente { get; set; }
    }
}
