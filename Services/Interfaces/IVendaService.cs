using Models;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface IVendaService
    {

        void GravarVenda(Vendas vendas);
        void GravarSaidaVenda(List<SaidaVenda> saidaVenda);
    }
}
