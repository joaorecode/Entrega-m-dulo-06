using ConsultaClientesFlyUs.Models;
using ConsultaClientesFlyUs.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaClientesFlyUs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteControler : ControllerBase
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        public ClienteControler(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClienteModel>>> BuscarTodosClientes()       
        {
            List<ClienteModel> clientes = await _clienteRepositorio.BuscarTodosClientes();
            return Ok(clientes);
        }
    }
}
