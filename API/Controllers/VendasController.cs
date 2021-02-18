using Business.Service;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;

namespace API.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : Controller
    {
        private readonly Context _context;
        public VendasController(Context context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("GravarVenda")]
        public IActionResult GravarVenda([FromBody] Vendas vendas)
        {
            try
            {
                new VendaService(_context)
                    .GravarVenda(vendas);

                return Ok(vendas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("GravarSaidaVenda")]
        public IActionResult GravaSaidaVenda([FromBody] List<SaidaVenda> saidaVendas)
        {
            try
            {
                new VendaService(_context)
                    .GravarSaidaVenda(saidaVendas);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
