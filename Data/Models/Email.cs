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
        [Key]
        public int Id { get; set; }
        [Required] //Exije que el dato pedido sea obligatorio
        [EmailAddress] //Valida que lo que se ingresa es una direccion de email
        public string Direccion { get; set; }

        // ClienteId es la clave foránea
        public int ClienteId { get; set; }

        // La clave foránea ClienteId se relaciona con la propiedad Id de Cliente
        [ForeignKey(nameof(ClienteId))]
        public Cliente Cliente { get; set; }
    }
}
