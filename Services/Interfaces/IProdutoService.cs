using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produtos>> ListarProdutos();
        void GravarProdutos(Produtos produtos);

        void GravarEstoque(Estoque estoque);
    }
}
