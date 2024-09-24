using investhub_backend.Data.Models;
using investhub_backend.DTO;

namespace investhub_backend.Services
{
	public interface IClienteServicio
	{
		Task<RespuestaInterna<bool>> AgregarAsync(ClienteDTO clientedto); //Recibimos un objeto de tipo clienteDTO, si es correcto devuelve true en el dto sino false
		Task<RespuestaInterna<List<ClienteDTO>>> ObtenerAsync(); //Devolvemos una lista de clientes
	}
}