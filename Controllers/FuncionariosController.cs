
using DbApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbApi.Controllers
{
    [ApiController]
    [Route("funcionario")]
    //pode aparecer como api/[controller] esse cenario vai pegar o nome da controler  e remomover a palavra controller
    public class FuncionariosController : ControllerBase
    {
        private AppDbContext _context;

        public FuncionariosController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> ObterFuncionariosAsync ()
        {
            List<Funcionario> funcionarios = await _context.Funcionarios.ToListAsync();
            return Ok(funcionarios);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorIdAsync([FromRoute] string id)
        {
            Funcionario func = await  _context.Funcionarios.Where(f => f.Id == id).FirstOrDefaultAsync();
           //Funcionario func = await  _context.Funcionarios.FindAsync(id); //esse comentado so funciona com primary key ent eh bom saber os dois jeitos
            return Ok(func);
        }

        [HttpPost]
        public async Task<IActionResult> InserirFuncionarios([FromBody] Funcionario funcionario)
        {
           await _context.Funcionarios.AddAsync(funcionario);
            await _context.SaveChangesAsync(); //tem q por essa merda
            return Ok();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete ([FromRoute] string id)
        {
            Funcionario funcionario = await _context.Funcionarios.FindAsync(id);

            if(funcionario == null)
            {
                return NoContent();
            }

            _context.Funcionarios.Remove(funcionario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        public async Task<IActionResult> UpdateAsyncFuncionario([FromRoute] string id , [FromBody] Funcionario funcionarioAtualizado)
        {
            Funcionario funcionarioDB = await _context.Funcionarios.FindAsync(id);

            if(funcionarioDB == null)
            {
                return NotFound("Funcionario nao encontrado");
            }

            // funcionarioDB.Nome = funcionarioAtualizado.Nome;
            // funcionarioDB.Endereco= funcionarioAtualizado.Endereco;
            //ja fiiz isso na classe funcionario ent n precisa fazer aqui tbm

            funcionarioDB.Update(funcionarioAtualizado);

            _context.Funcionarios.Update(funcionarioDB);
            await _context.SaveChangesAsync();

           
           
            return Ok();
        }
    }
}