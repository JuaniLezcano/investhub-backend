using investhub_backend.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace investhub_backend.Controllers
{
    [ApiController] //Indica que la clase es un controlador de api
    [Route("[controller]")] //Define la ruta donde llegaran las solicitudes, en este caso se reemplaza automaticamente con /Cliente
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger; //logger es el registro de mensajes
        private static List<Cliente> clientes = new List<Cliente>(); //Por el momento esto es una lista estatica, al tener una bd deberiamos de reemplazarlo

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger; //Inicializa el registro de eventos y errores 
        }

        // Obtener todos los clientes
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> GetClientes() //Los IEnumerables son tipos de colecciones ( En este caso le estoy pidiendo que me devuelva una coleccion de clientes)
        {
            return Ok(clientes);
        }

        // Obtener un cliente por Id
        [HttpGet("{id}")]
        public ActionResult<Cliente> GetCliente(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == id); //Hago una consulta para encontrar el cliente 
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        // Agregar un nuevo cliente
        [HttpPost]
        public ActionResult<Cliente> PostCliente(Cliente cliente)
        {
            cliente.Id = clientes.Count > 0 ? clientes.Max(c => c.Id) + 1 : 1; // Generar un Id, si ya existe el cliente toma el id mas grande y le suma 1
            clientes.Add(cliente);
            return CreatedAtAction(nameof(GetCliente), new { id = cliente.Id }, cliente);
        }

        // Actualizar un cliente existente
        [HttpPut("{id}")]
        public IActionResult PutCliente(int id, Cliente updatedCliente)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            cliente.Usuario = updatedCliente.Usuario;
            cliente.Password = updatedCliente.Password;

            return NoContent();
        }

        // Eliminar un cliente
        [HttpDelete("{id}")]
        public IActionResult DeleteCliente(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            clientes.Remove(cliente);
            return NoContent();
        }
    }
}
