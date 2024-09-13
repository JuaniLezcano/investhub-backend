using investhub_backend.Data.Models;
using investhub_backend.DTO;

namespace investhub_backend.Services
{
	public interface IClienteServicio
	{
		Task<RespuestaInterna<bool>> AgregarAsync(Cliente cliente); //Recibimos un objeti de tipo cliente, si es correcto devuelve true en el dto sino false
		Task<RespuestaInterna<List<Cliente>>> ObtenerAsync(); //Devolvemos una lista de clientes
	}
}

//