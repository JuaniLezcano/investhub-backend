using investhub_backend.Data.Models;
using investhub_backend.DTO;

namespace investhub_backend.Services
{
	public interface IClienteServicio
	{
		Task<RespuestaInterna<bool>> AgregarAsync(Cliente cliente);
		Task<RespuestaInterna<List<Cliente>>> ObtenerAsync();
	}
}
