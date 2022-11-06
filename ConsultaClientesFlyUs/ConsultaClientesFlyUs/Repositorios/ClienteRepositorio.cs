using ConsultaClientesFlyUs.Data;
using ConsultaClientesFlyUs.Models;
using ConsultaClientesFlyUs.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConsultaClientesFlyUs.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly SistemaClientesDBContex _dbContext;
        public ClienteRepositorio(SistemaClientesDBContex sistemaClientesDBContex)
        {
            _dbContext = sistemaClientesDBContex;
        }

        public async Task<ClienteModel> BuscarPorId(int id)
        {
            return await _dbContext.Cliente.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ClienteModel>> BuscarTodosClientes()
        {
            return await _dbContext.Cliente.ToListAsync();
        }
    }
}
