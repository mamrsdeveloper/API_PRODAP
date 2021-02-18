using Business.Interfaces;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly Context _context;
        public ProdutoService(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Produtos>> ListarProdutos()
        {
            return await _context.Produtos.ToArrayAsync();
        }


        public void GravarProdutos(Produtos produtos)
        {
            if (produtos.IdProduto > 0)
            {
                _context.Produtos.Update(produtos);
            }
            else
            {
                _context.Produtos.Add(produtos);
            }
            _context.SaveChanges();
        }

        public void GravarEstoque(Estoque estoque)
        {
            _context.Estoque.Add(estoque);
            _context.SaveChanges();
        }
    }
}
