using Microsoft.AspNetCore.Mvc;
using DbApi.Models;

namespace DbApi.Controllers
{
    [ApiController]
    [Route("Clientes]")]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterTodos()
        {
             //todo obter todos os clientes registrados no banco de dados

            List<Cliente> clientes = new List<Cliente>()
            {
                new Cliente()
                {
                    Nome = "Vitor", Email = "Vitor@email", Telefone= "746846", Endereco = "rua xpto"
                },

                new Cliente()
                {
                    Nome ="Camila", Email = "Camila@gmail.com", Telefone= "195999846", Endereco = "rua abc"
                },

                new Cliente()
                {
                    Nome = "Bruno", Email = "Bruno@email", Telefone= "0090989", Endereco = "rua dfg"
                }
            };

            return Ok(clientes);
        }

        [HttpPost]
        public IActionResult Criar([FromBody] Cliente cliente)
        {
           //todo : salvar cliente no banco de dados
            return Created();
        }
    }
}