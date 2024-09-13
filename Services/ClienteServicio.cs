using investhub_backend.Data.Models;
using investhub_backend.DbContextInvesthub;
using investhub_backend.DTO;
using Microsoft.EntityFrameworkCore;

namespace investhub_backend.Services
{
    public class ClienteServicio : IClienteServicio
	{
        private InvesthubDBContext _dbContext;
        public ClienteServicio()
        {
            _dbContext = new InvesthubDBContext();
        }
        public async Task<RespuestaInterna<bool>> AgregarAsync(Cliente cliente)
        {
            var respuesta = new RespuestaInterna<bool>();
            var clienteExiste = await _dbContext.Cliente.FirstOrDefaultAsync(c => c.Id == cliente.Id);
			if (clienteExiste != null)
			{
				respuesta.Mensaje = "El cliente ya existe";
				return respuesta;
			}
			try
			{
				await _dbContext.Cliente.AddAsync(cliente);
				await _dbContext.SaveChangesAsync();
				respuesta.Exito = true;
				respuesta.Datos = true;
				return respuesta;
			}
			catch
			{
				return respuesta;
			}
		}

		public async Task<RespuestaInterna<List<Cliente>>> ObtenerAsync()
		{
			var respuesta = new RespuestaInterna<List<Cliente>>();
			try
			{
				var clientes = await _dbContext.Cliente.ToListAsync();
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

