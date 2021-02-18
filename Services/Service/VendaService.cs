using Business.Interfaces;
using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Service
{
    public class VendaService : IVendaService
    {
        private readonly Context _context;
        public VendaService(Context context)
        {
            _context = context;
        }


        public void GravarVenda(Vendas vendas)
        {
            if (vendas.QtdUnidadesVendidas > ValidaQtdSaida(vendas.idFuncionario, vendas.CodigoProduto))
            {
                throw new Exception($"A quantidade informada para o produto { vendas.CodigoProduto } é maior que a quantidade retirada!");
            }

            _context.Vendas.Add(vendas);
            _context.SaveChanges();
        }

        public void GravarSaidaVenda(List<SaidaVenda> saidaVenda)
        {
            var estoque = new EstoqueService(_context);
            for (int i = 0; i < saidaVenda.Count; i++)
            {
                if (estoque.RetornaEstoque(saidaVenda[i].CodigoProduto) < saidaVenda[i].QtdQuantidadeRetirada)
                {
                    throw new Exception($"Quantidade do produto { saidaVenda[i].CodigoProduto } indisponível no estoque!");
                }

                _context.saidaVendas.Add(saidaVenda[i]);
                _context.SaveChanges();
            }
        }

        private int ValidaQtdSaida(int IdFuncionario, string Codigoproduto)
        {
            return _context.saidaVendas.Where(v => v.idFuncionario == IdFuncionario && v.CodigoProduto == Codigoproduto).FirstOrDefault().QtdQuantidadeRetirada;
        }

    }
}
