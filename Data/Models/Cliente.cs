using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }

        public Email Email { get; set; }

    }
}
