using investhub_backend.Data.Models;
using investhub_backend.DTO;
using investhub_backend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace investhub_backend.Controllers
{
    [ApiController] //Indica que la clase es un controlador de api
    [Route("[controller]")] //Define la ruta donde llegaran las solicitudes, en este caso se reemplaza automaticamente con /Cliente
    public class ClienteController : ControllerBase
    {
		private readonly ILogger<ClienteController> _logger;  //logger es el registro de mensajes
		private readonly IClienteServicio _clienteServicio; //Instancia de la interfaz, nos permite acceder a los metodos que definimos en ella

		public ClienteController(IClienteServicio clienteServicio, ILogger<ClienteController> logger)
		{
			_clienteServicio = clienteServicio; //Inicializa el servicio que maneja la logica de clientes ( a traves de el llamamos a los metodos definidos en la interfaz)
			_logger = logger; //Inicializa el registro de eventos y errores 
        }

		// Obtener todos los clientes
		[HttpGet(Name = "GetClientes")]
		public async Task<ActionResult<RespuestaExterna<List<Cliente>>>> Get()
		{
			var respuesta = new RespuestaExterna<List<Cliente>>();
			try
			{
				var respuestaInterna = await _clienteServicio.ObtenerAsync();
				if (respuestaInterna.Exito)
				{
					respuesta.Exito = true;
					respuesta.MensajePublico = "Clientes recuperados correctamente";
					respuesta.Datos = respuestaInterna.Datos;
					return respuesta;
				}
				else
				{
					respuesta.MensajePublico = "Hubo un error al recuperar los clientes";
					return BadRequest(respuesta);
				}
			}
			catch (Exception ex)
			{
				respuesta.MensajePublico = "Hubo un error al recuperar los clientes";
				return StatusCode(StatusCodes.Status500InternalServerError, respuesta);
			}
		}

		// Agregar un nuevo cliente
		[HttpPost(Name = "PostCliente")]
		public async Task<ActionResult<RespuestaExterna<bool>>> Post(Cliente cliente)
		{
            var respuesta = new RespuestaExterna<bool>();
            try
            {
                var respuestaInterna = await _clienteServicio.AgregarAsync(cliente);
                if (respuestaInterna.Exito)
                {
                    respuesta.Exito = true;
                    respuesta.Datos = true;
                    return StatusCode(StatusCodes.Status201Created, respuesta);
                }
                else
                {
                    respuesta.MensajePublico = "Intente colocar otro CUIT.";
                    return BadRequest(respuesta);
                }
            }
            catch (Exception ex)
            {
                respuesta.MensajePublico = "Ocurrio un error al agregar al Cliente.";
                return StatusCode(StatusCodes.Status500InternalServerError, respuesta);
            }
        }
    }
}
