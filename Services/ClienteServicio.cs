using investhub_backend.Data.Models;
using investhub_backend.DbContextInvesthub;
using investhub_backend.DTO;
using Microsoft.EntityFrameworkCore;

namespace investhub_backend.Services
{
    public class ClienteServicio : IClienteServicio //La clase que implementa el servicio mediante la interfaz (que es donde estan definidos los metodos)
	{
        private InvesthubDBContext _dbContext; //Instancia del contexto de la bd que maneja la interaccion con la base de datos
        public ClienteServicio()
        {
            _dbContext = new InvesthubDBContext(); //Inicializamos la instancia de Investhub, esto permite acceder a la bd
        }
        public async Task<RespuestaInterna<bool>> AgregarAsync(Cliente cliente) //Instancia de la respuesta interna
        {
            var respuesta = new RespuestaInterna<bool>();
            var clienteExiste = await _dbContext.Cliente.FirstOrDefaultAsync(c => c.Id == cliente.Id); //Aca primero busca por id si el cliente existe, si lo encuentra devuelve que ya existe
			if (clienteExiste != null)
			{
				respuesta.Mensaje = "El cliente ya existe";
				return respuesta;
			}
			try
			{
				await _dbContext.Cliente.AddAsync(cliente); //Si no existe lo agregamos aca
				await _dbContext.SaveChangesAsync(); //Persiste en la bd
				respuesta.Exito = true;
				respuesta.Datos = true;
				return respuesta;
			}
			catch //Si ocurre un error devuelve la respuesta sin exito
			{
				return respuesta;
			}
		}

		public async Task<RespuestaInterna<List<Cliente>>> ObtenerAsync()
		{
			var respuesta = new RespuestaInterna<List<Cliente>>(); 
			try
			{
				var clientes = await _dbContext.Cliente.ToListAsync(); //Utilizamos el metodo para convertir todos los clientes a una lista
				respuesta.Datos = clientes;
				respuesta.Exito = true;
				return respuesta;
			}
			catch (Exception ex)
			{
				respuesta.Mensaje = ex.Message;
				return respuesta;
			}

		}

	}

}

