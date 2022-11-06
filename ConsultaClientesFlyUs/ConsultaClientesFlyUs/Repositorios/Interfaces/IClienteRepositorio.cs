using ConsultaClientesFlyUs.Models;

namespace ConsultaClientesFlyUs.Repositorios.Interfaces
{
    public interface IClienteRepositorio
    {
        Task<List<ClienteModel>> BuscarTodosClientes();
        Task<ClienteModel> BuscarPorId(int id);
    }
}
