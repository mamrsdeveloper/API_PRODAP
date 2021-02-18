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
    public class ProdutosController : ControllerBase
    {
        private readonly Context _context;
        public ProdutosController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("ListarProdutos")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var vendas = await new ProdutoService(_context)
                    .ListarProdutos();

                return Ok(vendas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("GravarProdutos")]
        public IActionResult GravarProduto(Produtos produtos)
        {
            try
            {
                new ProdutoService(_context)
                     .GravarProdutos(produtos);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("GravarEstoque")]
        public IActionResult GravarEstoque(Estoque estoque)
        {
            try
            {
                new ProdutoService(_context)
                     .GravarEstoque(estoque);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
