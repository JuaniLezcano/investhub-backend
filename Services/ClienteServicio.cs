using investhub_backend.Data.Models;
using investhub_backend.DbContextInvesthub;
using investhub_backend.DTO;
using Microsoft.EntityFrameworkCore;

namespace investhub_backend.Services
{
    public class ClienteServicio : IClienteServicio //La clase que implementa el servicio mediante la interfaz (que es donde estan definidos los metodos)
	{
        private InvesthubDBContext _dbContext; //Instancia del contexto de la bd que maneja la interaccion con la base de datos
        public ClienteServicio(InvesthubDBContext dbContext)
        {
            _dbContext = dbContext; //Inicializamos la instancia de Investhub, esto permite acceder a la bd
        }
        public async Task<RespuestaInterna<bool>> AgregarAsync(ClienteDTO clientedto) //Instancia de la respuesta interna
        {
            var respuesta = new RespuestaInterna<bool>();
            var clienteExiste = await _dbContext.Cliente.FirstOrDefaultAsync(c => c.Usuario == clientedto.Usuario); //Aca primero busca por id si el cliente existe, si lo encuentra devuelve que ya existe
			if (clienteExiste != null)
			{
				respuesta.Mensaje = "El cliente ya existe";
				return respuesta;
			}
			try
			{
				var cliente = new Cliente //Creo un cliente para pasarle los datos del dto y agregarlo al dbContext
				{
					ClienteId = clientedto.ClienteId,
					Usuario	= clientedto.Usuario,
					EmailId = clientedto.EmailId,
					Password = clientedto.Password,
					PortafolioId = clientedto.PortafolioId,
				};

				await _dbContext.Cliente.AddAsync(cliente); //Si no existe lo agregamos aca
				await _dbContext.SaveChangesAsync(); //Persiste en la bd
				respuesta.Exito = true;
				respuesta.Datos = true;
				return respuesta;
			}
			catch(Exception ex) //Si ocurre un error devuelve la respuesta sin exito
			{
				respuesta.Mensaje = ex.Message;
				return respuesta;
			}
		}

		public async Task<RespuestaInterna<List<ClienteDTO>>> ObtenerAsync()
		{
			var respuesta = new RespuestaInterna<List<ClienteDTO>>(); 
			try
			{
				var clientes = await _dbContext.Cliente.ToListAsync(); //Utilizamos el metodo para convertir todos los clientes a una lista
				var clienteDtos = clientes.Select(c => new ClienteDTO
				{
					ClienteId = c.ClienteId,
					Usuario = c.Usuario,
					Password = c.Password,
					PortafolioId= c.PortafolioId,
					EmailId= c.EmailId,
				}).ToList();

				respuesta.Datos = clienteDtos;
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

