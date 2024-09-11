using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Models
{
    public class Email
{
    [Key]
    public int Id { get; set; }
    [Required]
    [EmailAddress]
    public string Direccion { get; set; }
    
    // Relación uno a uno con Cliente
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }
}
}
