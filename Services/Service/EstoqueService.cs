using Business.Interfaces;
using DataAccess;
using System.Linq;

namespace Business.Service
{
    public class EstoqueService : IEstoqueService
    {
        private readonly Context _context;
        public EstoqueService(Context context)
        {
            _context = context;
        }
        public int RetornaEstoque(string CodigoProduto)
        {
            int estoque = _context.Estoque.Where(e => e.CodigoProduto == CodigoProduto).FirstOrDefault().QtdProduto;

            return estoque;
        }
    }
}
