using Business.Service;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : Controller
    {
        private readonly Context _context;
        public FuncionariosController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("ListarFuncionarios")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var funcionario = await new FuncionarioService(_context)
                    .ListarFuncionario();

                return Ok(funcionario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpPost]
        [Route("GravarFuncionario")]
        public IActionResult Set(Funcionarios funcionario)
        {
            try
            {
                new FuncionarioService(_context).GravarFuncionario(funcionario);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
    }
}
